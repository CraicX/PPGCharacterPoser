using System;
using System.Windows.Forms;

namespace JTPoseDump
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Config.mainForm = this;

			Utilities.Setup();
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
			Config.BPose.RefreshPoses();
		}

		private void BtnShowGrid_Click_1( object sender, EventArgs e )
		{
			BtnShowFullWidth.Checked = false;
			Config.PIView = PoseImageView.GridView;
		}

		private void BtnShowFullWidth_Click_1( object sender, EventArgs e )
		{
			BtnShowGrid.Checked = false;
			Config.PIView = PoseImageView.FullWidth;
		}

		private void TxtFilter_KeyUp( object sender, KeyEventArgs e )
		{
			
			Config.BPose.Filter = TxtFilter.Text;
		}

		private void BtnImport_Click( object sender, EventArgs e )
		{
			EditPose.Import(RTB.Text);
		}
	}
}
