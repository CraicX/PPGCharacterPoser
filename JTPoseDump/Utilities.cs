using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Reflection;


namespace JTPoseDump
{
	public static class Utilities
	{

		public static void Setup()
		{
			CreateFolders();

			EditPose.SetCurrentPose();
			EditPose.SetCurrentData();

		}

		public static void CreateFolders()
		{
			Config.ImagePath     = Path.Combine(Application.StartupPath, "PoseImages");
			Config.DataPath      = Path.Combine(Application.StartupPath, "PoseData");
			Config.PoseImagePath = "C:\\pp\\Contraptions\\poserDump";
			Config.PoseDataPath  = "C:\\pp\\poses";
			
			Config.PoseImageFile = "C:\\pp\\Contraptions\\poserDump\\poserDump.png";
			Config.PoseDataFile  = "C:\\pp\\poses\\poseFile.json";

			if (!Directory.Exists(Config.ImagePath)) Directory.CreateDirectory(Config.ImagePath);
			if (!Directory.Exists(Config.DataPath)) Directory.CreateDirectory(Config.DataPath);
			if (!Directory.Exists(Config.PoseImagePath)) Directory.CreateDirectory(Config.PoseImagePath);
			if (!Directory.Exists(Config.PoseDataPath)) Directory.CreateDirectory(Config.PoseDataPath);
		}

		public static string GetLastTime( string path )
		{
			if (!File.Exists(path)) return "";

			DateTime dt = File.GetLastWriteTime(path);

			return dt.ToString();
		}


		public static Image CropImage( Image imageIn, int pixels )
		{
			int oldWidth  = imageIn.Width, oldHeight = imageIn.Height;
			int newWidth  = oldWidth - pixels * 2;
			int newHeight = (int)(oldHeight * newWidth / oldWidth);


			Rectangle cropRect = new Rectangle(pixels, pixels,newWidth,newHeight);
			Bitmap src         = imageIn as Bitmap;
			Bitmap target      = new Bitmap(cropRect.Width, cropRect.Height);

			using(Graphics g = Graphics.FromImage(target))
			   g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);


			return target;
		}

		public static Object GetPropValue(this Object obj, String name) {
			foreach (String part in name.Split('.')) {
				if (obj == null) { return null; }

				Type type = obj.GetType();
				PropertyInfo info = type.GetProperty(part);
				if (info == null) { return null; }

				obj = info.GetValue(obj, null);
			}
			return obj;
		}

		public static T GetPropValue<T>(this Object obj, String name) {
			Object retval = GetPropValue(obj, name);
			if (retval == null) { return default(T); }

			// throws InvalidCastException if types are incompatible
			return (T) retval;
		}

	}




}
