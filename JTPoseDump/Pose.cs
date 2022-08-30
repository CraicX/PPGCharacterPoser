using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace JTPoseDump
{
	public class PoseClass
	{
		private string _Name;
		private int _Number;
		private float _Head;
		private float _UpperBody;
		private float _MiddleBody;
		private float _LowerBody;
		private float _UpperArm;
		private float _UpperArmFront;
		private float _LowerArm;
		private float _LowerArmFront;
		private float _UpperLeg;
		private float _UpperLegFront;
		private float _LowerLeg;
		private float _LowerLegFront;
		private float _Foot;
		private float _FootFront;

		[Category( "Info" ), Description( "Name of the pose" ), Browsable( true )]
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
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
			get { return _Head; }
			set { 
				_Head = value; 
			}
		}

		[Category("Limb Angles"), Description("The Angle for the Upper Body"), Browsable(true)]  
		public float UpperBody
		{
			get { return _UpperBody; }
			set { _UpperBody = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Middle Body"), Browsable(true)]  
		public float MiddleBody
		{
			get { return _MiddleBody; }
			set { _MiddleBody = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Lower Body"), Browsable(true)]  
		public float LowerBody
		{
			get { return _LowerBody; }
			set { _LowerBody = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Lower Arm"), Browsable(true)]  
		public float LowerArmFront
		{
			get { return _LowerArmFront; }
			set { _LowerArmFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Upper Arm"), Browsable(true)]  
		public float UpperArmFront
		{
			get { return _UpperArmFront; }
			set { _UpperArmFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Lower Arm"), Browsable(true)]  
		public float LowerArm
		{
			get { return _LowerArm; }
			set { _LowerArm = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Upper Arm"), Browsable(true)]  
		public float UpperArm
		{
			get { return _UpperArm; }
			set { _UpperArm = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Upper Leg"), Browsable(true)]  
		public float UpperLeg
		{
			get { return _UpperLeg; }
			set { _UpperLeg = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Upper Leg"), Browsable(true)]  
		public float UpperLegFront
		{
			get { return _UpperLegFront; }
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
			get { return _LowerLegFront; }
			set { _LowerLegFront = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Foot"), Browsable(true)]  
		public float Foot
		{
			get { return _Foot; }
			set { _Foot = value; }
		}

		[Category("Limb Angles"), Description("The Angle for the Front Foot"), Browsable(true)]  
		public float FootFront
		{
			get { return _FootFront; }
			set { _FootFront = value; }
		}

		

	}
}
