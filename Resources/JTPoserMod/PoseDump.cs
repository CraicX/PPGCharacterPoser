using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Reflection;
using System.Collections;

namespace PoseDump
{
	public class PoseMain
	{
		public static void OnLoad()
		{
			BindKeys();
		}
		
		public static void Main()
		{
			ModAPI.Register<PoseDump>();
		}

		public static bool KeyCheck(string _name)
		{
			if (DialogBox.IsAnyDialogboxOpen || Global.ActiveUiBlock) return false;

			return (InputSystem.Down(_name));
		}

		private static void BindKeys()
		{
			string[] KeySchematic =
			{
				"dumpPose  > Dump pose from selected person > F3",
				"doPose    > Import pose and move into pose > F4",
				"autoPose  > Automatically swap poses whenever selected > F4 > LeftShift",
			};

			string inputKey;
			InputAction action;

			foreach (string keyMapping in KeySchematic)
			{
				string[] KeyParts = keyMapping.Split('>');

				inputKey = "JTPD-" + KeyParts[0].Trim();

				if (!InputSystem.Has(inputKey))
				{
					ModAPI.RegisterInput("[JTPD] " + KeyParts[1].Trim(), inputKey, (KeyCode)Enum.Parse(typeof(KeyCode), KeyParts[2].Trim()));

					if (KeyParts.Length == 4)
					{
						InputAction actionCreate = new InputAction(
							(KeyCode)Enum.Parse(typeof(KeyCode), KeyParts[2].Trim()),
							(KeyCode)Enum.Parse(typeof(KeyCode), KeyParts[3].Trim())
						);

						InputSystem.Actions.Add(inputKey, actionCreate);
					}
				}
				else
				{
					action = InputSystem.Actions[inputKey];
					ModAPI.RegisterInput("[JTPD] " + KeyParts[1].Trim(), inputKey, action.Key);

					InputAction actionNew  = InputSystem.Actions[inputKey];
					actionNew.SecondaryKey = action.SecondaryKey;
				}
			}
		}
	}


	public class PoseDump : MonoBehaviour
	{
		public static float ThumbnailPadding = 1.5f;
		public static RagdollPose Ragdoll;
		public static PoseConfig PConfig;
		public static PoseClass poseClass;

		public static int poseID;

		public static bool DoAutoSwap = false;

		public static string PoseFile = "JTPoserMod/poseFile.json";
		public static string AutoFile = "JTPoserMod/exportauto.json";


		public static Dictionary<string, LimbMove> moves = new Dictionary<string, LimbMove>();

		IEnumerator ICheckAuto()
		{

			List<PersonBehaviour> People = new List<PersonBehaviour>();


			for (; ; )
			{
				People.Clear();
				if (File.Exists("mods/" + AutoFile))
				{
					PoseClass poseClass = ModAPI.DeserialiseJSON<PoseClass>(AutoFile);


					foreach (PhysicalBehaviour PB in GetSelected(true))
					{
						PersonBehaviour person = PB.gameObject.GetComponentInParent<PersonBehaviour>();

						if (!person || People.Contains(person)) continue; 

						People.Add(person);
					}

					foreach ( PersonBehaviour PBO in People )
					{
						ImportPose(PBO, poseClass);

						PBO.OverridePoseIndex = poseID;
					}

					File.Delete("mods/" + AutoFile);
				}

				yield return new WaitForSeconds(1);
			}
		}

		public void Start()
		{
			StartCoroutine(ICheckAuto());
		}


		public void Update()
		{
			bool ModifierKey = (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift));
			
			if (PoseMain.KeyCheck("JTPD-dumpPose")) DumpPose(GetSelected());
			if (PoseMain.KeyCheck("JTPD-doPose")) {
				if (ModifierKey) {
					DoAutoSwap = !DoAutoSwap;
					ModAPI.Notify("AutoSwap is " + (DoAutoSwap ? "<color=yellow>Active" : "<color=red>off"));
				}
				else ActivatePose(GetSelected());
			}
		}

		static PoseConfig GetConfig( string configName ) => ( PoseConfigs.TryGetValue( configName, out PoseConfig config ) ) 
															? config : new PoseConfig();

		public static void DumpPose(List<PhysicalBehaviour> PBS)
		{
			List<GameObject> gObjs = new List<GameObject>();
			
			Dictionary<int, RagdollPose> Rags = new Dictionary<int, RagdollPose>();

			Dictionary<string, RagdollPose.LimbPose> Poses = new Dictionary<string, RagdollPose.LimbPose>();  

			PersonBehaviour person = null;

			foreach (PhysicalBehaviour PB in PBS)
			{
				person = PB.gameObject.GetComponentInParent<PersonBehaviour>();

				if (!person) continue; 

				gObjs.Add(PB.gameObject);

				int PHash = person.GetHashCode();   

				if (!Rags.ContainsKey(PHash) ) {

					Rags[PHash] = new RagdollPose() {
						Angles = new List<RagdollPose.LimbPose>()
					};

				}

				if (PB.TryGetComponent<LimbBehaviour>(out LimbBehaviour limb))
				{
					Rags[PHash].Angles.Add(new RagdollPose.LimbPose(limb, limb.HasJoint ? limb.Joint.jointAngle : 0f));
				}

			}

			if (Rags.Count < 1)
			{
				ModAPI.Notify("<color=red>Pose Failed:</color> No people in selection");
				return;
			}

			PoseClass CurrentPose = new PoseClass();
			Type type = CurrentPose.GetType();

			foreach (KeyValuePair<int, RagdollPose> Rag in Rags)
			{
				foreach (RagdollPose.LimbPose limbPose in Rags[Rag.Key].Angles)
				{
					PropertyInfo prop = type.GetProperty(limbPose.Name);
					prop.SetValue (CurrentPose, limbPose.Angle, null);
				}
			}

			ModAPI.SerialiseJSON(CurrentPose, PoseFile);

			ObjectState[] states = ObjectStateConverter.Convert(gObjs.ToArray(), person.Limbs[3].transform.position);

			ContraptionSerialiser.SaveThumbnail(states, "poserDump");

		}

		public static void ActivatePose(List<PhysicalBehaviour> PBS)
		{
			string jsonFile = "JTPoserMod/export.json";
			

			PoseClass poseClass = ModAPI.DeserialiseJSON<PoseClass>(jsonFile);
			
			ModAPI.Notify( "++" );

			List<PersonBehaviour> People = new List<PersonBehaviour>();

			foreach (PhysicalBehaviour PB in PBS)
			{
				PersonBehaviour person = PB.gameObject.GetComponentInParent<PersonBehaviour>();

				if (!person || People.Contains(person)) continue; 

				People.Add(person);
			}

			foreach ( PersonBehaviour PBO in People )
			{
				ImportPose(PBO, poseClass);

				PBO.OverridePoseIndex = poseID;
			}

		}

		public static void ImportPose( PersonBehaviour PBO, PoseClass PoseData )
		{
			string poseName = "JTPD_" + PoseData.GetHashCode().ToString();
			
			if (PoseData.ConfigName != "") {

				PConfig = GetConfig( PoseData.ConfigName );

			} else PConfig = new PoseConfig();

			if (PoseData.Rigidity != 0) PConfig.Rigidity                                 = PoseData.Rigidity;
			if (PoseData.DragInfluence != 0) PConfig.DragInfluence                       = PoseData.DragInfluence;
			if (PoseData.UprightForceMultiplier != 0) PConfig.UprightForceMultiplier     = PoseData.UprightForceMultiplier;
			if (PoseData.AnimationSpeedMultiplier != 0) PConfig.AnimationSpeedMultiplier = PoseData.AnimationSpeedMultiplier;

			PConfig.ShouldStandUpright = PoseData.ShouldStandUpright;
			PConfig.ShouldStumble      = PoseData.ShouldStumble;


			if (PoseData.PoseState == PoseClass.PoseStates.Rest)    PConfig.State = PoseState.Rest;
			if (PoseData.PoseState == PoseClass.PoseStates.Walking) PConfig.State = PoseState.Walking;



			Ragdoll   = new RagdollPose()
			{
				Name                     = poseName,
				Rigidity                 = PConfig.Rigidity,
				ShouldStandUpright       = PConfig.ShouldStandUpright,
				DragInfluence            = PConfig.DragInfluence,
				UprightForceMultiplier   = PConfig.UprightForceMultiplier,
				ShouldStumble            = PConfig.ShouldStumble,
				State                    = PConfig.State,
				AnimationSpeedMultiplier = PConfig.AnimationSpeedMultiplier,
				Angles                   = new List<RagdollPose.LimbPose>(),
			};

			RagdollPose.LimbPose limbPose;

			foreach (LimbBehaviour limb in PBO.Limbs)
			{
				if (limb.HasJoint && PoseData.HasAngle(limb.name))
				{
					limbPose = new RagdollPose.LimbPose(limb, PoseData.GetAngle(limb.name))
					{
						Name                 = poseName,
						Limb                 = limb,
						Animated             = PConfig.Animated,
						PoseRigidityModifier = PConfig.PoseRigidityModifier,
						StartAngle           = 0f,
						EndAngle             = 0f,
						AnimationDuration    = 0f,
						RandomInfluence      = PConfig.RandomInfluence,
						RandomSpeed          = PConfig.RandomSpeed,
						TimeOffset           = PConfig.TimeOffset,
						AnimationCurve       = new AnimationCurve(),
					};
				}
				else 
				{
					limbPose = new RagdollPose.LimbPose(limb,0f)
					{
						Name                 = poseName,
						Limb                 = limb,
						Animated             = false,
						PoseRigidityModifier = 0f,
						Angle                = 0f,
						StartAngle           = 0f,
						EndAngle             = 0f,
						AnimationDuration    = 0f,
						RandomInfluence      = 0f,
						RandomSpeed          = 0f,
						TimeOffset           = 0f,
						AnimationCurve       = new AnimationCurve(),
					};
				}
				Ragdoll.Angles.Add(limbPose);
			}

			Ragdoll.ConstructDictionary();

			for (int pnum = PBO.Poses.Count; --pnum >= 0;)
			{
				if (PBO.Poses[pnum].Name == poseName)
				{
					poseID = pnum;

					PBO.Poses[pnum] = Ragdoll;

					return;
				}
			}

			PBO.Poses.Add(Ragdoll);

			poseID = PBO.Poses.Count -1;

			ModAPI.Notify("Pose Activated: " + PoseData.Name);
		}

		public static List<PhysicalBehaviour> GetSelected(bool pickSomeone = false)
		{
			List<PhysicalBehaviour> PBL = new List<PhysicalBehaviour>();

			foreach (PhysicalBehaviour PB in Global.main.PhysicalObjectsInWorld)
			{
				if (!PB.Selectable || PB.colliders.Length == 0) continue;

				foreach (Collider2D collider in PB.colliders)
				{
					if (!collider) continue;

					if (collider.OverlapPoint((Vector2)Global.main.MousePosition))
					{
						if (PB.transform.root.TryGetComponent<PhysicalBehaviour>(out PhysicalBehaviour component))
						{
							if (component.Selectable) PBL.Add(component);
						}
						else
						{
							PBL.Add(PB);
						}
					}
				}
			}
		
			if (SelectionController.Main.SelectedObjects.Count > 0) 
			PBL.AddRange(SelectionController.Main.SelectedObjects);

			if (PBL.Count == 0) {

				PersonBehaviour person = Global.FindObjectOfType<PersonBehaviour>();
			
				if (person != null) {

					foreach(LimbBehaviour Limb in person.Limbs) PBL.Add(Limb.PhysicalBehaviour);
				}

			}

			return PBL;

		}

		public struct PoseConfig
		{
			public string Name;
		
			public bool AutoStart, Animated, ShouldStumble, ShouldStandUpright, EnableArmAim, ComboMove;
			
			public float Rigidity, DragInfluence, UprightForceMultiplier, AnimationSpeedMultiplier, PoseRigidityModifier, 
						 StartAngle, EndAngle, AnimationDuration, RandomSpeed, RandomInfluence, TimeOffset, Force;

			public PoseState State;
			public RagdollPose PresetPose;

			public PoseConfig( string _name )
			{
				Name = _name;
				AutoStart = Animated = EnableArmAim = ComboMove = false;
				ShouldStumble = ShouldStandUpright = true;
				Rigidity = DragInfluence = UprightForceMultiplier = AnimationSpeedMultiplier = AnimationDuration = 0f;
				PoseRigidityModifier = StartAngle = EndAngle = RandomSpeed = RandomInfluence = TimeOffset = 0f;

				Force = 4f;

				State = PoseState.Rest;
				PresetPose = null;
			}
		}

		static Dictionary<string, PoseConfig> PoseConfigs = new Dictionary<string, PoseConfig>()
		{
			{ "Common", new PoseConfig() {
				State                    = PoseState.Rest,
				ShouldStandUpright		 = true,
				Rigidity                 = 1.3f,
				AnimationSpeedMultiplier = 1.5f,
				UprightForceMultiplier   = 2f,
				AutoStart                = true,
			} },
			{ "CommonDuck", new PoseConfig() {
				ShouldStandUpright       = true,
				State                    = PoseState.Rest,
				Rigidity                 = 1.7f,
				AnimationSpeedMultiplier = 2.5f,
				UprightForceMultiplier   = 1.4f,
				AutoStart                = true,
			} },
			{ "CommonDown", new PoseConfig() {
				ShouldStandUpright       = false,
				State                    = PoseState.Rest,
				Rigidity                 = 2.3f,
				AnimationSpeedMultiplier = 2.5f,
				UprightForceMultiplier   = 0f,
				AutoStart                = true,
			} },
			{ "NoAuto", new PoseConfig() {
				ShouldStandUpright       = false,
				State                    = PoseState.Rest,
				Rigidity                 = 2.3f,
				AnimationSpeedMultiplier = 2.5f,
				UprightForceMultiplier   = 4f,
				AutoStart                = true,
			} },
			{ "Combo", new PoseConfig() {
				ShouldStandUpright       = true,
				State                    = PoseState.Rest,
				ComboMove                = false,
				AutoStart                = true,
			} },
			{ "Gesture", new PoseConfig() {
				State                    = PoseState.Rest,
				ShouldStandUpright		 = true,
				Rigidity                 = 1.5f,
				AnimationSpeedMultiplier = 1f,
				UprightForceMultiplier   = 4f,
				AutoStart                = true,
			} },
		};

		public struct LimbMove
		{
			public string limbName;
			public float angle, rigid, force;
		}
	}
}
