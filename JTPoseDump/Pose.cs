using System;
using System.Linq;
using System.ComponentModel;

namespace JTPoseDump
{
	public class PoseClass
	{
		private string _Name         = "";
		private int _Number          = 0;
		private float _Head          = 0f;
		private float _UpperBody     = 0f;
		private float _MiddleBody    = 0f;
		private float _LowerBody     = 0f;
		private float _UpperArm      = 0f;
		private float _UpperArmFront = 0f;
		private float _LowerArm      = 0f;
		private float _LowerArmFront = 0f;
		private float _UpperLeg      = 0f;
		private float _UpperLegFront = 0f;
		private float _LowerLeg      = 0f;
		private float _LowerLegFront = 0f;
		private float _Foot          = 0f;
		private float _FootFront     = 0f;
		private string _ConfigName   = "";

		public bool DoAuto = false;

		private bool _Animated = false, _ShouldStumble = false, _ShouldStandUpright = true;
			
		private float _Rigidity = 1.3f, _DragInfluence=1f, _UprightForceMultiplier = 2f, _AnimationSpeedMultiplier = 1.5f, _PoseRigidityModifier=0f;

		private PoseStates _PoseState = PoseStates.Rest;
		
		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public PoseStates PoseState
		{
			get { return _PoseState; }
			set { _PoseState = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public bool ShouldStandUpright
		{
			get { return _ShouldStandUpright; }
			set { _ShouldStandUpright = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public bool ShouldStumble
		{
			get { return _ShouldStumble; }
			set { _ShouldStumble = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public bool Animated
		{
			get { return _Animated; }
			set { _Animated = value; }
		}


		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public float UprightForceMultiplier
		{
			get { return _UprightForceMultiplier; }
			set { _UprightForceMultiplier = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public float AnimationSpeedMultiplier
		{
			get { return _AnimationSpeedMultiplier; }
			set { _AnimationSpeedMultiplier = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public float PoseRigidityModifier
		{
			get { return _PoseRigidityModifier; }
			set { _PoseRigidityModifier = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public float Rigidity
		{
			get { return _Rigidity; }
			set { _Rigidity = value; }
		}

		[Category( "Settings" ), Description( "" ), Browsable( true )]
		public float DragInfluence
		{
			get { return _DragInfluence == 0 ? 1 : _DragInfluence; }
			set { _DragInfluence = value; }
		}


		public float FRound( float num )
		{
			string bum = num.ToString();
			if (bum.Contains('E')) num = float.Parse(bum.Substring(0,bum.IndexOf('E')-1));

			string numString = num.ToString("0.0000");
			
			return float.Parse(numString);
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

		[Category( "Info" ), Description( "Name of the pose" ), Browsable( true ), DisplayName( "(Name)" )]
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		[Category( "Info" ), Description( "Preset Configuration" ), Browsable( true )]
		public string ConfigName
		{
			get { return _ConfigName; }
			set { _ConfigName = value; }
		}

		[Category( "Info" ), Description( "Pose# if part of a series" ), Browsable( true )]
		public int Number
		{
			get { return _Number; }
			set { _Number = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Head"), Browsable(true)]  
		public float Head
		{
			get { return FRound(_Head); }
			set { 
				_Head = value; 
			}
		}

		[Category("Limb Angles"), Description("The Angle for the Upper Body"), Browsable(true)]  
		public float UpperBody
		{
			get { return FRound(_UpperBody); }
			set { _UpperBody = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Middle Body"), Browsable(true)]  
		public float MiddleBody
		{
			get { return FRound(_MiddleBody); }
			set { _MiddleBody = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Lower Body"), Browsable(true)]  
		public float LowerBody
		{
			get { return FRound(_LowerBody); }
			set { _LowerBody = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Lower Arm"), Browsable(true)]  
		public float LowerArmFront
		{
			get { return FRound(_LowerArmFront); }
			set { _LowerArmFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Upper Arm"), Browsable(true)]  
		public float UpperArmFront
		{
			get { return FRound(_UpperArmFront); }
			set { _UpperArmFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Lower Arm"), Browsable(true)]  
		public float LowerArm
		{
			get { return FRound(_LowerArm); }
			set { _LowerArm = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Upper Arm"), Browsable(true)]  
		public float UpperArm
		{
			get { return FRound(_UpperArm); }
			set { _UpperArm = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Upper Leg"), Browsable(true)]  
		public float UpperLeg
		{
			get { return FRound(_UpperLeg); }
			set { _UpperLeg = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Upper Leg"), Browsable(true)]  
		public float UpperLegFront
		{
			get { return FRound(_UpperLegFront); }
			set { _UpperLegFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Lower Leg"), Browsable(true)]  
		public float LowerLeg
		{
			get { return _LowerLeg; }
			set { _LowerLeg = value; }
		}


		[Category("Limb Angles"), Description("The Angle for the Lower Front Leg"), Browsable(true)]  
		public float LowerLegFront
		{
			get { return FRound(_LowerLegFront); }
			set { _LowerLegFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Foot"), Browsable(true)]  
		public float Foot
		{
			get { return FRound(_Foot); }
			set { _Foot = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Foot"), Browsable(true)]  
		public float FootFront
		{
			get { return FRound(_FootFront); }
			set { _FootFront = value; }
		}

		

	}
}
