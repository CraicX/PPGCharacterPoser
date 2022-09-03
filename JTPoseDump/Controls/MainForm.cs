using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace JTPoseDump
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Config.mainForm = this;

			Utilities.Setup();

			Height = 660;
			Width  = 1010;

			BtnImport.Click              += new System.EventHandler(BtnImport_Click);
			BtnReload.Click              += new System.EventHandler(BtnReload_Click);
			BtnSave.Click                += new System.EventHandler(BtnSave_Click);
			BtnSendToGame.Click          += new System.EventHandler(BtnSendToGame_Click);
			BtnShowFullWidth.Click       += new System.EventHandler(BtnShowFullWidth_Click);
			BtnShowGrid.Click            += new System.EventHandler(BtnShowGrid_Click);
			BtnAutoSwap.Click            += new System.EventHandler(BtnSwapImage_Click);
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
			Config.PIView              = PoseImageView.GridView;
			BtnShowGrid.BackColor      = Color.Silver;
			BtnShowFullWidth.BackColor = Color.DarkGray;
		}

		private void BtnShowFullWidth_Click( object sender, EventArgs e )
		{
			Config.PIView              = PoseImageView.FullWidth;
			BtnShowGrid.BackColor      = Color.DarkGray;
			BtnShowFullWidth.BackColor = Color.Silver;
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

		private void BtnSwap_Click( object sender, EventArgs e )
		{
			Config.DoImageSwap   = !Config.DoImageSwap;
			BtnSwap.Checked      = Config.DoImageSwap;
		}

		private void BtnAutoSwap_Click( object sender, EventArgs e )
		{
			Config.DoAutoSwap   = !Config.DoAutoSwap;
			BtnAutoSwap.Checked = Config.DoAutoSwap;
		}

		private void BtnSettings_Click( object sender, EventArgs e )
		{
			Utilities.ShowSettings();
		}

        private void BtnNew_Click( object sender, EventArgs e )
        {
			string ImageFile = Path.Combine(Config.ImagePath, "currentpose.png");
			string DataFile  = Path.Combine(Config.DataPath, "current.json");
			if (File.Exists(ImageFile)) File.Delete(DataFile);
			if (File.Exists(DataFile))  File.Delete(ImageFile);

			EditPose.ResetPoseData();
        }
    }
}
