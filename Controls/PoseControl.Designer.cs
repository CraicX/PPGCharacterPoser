namespace JTPoseCore
{
	partial class PoseControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PicBox = new System.Windows.Forms.PictureBox();
			this.Label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// PicBox
			// 
			this.PicBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PicBox.Location = new System.Drawing.Point(0, 0);
			this.PicBox.Name = "PicBox";
			this.PicBox.Size = new System.Drawing.Size(150, 150);
			this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicBox.TabIndex = 0;
			this.PicBox.TabStop = false;
			this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
			this.PicBox.DoubleClick += new System.EventHandler(this.PicBox_DoubleClick_1);
			// 
			// Label
			// 
			this.Label.BackColor = System.Drawing.Color.Silver;
			this.Label.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label.Location = new System.Drawing.Point(0, 128);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(150, 22);
			this.Label.TabIndex = 2;
			this.Label.Text = "label1";
			this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PoseControl
			// 
			this.Controls.Add(this.Label);
			this.Controls.Add(this.PicBox);
			this.Name = "PoseControl";
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

    }
}
