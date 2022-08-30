using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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

		static public Image LoadImage(string imgPath)
        {
            if (File.Exists(imgPath))
            {

                Bitmap bmpTemp = new Bitmap(imgPath);
                Bitmap MyImage = new Bitmap(bmpTemp);

                return MyImage;
            }

            return new System.Drawing.Bitmap(48, 48);
        }

		static public Bitmap LoadImageSafe(String path)
		{
			using (Bitmap sourceImage = new Bitmap(path))
			{
				return CloneImage(sourceImage);
			}
		}

		public static Bitmap CloneImage(Bitmap sourceImage)
		{
			Rectangle rect = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
			Bitmap targetImage = new Bitmap(rect.Width, rect.Height, sourceImage.PixelFormat);
			targetImage.SetResolution(sourceImage.HorizontalResolution, sourceImage.VerticalResolution);
			BitmapData sourceData = sourceImage.LockBits(rect, ImageLockMode.ReadOnly, sourceImage.PixelFormat);
			BitmapData targetData = targetImage.LockBits(rect, ImageLockMode.WriteOnly, targetImage.PixelFormat);
			Int32 actualDataWidth = ((Image.GetPixelFormatSize(sourceImage.PixelFormat) * rect.Width) + 7) / 8;
			Int32 h = sourceImage.Height;
			Int32 origStride = sourceData.Stride;
			Boolean isFlipped = origStride < 0;
			origStride = Math.Abs(origStride); // Fix for negative stride in BMP format.
			Int32 targetStride = targetData.Stride;
			Byte[] imageData = new Byte[actualDataWidth];
			IntPtr sourcePos = sourceData.Scan0;
			IntPtr destPos = targetData.Scan0;
			// Copy line by line, skipping by stride but copying actual data width
			for (Int32 y = 0; y < h; y++)
			{
				Marshal.Copy(sourcePos, imageData, 0, actualDataWidth);
				Marshal.Copy(imageData, 0, destPos, actualDataWidth);
				sourcePos = new IntPtr(sourcePos.ToInt64() + origStride);
				destPos = new IntPtr(destPos.ToInt64() + targetStride);
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

	}




}
