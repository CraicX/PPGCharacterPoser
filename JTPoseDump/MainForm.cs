using System;
using System.Windows.Forms;
using System.IO;

namespace JTPoseDump
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Config.mainForm = this;

			Utilities.Setup();

			Height = 700;
			Width  = 1010;

			BtnImport.Click              += new System.EventHandler(BtnImport_Click);
			BtnReload.Click              += new System.EventHandler(BtnReload_Click);
			BtnSave.Click                += new System.EventHandler(BtnSave_Click);
			BtnSendToGame.Click          += new System.EventHandler(BtnSendToGame_Click);
			BtnShowFullWidth.Click       += new System.EventHandler(BtnShowFullWidth_Click);
			BtnShowGrid.Click            += new System.EventHandler(BtnShowGrid_Click);
			BtnSwapImage.Click           += new System.EventHandler(BtnSwapImage_Click);
			TxtFilter.KeyUp              += new KeyEventHandler(TxtFilter_KeyUp);
			
		}

        private void MenuExit_Click( object sender, EventArgs e )
        {
			Application.Exit();
        }

		private void TimerFileSystem_Tick( object sender, EventArgs e )
		{
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

		private void BtnSwapImage_Click( object sender, EventArgs e )
		{
			Config.DoImageSwap = !Config.DoImageSwap;

			BtnSwapImage.Checked = Config.DoImageSwap;
		}

		
	}
}
