using System.Collections.Specialized;
using System.Drawing;

namespace JTPoseCore
{
	public static class Config
	{
		public static string GamePath, ImagePath, PoseDataPath, PoseDataFile, PoseImagePath, PoseImageFile, DataPath, ResourcesPath, ModPath;

		public static NameValueCollection AppSettings;

		public static string LastImageTime = "";
		public static string LastDataTime  = "";

		public static Settings FSettings = null;

		public static MainForm mainForm;
		public static BrowsePose BPose;

		public static Image MissingImage;

		public static bool DoImageSwap = false, DoAutoSwap  = false;

		private static PoseImageView _PIView = PoseImageView.GridView;

		public static int TabsExport = 3;

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

				BPose.ResizeAll(value == PoseImageView.GridView ? 75 : 175);
			}
		}

	}

	public struct LimbAngle
	{
		public string Name;
		public float Angle;

		public LimbAngle( string input )
		{
			string[] parts = input.Split(':');

			Name  = parts[0];
			if (float.TryParse( parts[1], out float val ) ) Angle = val;
			else Angle = 0f;
		}
	}

	public struct PoseObject
	{
		public PoseClass PoseClass;
		public string PoseName;
		public PoseControl PoseControl;
		public string JsonDump;
		public string ImagePath;
		public string DataPath;
		
	}

	public enum PoseImageView
	{
		GridView,
		FullWidth,
	}
}
