using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEditor.Experimental;

using System.IO;
using Newtonsoft.Json;




namespace PoseDump
{
	public class PoseMain
	{
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
			};

			string inputKey;
			InputAction action;

			foreach (string keyMapping in KeySchematic)
			{
				string[] KeyParts = keyMapping.Split('>');

				inputKey = "Dump-" + KeyParts[0].Trim();

				if (!InputSystem.Has(inputKey))
				{
					ModAPI.RegisterInput("[Dump] " + KeyParts[1].Trim(), inputKey, (KeyCode)Enum.Parse(typeof(KeyCode), KeyParts[2].Trim()));

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
					ModAPI.RegisterInput("[Dump] " + KeyParts[1].Trim(), inputKey, action.Key);

					InputAction actionNew  = InputSystem.Actions[inputKey];
					actionNew.SecondaryKey = action.SecondaryKey;
				}
			}
		}
	}


	public class PoseDump : MonoBehaviour
	{
		public static string posePath = "poses/";
		public static string poseFile = posePath + "poseFile.json";
		public static float ThumbnailPadding = 1.5f;

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

			string LogData = "";

			string hr = new string('-', 84);

			foreach (KeyValuePair<int, RagdollPose> Rag in Rags)
			{
				Rag.Value.ConstructDictionary();
				
				foreach (RagdollPose.LimbPose limbPose in Rags[Rag.Key].Angles)
				{
					LogData += limbPose.Name + ":" + limbPose.Angle + ",\n";
				}

			}

			File.WriteAllText( poseFile, LogData );

			ObjectState[] states = ObjectStateConverter.Convert(gObjs.ToArray(), person.Limbs[3].transform.position);

			ContraptionSerialiser.SaveThumbnail(states, "poserDump");

		}

		public static void ActivatePose()
		{
			string poseFile = "C:\\pp\\poses\\export.txt";

			if (!File.Exists(poseFile)) return;

			string poseText = File.ReadAllText(poseFile);




		}

	}






}
