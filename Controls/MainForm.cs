using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace JTPoseCore
{
	public partial class MainForm : Form
	{
		public static bool triggerUpdateSettings = false;

		public MainForm()
		{
			InitializeComponent();

			Config.mainForm = this;

			Utilities.Setup();

			//Height = 700;
			//Width  = 1010;

			BtnImport.Click              += new System.EventHandler(BtnImport_Click);
			BtnReload.Click              += new System.EventHandler(BtnReload_Click);
			BtnSave.Click                += new System.EventHandler(BtnSave_Click);
			BtnSendToGame.Click          += new System.EventHandler(BtnSendToGame_Click);
			BtnShowFullWidth.Click       += new System.EventHandler(BtnShowFullWidth_Click);
			BtnShowGrid.Click            += new System.EventHandler(BtnShowGrid_Click);
			TxtFilter.KeyUp              += new KeyEventHandler(TxtFilter_KeyUp);

			if (Config.AppSettings.AllKeys.Contains("Width") && 
				int.TryParse(Config.AppSettings.Get("Width"), out int Width) && 
				int.TryParse(Config.AppSettings.Get("Height"), out int Height) ) Config.mainForm.Size = new (Width,Height);
			
		}

        private void MenuExit_Click( object sender, EventArgs e )
        {
			Application.Exit();
        }

		private void TimerFileSystem_Tick( object sender, EventArgs e )
		{
			if (triggerUpdateSettings) {

				triggerUpdateSettings = false;
				
			}
			if (Config.PoseImagePath != null)
			{
				string ImageHash = Utilities.GetLastTime(Config.PoseImageFile);
				
				if (ImageHash != Config.LastImageTime)
				{
					Config.LastImageTime = ImageHash;
					EditPose.ResetPoseImage();
				}
			}

			if (Config.PoseDataFile != null)
			{
				
				string DataHash = Utilities.GetLastTime(Config.PoseDataFile);
				
				if (DataHash != Config.LastDataTime)
				{
					if (Config.DoImageSwap)
					{
						if (File.Exists(Config.PoseDataFile)) File.Delete(Config.PoseDataFile);
						return;
					}
					Config.LastDataTime = DataHash;
					EditPose.ResetPoseData();
				}
			}
		}

		private void BtnShowGrid_Click( object sender, EventArgs e )
		{
			Config.PIView            = PoseImageView.GridView;
			BtnShowGrid.Checked      = true;
			BtnShowFullWidth.Checked = false;
			
		}

		private void BtnShowFullWidth_Click( object sender, EventArgs e )
		{
			Config.PIView            = PoseImageView.FullWidth;
			BtnShowFullWidth.Checked = true;
			BtnShowGrid.Checked      = false;
		}


		private void BtnSendToGame_Click( object sender, EventArgs e )
		{
			EditPose.SendPoseToGame();
			Config.mainForm.statusLabel.Text = "Imported to Game: ";
		}

        private void BtnSave_Click( object sender, EventArgs e )
        {
			EditPose.SavePose();
        }

		private void BtnReload_Click( object sender, EventArgs e )
		{
			Config.BPose.Refresh();
		}

		

		private void TxtFilter_KeyUp( object sender, KeyEventArgs e )
		{
			
			Config.BPose.Filter = TxtFilter.Text;
		}

		private void BtnImport_Click( object sender, EventArgs e )
		{
			EditPose.Import(RTB.Text);
		}

		

        private void BtnSettings_Click( object sender, EventArgs e )
        {
			Utilities.ShowSettings();
        }

		private void MainForm_ResizeEnd( object sender, EventArgs e )
		{
			triggerUpdateSettings = true;
		}   
		private void MainForm_LocationChanged( object sender, EventArgs e )
		{
			triggerUpdateSettings = true;
		}

		private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			Utilities.AddUpdateAppSettings("Width", Config.mainForm.Width.ToString());
			Utilities.AddUpdateAppSettings("Height", Config.mainForm.Height.ToString());
			Utilities.AddUpdateAppSettings("X", Config.mainForm.Location.X.ToString());
			Utilities.AddUpdateAppSettings("Y", Config.mainForm.Location.Y.ToString());
		}

		private void statusLabel_Click( object sender, EventArgs e )
		{

		}

		private void BtnSendToGame_Click_1( object sender, EventArgs e )
		{
			EditPose.SendPoseToGame(true);
			Config.mainForm.statusLabel.Text = "Imported to Game: ";
		}

        private void BtnSwapImage_Click_1( object sender, EventArgs e )
        {
			Config.DoImageSwap = !Config.DoImageSwap;

			BtnSwapImage.Checked = Config.DoImageSwap;
        }

		private void BtnDelete_Click( object sender, EventArgs e )
		{
			if ( Config.BPose.SelectedPoses.Count > 0 )
			{
				DialogResult result1 = MessageBox.Show("Delete the " + Config.BPose.SelectedPoses.Count + " selected poses?",
                "Delete",
                MessageBoxButtons.YesNo);

				if (result1 == DialogResult.Yes) Config.BPose.Delete();
			}
		}
	}
}
