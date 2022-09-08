namespace JTPoseCore
{
	partial class Settings
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnUninstall = new System.Windows.Forms.Button();
			this.BtnInstall = new System.Windows.Forms.Button();
			this.BtnBrowse = new System.Windows.Forms.Button();
			this.TBGamePath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BtnSave = new System.Windows.Forms.Button();
			this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(438, 90);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label2.Location = new System.Drawing.Point(70, 54);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Change settings";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Location = new System.Drawing.Point(13, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Preferences";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(63, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(375, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightGray;
			this.groupBox1.Controls.Add(this.BtnUninstall);
			this.groupBox1.Controls.Add(this.BtnInstall);
			this.groupBox1.Controls.Add(this.BtnBrowse);
			this.groupBox1.Controls.Add(this.TBGamePath);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(14, 121);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(410, 157);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Settings";
			// 
			// BtnUninstall
			// 
			this.BtnUninstall.BackColor = System.Drawing.Color.MistyRose;
			this.BtnUninstall.Enabled = false;
			this.BtnUninstall.Location = new System.Drawing.Point(142, 96);
			this.BtnUninstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnUninstall.Name = "BtnUninstall";
			this.BtnUninstall.Size = new System.Drawing.Size(110, 29);
			this.BtnUninstall.TabIndex = 4;
			this.BtnUninstall.Text = "Uninstall Mod";
			this.BtnUninstall.UseVisualStyleBackColor = false;
			this.BtnUninstall.Click += new System.EventHandler(this.BtnUninstall_Click);
			// 
			// BtnInstall
			// 
			this.BtnInstall.BackColor = System.Drawing.Color.LightCyan;
			this.BtnInstall.Enabled = false;
			this.BtnInstall.Location = new System.Drawing.Point(26, 96);
			this.BtnInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnInstall.Name = "BtnInstall";
			this.BtnInstall.Size = new System.Drawing.Size(110, 29);
			this.BtnInstall.TabIndex = 3;
			this.BtnInstall.Text = "Install Mod";
			this.BtnInstall.UseVisualStyleBackColor = false;
			this.BtnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
			// 
			// BtnBrowse
			// 
			this.BtnBrowse.Location = new System.Drawing.Point(304, 51);
			this.BtnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnBrowse.Name = "BtnBrowse";
			this.BtnBrowse.Size = new System.Drawing.Size(92, 25);
			this.BtnBrowse.TabIndex = 2;
			this.BtnBrowse.Text = "Browse";
			this.BtnBrowse.UseVisualStyleBackColor = true;
			this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// TBGamePath
			// 
			this.TBGamePath.BackColor = System.Drawing.Color.WhiteSmoke;
			this.TBGamePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TBGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TBGamePath.Location = new System.Drawing.Point(26, 52);
			this.TBGamePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.TBGamePath.Name = "TBGamePath";
			this.TBGamePath.Size = new System.Drawing.Size(272, 21);
			this.TBGamePath.TabIndex = 1;
			this.TBGamePath.WordWrap = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 33);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "People Playground Game Location:";
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(332, 286);
			this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(92, 30);
			this.BtnSave.TabIndex = 2;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(438, 328);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.Settings_Activated);
			this.Load += new System.EventHandler(this.Settings_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TBGamePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button BtnUninstall;
        private System.Windows.Forms.Button BtnInstall;
    }
}