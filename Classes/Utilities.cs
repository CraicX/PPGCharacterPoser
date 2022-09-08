using System.Reflection;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Windows.Gaming.Input;

namespace JTPoseCore
{
	public static class Utilities
	{

		public static void Setup()
		{
			Config.AppSettings = ReadAllSettings();


			CreateFolders();

			Config.MissingImage = LoadImageSafe( Path.Combine(Config.ResourcesPath, "missingpose.png" ) );

			EditPose.SetCurrentPose();
			EditPose.SetCurrentData();

			Config.BPose = new BrowsePose();
			Config.BPose.Refresh();


			if (Config.AppSettings.AllKeys.Contains("Width") && 
				int.TryParse(Config.AppSettings.Get("Width"), out int Width) && 
				int.TryParse(Config.AppSettings.Get("Height"), out int Height) ) Config.mainForm.Size = new (Width,Height);


			if (Config.AppSettings.AllKeys.Contains("X") && 
				int.TryParse(Config.AppSettings.Get("X"), out int X) && 
				int.TryParse(Config.AppSettings.Get("Y"), out int Y) ) Config.mainForm.Location = new (X,Y);


		}

		public static void CreateFolders()
		{
			Config.ImagePath = Config.PoseDataPath= Config.PoseDataFile= Config.PoseImagePath= Config.PoseImageFile= Config.DataPath= Config.ResourcesPath= Config.ModPath= "";

			Config.GamePath      = Config.AppSettings.Get("GamePath");
			Config.ImagePath     = Path.Combine(Application.LocalUserAppDataPath, "PoseImages");
			Config.DataPath      = Path.Combine(Application.LocalUserAppDataPath, "PoseData");
			Config.ResourcesPath = Path.Combine(Application.StartupPath, "Resources");


			if (Config.GamePath     != "" && Directory.Exists(Config.GamePath)) { 
				Config.PoseImagePath = Path.Combine(Config.GamePath, "Contraptions", "poserDump");
				Config.PoseDataPath  = Config.ModPath = Path.Combine(Config.GamePath, "mods", "JTPoserMod");
				Config.PoseImageFile = Path.Combine(Config.GamePath, "Contraptions", "poserDump", "poserDump.png");
				Config.PoseDataFile  = Path.Combine(Config.PoseDataPath, "poseFile.json");

				if (!Directory.Exists(Config.ImagePath)) Directory.CreateDirectory(Config.ImagePath);
				if (!Directory.Exists(Config.DataPath)) Directory.CreateDirectory(Config.DataPath);
				if (!Directory.Exists(Config.PoseImagePath)) Directory.CreateDirectory(Config.PoseImagePath);
				if (!Directory.Exists(Config.PoseDataPath)) Directory.CreateDirectory(Config.PoseDataPath);
				if (!Directory.Exists(Config.ModPath)) Directory.CreateDirectory(Config.ModPath);

				
			}
		}

		public static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			//Now Create all of the directories
			foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
			{
				Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
			}

			//Copy all the files & Replaces any files with the same name
			foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",SearchOption.AllDirectories))
			{
				File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
			}
		}

		public static void ShowSettings()
		{
			if (Config.FSettings != null ) { Config.FSettings.ShowDialog(); return; }

			Config.FSettings = new Settings();
			Config.FSettings.ShowDialog();
			Config.FSettings.Location = Config.mainForm.Location;
		}

		public static string GetLastTime( string path )
		{
			if (!File.Exists(path)) return "";

			DateTime dt = File.GetLastWriteTime(path);

			return dt.ToString();
		}

		public static IEnumerable<string> SplitToLines(this string input)
		{
			if (input == null)
			{
				yield break;
			}

			using System.IO.StringReader reader = new ( input );
			string line;
			while ( ( line = reader.ReadLine() ) != null )
			{
				yield return line;
			}
		}


		public static Image CropImage( Image imageIn, int pixels )
		{
			int oldWidth  = imageIn.Width, oldHeight = imageIn.Height;
			int newWidth  = oldWidth - pixels * 2;
			int newHeight = (int)(oldHeight * newWidth / oldWidth);


			Rectangle cropRect = new (pixels, pixels,newWidth,newHeight);
			Bitmap src         = imageIn as Bitmap;
			Bitmap target      = new (cropRect.Width, cropRect.Height);

			using(Graphics g = Graphics.FromImage(target))
			   g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);


			return target;
		}

		public static object GetPropValue(this object obj, string name) {
			foreach (string part in name.Split('.')) {
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
			if (retval == null) { return default; }

			return (T) retval;
		}

		public static Image LoadImage(string imgPath)
        {
            if (File.Exists(imgPath))
            {

                Bitmap bmpTemp = new(imgPath);
                Bitmap MyImage = new(bmpTemp);

                return MyImage;
            }

            return new System.Drawing.Bitmap(48, 48);
        }

		public static Bitmap LoadImageSafe(String path)
		{
			using Bitmap sourceImage = new( path );
			return CloneImage( sourceImage );
		}

		public static void ScaleFont(Label lab)
		{
			SizeF extent  = TextRenderer.MeasureText(lab.Text, lab.Font);
			float hRatio  = lab.Height / extent.Height;
			float wRatio  = (lab.Width - 5) / extent.Width;
			if (hRatio > 100 || wRatio > 100) return;
			float ratio   = (hRatio < wRatio) ? hRatio : wRatio;
			float newSize = lab.Font.Size * ratio;
			lab.Font      = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
		}

		public static Bitmap CloneImage(Bitmap sourceImage)
		{
			Rectangle rect        = new(0, 0, sourceImage.Width, sourceImage.Height);
			Bitmap targetImage    = new(rect.Width, rect.Height, sourceImage.PixelFormat);
			targetImage.SetResolution(sourceImage.HorizontalResolution, sourceImage.VerticalResolution);
			BitmapData sourceData = sourceImage.LockBits(rect, ImageLockMode.ReadOnly, sourceImage.PixelFormat);
			BitmapData targetData = targetImage.LockBits(rect, ImageLockMode.WriteOnly, targetImage.PixelFormat);
			Int32 actualDataWidth = ((Image.GetPixelFormatSize(sourceImage.PixelFormat) * rect.Width) + 7) / 8;
			Int32 h               = sourceImage.Height;
			Int32 origStride      = sourceData.Stride;
			Boolean isFlipped     = origStride < 0;
			origStride            = Math.Abs(origStride); // Fix for negative stride in BMP format.
			Int32 targetStride    = targetData.Stride;
			Byte[] imageData      = new Byte[actualDataWidth];
			IntPtr sourcePos      = sourceData.Scan0;
			IntPtr destPos        = targetData.Scan0;
			// Copy line by line, skipping by stride but copying actual data width
			for (Int32 y = 0; y < h; y++)
			{
				Marshal.Copy(sourcePos, imageData, 0, actualDataWidth);
				Marshal.Copy(imageData, 0, destPos, actualDataWidth);
				sourcePos = new IntPtr(sourcePos.ToInt64() + origStride);
				destPos   = new IntPtr(destPos.ToInt64() + targetStride);
			}
			targetImage.UnlockBits(targetData);
			sourceImage.UnlockBits(sourceData);
			// Fix for negative stride on BMP format.
			if (isFlipped)
				targetImage.RotateFlip(RotateFlipType.Rotate180FlipX);
			// For indexed images, restore the palette. This is not linking to a referenced
			// object in the original image; the getter of Palette creates a new object when called.
			if ((sourceImage.PixelFormat & PixelFormat.Indexed) != 0)
				targetImage.Palette = sourceImage.Palette;
			// Restore DPI settings
			targetImage.SetResolution(sourceImage.HorizontalResolution, sourceImage.VerticalResolution);
			return targetImage;
		}


		public static NameValueCollection ReadAllSettings()  
        {  
            try  
            {  
                return ConfigurationManager.AppSettings;
            }  
            catch (ConfigurationErrorsException)  
            {  
                Console.WriteLine("Error reading app settings");  
				return null;
            }  
        } 

		public static void AddUpdateAppSettings(string key, string value)  
        {  
            try  
            {  
                Configuration configFile                 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);  
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;  
                
				if (settings[key] == null)  settings.Add(key, value);  
                else  settings[key].Value = value;  
                
				configFile.Save(ConfigurationSaveMode.Modified);  
                
				ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);  
            }  

            catch (ConfigurationErrorsException)  
            {  
                Console.WriteLine("Error writing app settings");  
            }  
        } 

	}




}
