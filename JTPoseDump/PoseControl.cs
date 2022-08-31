using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace JTPoseDump
{
	public partial class PoseControl : UserControl
	{
		public PoseObject poseObject;

		private Image ImageZoomIn;
		private Image ImageZoomOut;

		
		public PoseControl(PoseObject pose)
		{
			poseObject = pose;
			InitializeComponent();

			if (File.Exists(poseObject.ImagePath)) PicBox.Image = Utilities.LoadImageSafe(poseObject.ImagePath);
			else PicBox.Image = Utilities.LoadImageSafe( Path.Combine(Config.ResourcesPath, "missingpose.png" ) );

			Label.Text   = poseObject.PoseName;

			ImageZoomOut = Utilities.CropImage(PicBox.Image, 75);
			ImageZoomIn  = Utilities.CropImage(PicBox.Image, 125);

			PicBox.Image = ImageZoomOut;
		}

		private void PicBox_Click( object sender, EventArgs e )
		{
			EditPose.Edit(poseObject);
		}


		private void Label_MouseEnter( object sender, EventArgs e )
		{
			Label.BackColor = Color.PeachPuff;
			Label.ForeColor = Color.Black;
			PicBox.Image    = ImageZoomIn;

		}

		private void Label_MouseLeave( object sender, EventArgs e )
		{
			Label.BackColor = Color.Silver;
			Label.ForeColor = Color.Black;
			PicBox.Image    = ImageZoomOut;
		}

		
	}
}
