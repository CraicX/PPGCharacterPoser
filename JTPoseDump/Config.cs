using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTPoseDump
{
	public static class Config
	{
		public static string ImagePath     = "";
		public static string PoseDataPath  = "";
		public static string PoseDataFile  = "";
		public static string PoseImagePath = "";
		public static string PoseImageFile = "";
		public static string DataPath      = "";

		public static string LastImageTime = "";
		public static string LastDataTime  = "";

		public static MainForm mainForm;

		private static PoseImageView _PIView = PoseImageView.FullWidth;


		public static string[] LimbNames =
		{
			"Head", 
			"UpperBody", 
			"MiddleBody",
			"LowerBody", 
			"UpperArm",
			"UpperArmFront", 
			"LowerArm", 
			"LowerArmFront", 
			"UpperLeg",
			"UpperLegFront",
			"LowerLeg",
			"LowerLegFront",
			"Foot",
			"FootFront",
		};




		public static PoseImageView PIView
		{
			get { return _PIView; }
			set { 
				_PIView = value; 
				EditPose.ResizePoseImages();
			}
		}

	}

	public enum PoseImageView
	{
		GridView,
		FullWidth,
	}
}
