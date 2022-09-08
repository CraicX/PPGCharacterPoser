using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JTPoseCore
{
	public partial class PoseControl : UserControl
	{
		public PoseObject poseObject;

		public bool DoAuto = false;
		private bool _selected = false;

		private Image ImageZoomIn;
		private Image ImageZoomOut;


		public bool Selected
		{
			get { return _selected; }
			set
			{
				_selected = value;

				if ( value )
				{
					Label.BackColor = Color.Aqua;
					Label.ForeColor = Color.Black;
				} else
				{
					Label.BackColor = Color.Silver;
					Label.ForeColor = Color.Black;
				}
			}
		}

		public string ImagePath => poseObject.ImagePath;
		public string DataPath => poseObject.DataPath;

		public string PoseName {get; set;}


		public PoseControl(PoseObject pose)
		{
			poseObject = pose;
			InitializeComponent();

			if (File.Exists(poseObject.ImagePath)) PicBox.Image = Utilities.LoadImageSafe(poseObject.ImagePath);
			else PicBox.Image = Utilities.LoadImageSafe( Path.Combine(Config.ResourcesPath, "missingpose.png" ) );

            PoseName = Label.Text   = poseObject.PoseName;

			ImageZoomOut = Utilities.CropImage(PicBox.Image, 75);
			ImageZoomIn  = Utilities.CropImage(PicBox.Image, 125);

			PicBox.Image = ImageZoomOut;

			if (Config.BPose.SelectedPoses.Contains(PoseName)) Selected = true;

			PicBox.DoubleClick += new System.EventHandler(this.PicBox_DoubleClick);
		}

		private void PicBox_DoubleClick( object sender, EventArgs e )
		{
			//
			if (Config.DoAutoSwap) {
				poseObject.PoseClass.DoAuto = DoAuto = true;
				Console.WriteLine("DOUBLE CLICKED");
				EditPose.CurrentPose.DoAuto = true;
				EditPose.Edit(poseObject, true);
				EditPose.CurrentPose.DoAuto = true;
			}
		}

		private void PicBox_Click( object sender, EventArgs e )
		{
			DoAuto = poseObject.PoseClass.DoAuto = false;
			if (Control.ModifierKeys == Keys.Control ) { 
				
				Selected = !_selected;
				Config.BPose.Select(this);

			}  else if (Control.ModifierKeys == Keys.Shift ) { 
				
				Selected = !_selected;
				Config.BPose.Select(this, true);

			} else
			{
				EditPose.Edit(poseObject);
			}
			
		}


		private void Label_MouseEnter( object sender, EventArgs e )
		{
            Label.BackColor = Color.PeachPuff;
            Label.ForeColor = Color.Black;
			PicBox.Image    = ImageZoomIn;

		}

		private void Label_MouseLeave( object sender, EventArgs e )
		{
            Label.BackColor = Selected ? Color.Aqua : Color.Silver;
            Label.ForeColor = Color.Black;
			PicBox.Image    = ImageZoomOut;
		}

        public PictureBox PicBox;
        public Label Label;

		private void PicBox_DoubleClick_1( object sender, EventArgs e )
		{

			if (Config.DoAutoSwap) {
				poseObject.PoseClass.DoAuto = DoAuto = true;
				Console.WriteLine("DOUBLE CLICKED");
				EditPose.CurrentPose.DoAuto = true;
				EditPose.Edit(poseObject, true);
				EditPose.CurrentPose.DoAuto = true;
			}
		}
	
			

	}
}