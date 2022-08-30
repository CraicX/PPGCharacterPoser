using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		private void ListLimbs_SelectedIndexChanged( object sender, EventArgs e )
		{

		}

		private void BtnSendToGame_Click( object sender, EventArgs e )
		{
			EditPose.SendPoseToGame();
		}
	}
}
