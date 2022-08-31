namespace JTPoseDump
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
			this.Label = new System.Windows.Forms.Label();
			this.PicBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// Label
			// 
			this.Label.BackColor = System.Drawing.Color.Silver;
			this.Label.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Label.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label.ForeColor = System.Drawing.Color.Black;
			this.Label.Location = new System.Drawing.Point(0, 146);
			this.Label.MaximumSize = new System.Drawing.Size(0, 24);
			this.Label.MinimumSize = new System.Drawing.Size(0, 24);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(146, 24);
			this.Label.TabIndex = 1;
			this.Label.Text = "Name";
			this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
			this.Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
			// 
			// PicBox
			// 
			this.PicBox.BackColor = System.Drawing.Color.LightGray;
			this.PicBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PicBox.Location = new System.Drawing.Point(0, 0);
			this.PicBox.Name = "PicBox";
			this.PicBox.Size = new System.Drawing.Size(146, 146);
			this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicBox.TabIndex = 0;
			this.PicBox.TabStop = false;
			this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
			this.PicBox.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
			this.PicBox.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
			// 
			// PoseControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.PicBox);
			this.Controls.Add(this.Label);
			this.Name = "PoseControl";
			this.Size = new System.Drawing.Size(146, 170);
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        public System.Windows.Forms.PictureBox PicBox;
        public System.Windows.Forms.Label Label;
    }
}
