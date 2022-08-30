using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;

namespace JTPoseDump
{
	public static class EditPose
	{
		public static PoseClass CurrentPose = new PoseClass();

		public static void ResetPoseImage()
		{
			if (!File.Exists(Config.PoseImageFile)) return;

			string ImgDest = Path.Combine(Config.ImagePath, "currentpose.png");

			Config.mainForm.statusLabel.Text = "Moved " + Config.PoseImageFile + " to " + ImgDest;

			if (File.Exists(ImgDest))
			{
				File.Delete(ImgDest);
			}

			File.Move(Config.PoseImageFile, ImgDest);

			Task ignoredAwaitableResult = delayedWork();

			if (Config.mainForm.FlowPoseSet.Controls.Count > 0 )
			{
				for(int i = Config.mainForm.FlowPoseSet.Controls.Count; --i >= 0;)
				{
					Config.mainForm.FlowPoseSet.Controls[i].Dispose();
				}
				
			}
			SetCurrentPose();
		}


		public static void SendPoseToGame()
		{
			string poseFile = Path.Combine(Config.PoseDataPath, "export.txt");
			string poseOut  = "";

			JsonSerializerOptions options = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			string jsonString = JsonSerializer.Serialize<PoseClass>(CurrentPose, options);

			File.WriteAllText(poseFile + ".json", jsonString);

			foreach ( string limbName in Config.LimbNames )
			{
				//Type type         = CurrentPose.GetType();
				//PropertyInfo prop = type.GetProperty(limbName);

				float fval = Utilities.GetPropValue<float>(CurrentPose, limbName);
				if (fval != 0f) poseOut += limbName + ":" + fval + ",\n";

			}

			File.WriteAllText(poseFile, poseOut);

			Config.mainForm.statusLabel.Text = "Saved Pose: " + poseFile;

			Task ignoredAwaitableResult = delayedWork();
		}

		public static void ResetPoseData()
		{
			if (!File.Exists(Config.PoseDataFile)) return;

			DateTime dt = DateTime.Now;

			string dataName = dt.ToString("Pose_YYMMdd_HHmmss");
			

			string PoseDest = Path.Combine(Config.DataPath, "current.json");

			Config.mainForm.statusLabel.Text = "Moved " + Config.PoseDataFile + " to " + PoseDest;

			if (File.Exists(PoseDest))
			{
				File.Delete(PoseDest);
			}

			File.Move(Config.PoseDataFile, PoseDest);

			Task ignoredAwaitableResult = delayedWork();

			SetCurrentData();
		}

		private static async Task delayedWork()
		{
			await Task.Delay(5000);

			Config.mainForm.statusLabel.Text = "Ready";
		}

		//This could be a button click event handler or the like */
		private static void StartAsyncTimedWork()
		{
			Task ignoredAwaitableResult = delayedWork();
		}


		public static void SetCurrentData()
		{
			string PoseDest = Path.Combine(Config.DataPath, "current.json");

			if (!File.Exists( PoseDest ) ) return;

			string pdata = File.ReadAllText(PoseDest).Trim();

			string[] Lines = pdata.Split(',');

			CurrentPose = new PoseClass();

			foreach ( string line in Lines ) 
			{
				string[] parts = line.Split(':');

				if (parts.Length < 2) continue;

				string limbName   = parts[0].Trim();
				string limbAngle  = parts[1].Trim();

				Type type = CurrentPose.GetType();

				PropertyInfo prop = type.GetProperty(limbName);

				prop.SetValue (CurrentPose, float.Parse(limbAngle), null);
			}

			Config.mainForm.PGrid.SelectedObject = CurrentPose;


		}

		public static void SetCurrentPose()
		{
			string ImgDest = Path.Combine(Config.ImagePath, "currentpose.png");

			if ( File.Exists( ImgDest ) ) 
			{
				int flowwidth = Config.mainForm.FlowPoseSet.Width;
				int width;
				if (Config.PIView == PoseImageView.FullWidth) width = flowwidth;
				else
				{
					if (flowwidth < 150) width = flowwidth;
					else width = (int) flowwidth / (flowwidth / 100);
				}
				
				System.Drawing.Image tmpImage = Utilities.LoadImageSafe(ImgDest);

				Config.mainForm.ImgCurrent.Image = Utilities.CropImage(tmpImage, 75);

			}
		}




		public static void ResizePoseImages()
		{
			foreach ( PictureBox picture in Config.mainForm.FlowPoseSet.Controls )
			{
				if (Config.PIView == PoseImageView.FullWidth)
				{
					picture.Width  = Config.mainForm.FlowPoseSet.Width;
					picture.Height = picture.Width;
				}
				else
				{
					int flowwidth = Config.mainForm.FlowPoseSet.Width;

					if (flowwidth < 300)
					{
						picture.Width  = flowwidth;
						picture.Height = picture.Width;
					}
					else
					{
						picture.Width  = flowwidth / 2;
						picture.Height = picture.Width;
					}
				}

			}
		}

	}
}
