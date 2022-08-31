using System;
using System.Reflection;

namespace PoseDump
{
	public class PoseClass
	{
		private string _Name = "";
		private int _Number = 0;
		private float _Head = 0f;
		private float _UpperBody = 0f;
		private float _MiddleBody = 0f;
		private float _LowerBody = 0f;
		private float _UpperArm = 0f;
		private float _UpperArmFront = 0f;
		private float _LowerArm = 0f;
		private float _LowerArmFront = 0f;
		private float _UpperLeg = 0f;
		private float _UpperLegFront = 0f;
		private float _LowerLeg = 0f;
		private float _LowerLegFront = 0f;
		private float _Foot = 0f;
		private float _FootFront = 0f;
		private string _ConfigName = "";

		public bool HasAngle(string limbName)  => (bool)(GetPropValue<float>(this, limbName) != 0f);
		public float GetAngle(string limbName) => (float)GetPropValue<float>(this, limbName);

		private bool _Animated = false, _ShouldStumble = false, _ShouldStandUpright = true;
			
		private float _Rigidity = 1.3f, _DragInfluence=0f, _UprightForceMultiplier = 2f, _AnimationSpeedMultiplier = 1.5f, _PoseRigidityModifier=0f;

		private PoseStates _PoseState = PoseStates.Rest;
		
		public PoseStates PoseState
		{
			get { return _PoseState; }
			set { _PoseState = value; }
		}

		public bool ShouldStandUpright
		{
			get { return _ShouldStandUpright; }
			set { _ShouldStandUpright = value; }
		}

		public bool ShouldStumble
		{
			get { return _ShouldStumble; }
			set { _ShouldStumble = value; }
		}

		public bool Animated
		{
			get { return _Animated; }
			set { _Animated = value; }
		}


		public float UprightForceMultiplier
		{
			get { return _UprightForceMultiplier; }
			set { _UprightForceMultiplier = value; }
		}

		public float AnimationSpeedMultiplier
		{
			get { return _AnimationSpeedMultiplier; }
			set { _AnimationSpeedMultiplier = value; }
		}

		public float PoseRigidityModifier
		{
			get { return _PoseRigidityModifier; }
			set { _PoseRigidityModifier = value; }
		}

		public float Rigidity
		{
			get { return _Rigidity; }
			set { _Rigidity = value; }
		}

		public float DragInfluence
		{
			get { return _DragInfluence; }
			set { _DragInfluence = value; }
		}


		
		
		public enum PoseStates
		{
			Rest,
			Protective,
			Flailing,
			Stumbling,
			Swimming,
			WrithingInPain,
			Walking,
			Sitting,
			Flat,
			BrainDamage
		}

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public string ConfigName
		{
			get { return _ConfigName; }
			set { _ConfigName = value; }
		}

		public int Number
		{
			get { return _Number; }
			set { _Number = value; }
		}

		public float Head
		{
			get { return _Head; }
			set { 
				_Head = value; 
			}
		}

		public float UpperBody
		{
			get { return _UpperBody; }
			set { _UpperBody = value; }
		}

		public float MiddleBody
		{
			get { return _MiddleBody; }
			set { _MiddleBody = value; }
		}

		public float LowerBody
		{
			get { return _LowerBody; }
			set { _LowerBody = value; }
		}

		public float LowerArmFront
		{
			get { return _LowerArmFront; }
			set { _LowerArmFront = value; }
		}

		public float UpperArmFront
		{
			get { return _UpperArmFront; }
			set { _UpperArmFront = value; }
		}

		public float LowerArm
		{
			get { return _LowerArm; }
			set { _LowerArm = value; }
		}

		public float UpperArm
		{
			get { return _UpperArm; }
			set { _UpperArm = value; }
		}

		public float UpperLeg
		{
			get { return _UpperLeg; }
			set { _UpperLeg = value; }
		}

		public float UpperLegFront
		{
			get { return _UpperLegFront; }
			set { _UpperLegFront = value; }
		}

		public float LowerLeg
		{
			get { return _LowerLeg; }
			set { _LowerLeg = value; }
		}


		public float LowerLegFront
		{
			get { return _LowerLegFront; }
			set { _LowerLegFront = value; }
		}

		public float Foot
		{
			get { return _Foot; }
			set { _Foot = value; }
		}

		public float FootFront
		{
			get { return _FootFront; }
			set { _FootFront = value; }
		}

		
		public Object GetPropValue(Object obj, String name) {
			foreach (String part in name.Split('.')) {
				if (obj == null) { return null; }

				Type type = obj.GetType();
				PropertyInfo info = type.GetProperty(part);
				if (info == null) { return null; }

				obj = info.GetValue(obj, null);
			}
			return obj;
		}

		public T GetPropValue<T>(Object obj, String name) {
			Object retval = GetPropValue(obj, name);
			if (retval == null) { return default(T); }

			// throws InvalidCastException if types are incompatible
			return (T) retval;
		}
	}

}
