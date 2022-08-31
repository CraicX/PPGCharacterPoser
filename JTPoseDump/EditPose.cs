﻿using System;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Collections.Generic;
using Xamarin.Forms.Internals;

namespace JTPoseDump
{
	public static class EditPose
	{
		public static PoseClass CurrentPose  = new PoseClass();
		public static string WipImagePath    = Path.Combine(Config.ImagePath, "currentpose.png");
		public static string WipDataPath     = Path.Combine(Config.DataPath, "current.json");

		public static void Edit( PoseObject poseObject )
		{
			CurrentPose = poseObject.PoseClass;

			if (File.Exists(WipDataPath))  File.Delete(WipDataPath);
			if (File.Exists(WipImagePath)) File.Delete(WipImagePath);

			if (File.Exists(poseObject.ImagePath)) File.Copy(poseObject.ImagePath, WipImagePath);
			File.Copy(poseObject.DataPath, WipDataPath);

			SetCurrentData();
			SetCurrentPose();

		}


		public static void ResetPoseImage()
		{
			if (!File.Exists(Config.PoseImageFile)) return;

			if (File.Exists(WipImagePath)) File.Delete(WipImagePath);

			File.Move(Config.PoseImageFile, WipImagePath);

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

		public static void SavePose( PoseClass posec=null, bool DoRefresh=true )
		{
			bool useImage = true;
			if (posec == null) posec = CurrentPose;
			else useImage = false;
			if (posec.Name == "")
			{
				// MessageBox.Show("Name the pose!");
				return;
			}


			string poseFile = Path.Combine( Config.DataPath, posec.Name + ".json" );
			string imgFile  = Path.Combine( Config.ImagePath, posec.Name + ".png" );

			JsonSerializerOptions options = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			string jsonString = JsonSerializer.Serialize<PoseClass>(posec, options);

			File.WriteAllText(poseFile, jsonString);

			if ( useImage && File.Exists( WipImagePath ) )
			{
				System.Drawing.Image tmpImage = Utilities.LoadImageSafe(WipImagePath);

				tmpImage.Save(imgFile, ImageFormat.Png);
			}

			if (DoRefresh) { 
				Config.mainForm.statusLabel.Text = "Saved Pose: " + poseFile;

				Task ignoredAwaitableResult = delayedWork();

				Config.BPose.RefreshPoses();
			}
		}


		public static void SendPoseToGame()
		{
			string poseFile = Path.Combine(Config.PoseDataPath, "export.json");

			JsonSerializerOptions options = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			string jsonString = JsonSerializer.Serialize<PoseClass>(CurrentPose, options);

			File.WriteAllText(poseFile, jsonString);

			Config.mainForm.statusLabel.Text = "Imported to Game: " + poseFile;

			Task ignoredAwaitableResult = delayedWork();
		}

		public static void ResetPoseData()
		{
			if (!File.Exists(Config.PoseDataFile)) return;

			DateTime dt = DateTime.Now;

			string dataName = dt.ToString("Pose_YYMMdd_HHmmss");

			if (File.Exists(WipDataPath)) File.Delete(WipDataPath);

			File.Move(Config.PoseDataFile, WipDataPath);

			Task ignoredAwaitableResult = delayedWork();

			SetCurrentData();
		}

		private static async Task delayedWork()
		{
			await Task.Delay(5000);

			Config.mainForm.statusLabel.Text = "Ready";
		}

		private static void StartAsyncTimedWork()
		{
			Task ignoredAwaitableResult = delayedWork();
		}

		public static void SetCurrentData()
		{
			if (!File.Exists( WipDataPath ) ) return;

			string pdata = File.ReadAllText(WipDataPath).Trim();

			CurrentPose = JsonSerializer.Deserialize<PoseClass>(pdata);

			Config.mainForm.PGrid.SelectedObject = CurrentPose;
		}

		public static void ConvertData()
		{
			if (!File.Exists( WipDataPath ) ) return;

			string pdata = File.ReadAllText(WipDataPath).Trim();

			string[] Lines = pdata.Split(',');

			CurrentPose = new PoseClass();
			Type type   = CurrentPose.GetType();

			foreach ( string line in Lines ) 
			{
				string[] parts = line.Split(':');

				if (parts.Length < 2) continue;

				string limbName   = parts[0].Trim();
				string limbAngle  = parts[1].Trim();

				PropertyInfo prop = type.GetProperty(limbName);

				prop.SetValue (CurrentPose, float.Parse(limbAngle), null);
			}

			Config.mainForm.PGrid.SelectedObject = CurrentPose;


		}

		public static void SetCurrentPose()
		{
			if ( File.Exists( WipImagePath ) ) 
			{
				
				System.Drawing.Image tmpImage = Utilities.LoadImageSafe(WipImagePath);

				Config.mainForm.ImgCurrent.Image = Utilities.CropImage(tmpImage, 75);

			} else
			{

				Config.mainForm.ImgCurrent.Image = Config.MissingImage;
			}
		}

		public static void Import( string importString )
		{
			string p = "\"([^\"]+)\"";

			Regex rxName = new Regex(p, RegexOptions.Compiled);

			p = "\\w[^,\"]+";

			Regex rxLimbs = new Regex(p, RegexOptions.Compiled);

			string pattern = "{.*?}";  

			Regex rx = new Regex(pattern, RegexOptions.Singleline);

			MatchCollection matches = rx.Matches(importString);
			
			foreach ( Match m in matches )
			{
				PoseClass PC = new PoseClass();
				Type type    = PC.GetType();

				List<LimbAngle> limbAngles = new List<LimbAngle>();

				foreach(string line in m.Value.SplitToLines()) 
				{
					string x = line.Trim();

					//Console.WriteLine(x);

					Match nm = rxName.Match(x);

					if (nm.Success)
					{
						PC.Name = nm.Groups[1].Value;
					} 
					else
					{
						Match pa = rxLimbs.Match(x);

						if ( pa.Success )
						{
							LimbAngle limb    = new LimbAngle(pa.Value);
							
							PropertyInfo prop = type.GetProperty(limb.Name);

							prop.SetValue (PC, limb.Angle, null);

						}
					}
				}

				SavePose( PC, false );
				
			}
			

			Config.BPose.RefreshPoses();


		}
	}
}
