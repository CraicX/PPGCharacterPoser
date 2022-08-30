namespace JTPoseDump
{
	partial class MainForm
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.TabCapture = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.RTB = new System.Windows.Forms.RichTextBox();
			this.ImgCurrent = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.FlowPoseSet = new System.Windows.Forms.FlowLayoutPanel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.BtnShowGrid = new System.Windows.Forms.ToolStripButton();
			this.BtnShowFullWidth = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PGrid = new System.Windows.Forms.PropertyGrid();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.BtnNew = new System.Windows.Forms.ToolStripButton();
			this.BtnSave = new System.Windows.Forms.ToolStripButton();
			this.BtnFav = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
			this.BtnSendToGame = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.TabBrowse = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.TimerFileSystem = new System.Windows.Forms.Timer(this.components);
			this.AppIcons = new System.Windows.Forms.ImageList(this.components);
			this.Menu.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.TabCapture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgCurrent)).BeginInit();
			this.panel2.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(991, 24);
			this.Menu.TabIndex = 0;
			this.Menu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// MenuExit
			// 
			this.MenuExit.Name = "MenuExit";
			this.MenuExit.Size = new System.Drawing.Size(93, 22);
			this.MenuExit.Text = "E&xit";
			this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
			// 
			// TabControl
			// 
			this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.TabControl.Controls.Add(this.TabCapture);
			this.TabControl.Controls.Add(this.TabBrowse);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 24);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(991, 502);
			this.TabControl.TabIndex = 1;
			// 
			// TabCapture
			// 
			this.TabCapture.Controls.Add(this.splitContainer1);
			this.TabCapture.Location = new System.Drawing.Point(4, 25);
			this.TabCapture.Name = "TabCapture";
			this.TabCapture.Padding = new System.Windows.Forms.Padding(3);
			this.TabCapture.Size = new System.Drawing.Size(983, 473);
			this.TabCapture.TabIndex = 0;
			this.TabCapture.Text = "Capture";
			this.TabCapture.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.RTB);
			this.splitContainer1.Panel1.Controls.Add(this.ImgCurrent);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(977, 467);
			this.splitContainer1.SplitterDistance = 325;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 0;
			// 
			// RTB
			// 
			this.RTB.BackColor = System.Drawing.Color.DarkGray;
			this.RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RTB.Location = new System.Drawing.Point(0, 323);
			this.RTB.Name = "RTB";
			this.RTB.Size = new System.Drawing.Size(325, 144);
			this.RTB.TabIndex = 2;
			this.RTB.Text = "";
			// 
			// ImgCurrent
			// 
			this.ImgCurrent.BackColor = System.Drawing.Color.Gray;
			this.ImgCurrent.Dock = System.Windows.Forms.DockStyle.Top;
			this.ImgCurrent.Location = new System.Drawing.Point(0, 0);
			this.ImgCurrent.Name = "ImgCurrent";
			this.ImgCurrent.Size = new System.Drawing.Size(325, 323);
			this.ImgCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgCurrent.TabIndex = 3;
			this.ImgCurrent.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.FlowPoseSet);
			this.panel2.Controls.Add(this.toolStrip2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(265, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(386, 442);
			this.panel2.TabIndex = 2;
			// 
			// FlowPoseSet
			// 
			this.FlowPoseSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowPoseSet.Location = new System.Drawing.Point(0, 25);
			this.FlowPoseSet.Name = "FlowPoseSet";
			this.FlowPoseSet.Size = new System.Drawing.Size(386, 417);
			this.FlowPoseSet.TabIndex = 3;
			// 
			// toolStrip2
			// 
			this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnShowGrid,
            this.BtnShowFullWidth});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(386, 25);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// BtnShowGrid
			// 
			this.BtnShowGrid.BackColor = System.Drawing.Color.Silver;
			this.BtnShowGrid.CheckOnClick = true;
			this.BtnShowGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnShowGrid.Image = global::JTPoseDump.Properties.Resources.Grid_Squares;
			this.BtnShowGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnShowGrid.Name = "BtnShowGrid";
			this.BtnShowGrid.Size = new System.Drawing.Size(23, 22);
			this.BtnShowGrid.Text = "toolStripButton4";
			// 
			// BtnShowFullWidth
			// 
			this.BtnShowFullWidth.BackColor = System.Drawing.Color.Silver;
			this.BtnShowFullWidth.Checked = true;
			this.BtnShowFullWidth.CheckOnClick = true;
			this.BtnShowFullWidth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.BtnShowFullWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnShowFullWidth.Image = global::JTPoseDump.Properties.Resources.Mirror_Top;
			this.BtnShowFullWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnShowFullWidth.Name = "BtnShowFullWidth";
			this.BtnShowFullWidth.Size = new System.Drawing.Size(23, 22);
			this.BtnShowFullWidth.Text = "toolStripButton5";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Linen;
			this.panel1.Controls.Add(this.PGrid);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(265, 442);
			this.panel1.TabIndex = 1;
			// 
			// PGrid
			// 
			this.PGrid.CategoryForeColor = System.Drawing.Color.Ivory;
			this.PGrid.CategorySplitterColor = System.Drawing.Color.Gray;
			this.PGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PGrid.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PGrid.LineColor = System.Drawing.Color.DimGray;
			this.PGrid.Location = new System.Drawing.Point(0, 0);
			this.PGrid.Name = "PGrid";
			this.PGrid.Size = new System.Drawing.Size(265, 442);
			this.PGrid.TabIndex = 0;
			this.PGrid.ToolbarVisible = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnSave,
            this.BtnFav,
            this.toolStripSeparator1,
            this.BtnRefresh,
            this.BtnSendToGame,
            this.toolStripSeparator2,
            this.BtnDelete,
            this.toolStripSeparator3,
            this.toolStripButton7});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(651, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// BtnNew
			// 
			this.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnNew.Image = global::JTPoseDump.Properties.Resources.New_File;
			this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.Size = new System.Drawing.Size(23, 22);
			this.BtnNew.Text = "toolStripButton4";
			// 
			// BtnSave
			// 
			this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSave.Image = global::JTPoseDump.Properties.Resources.Save_As;
			this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(23, 22);
			this.BtnSave.Text = "toolStripButton2";
			// 
			// BtnFav
			// 
			this.BtnFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnFav.Image = global::JTPoseDump.Properties.Resources.Star;
			this.BtnFav.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnFav.Name = "BtnFav";
			this.BtnFav.Size = new System.Drawing.Size(23, 22);
			this.BtnFav.Text = "toolStripButton3";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnRefresh.Image = global::JTPoseDump.Properties.Resources.Reload;
			this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(23, 22);
			this.BtnRefresh.Text = "toolStripButton5";
			// 
			// BtnSendToGame
			// 
			this.BtnSendToGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSendToGame.Image = global::JTPoseDump.Properties.Resources.Up_Arrow;
			this.BtnSendToGame.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSendToGame.Name = "BtnSendToGame";
			this.BtnSendToGame.Size = new System.Drawing.Size(23, 22);
			this.BtnSendToGame.Text = "toolStripButton6";
			this.BtnSendToGame.Click += new System.EventHandler(this.BtnSendToGame_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnDelete
			// 
			this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnDelete.Image = global::JTPoseDump.Properties.Resources.Close;
			this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(23, 22);
			this.BtnDelete.Text = "toolStripButton1";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton7.Image = global::JTPoseDump.Properties.Resources.Delete;
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton7.Text = "toolStripButton7";
			// 
			// TabBrowse
			// 
			this.TabBrowse.Location = new System.Drawing.Point(4, 25);
			this.TabBrowse.Name = "TabBrowse";
			this.TabBrowse.Padding = new System.Windows.Forms.Padding(3);
			this.TabBrowse.Size = new System.Drawing.Size(983, 473);
			this.TabBrowse.TabIndex = 1;
			this.TabBrowse.Text = "Browse";
			this.TabBrowse.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 526);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(991, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(39, 17);
			this.statusLabel.Text = "Ready";
			// 
			// TimerFileSystem
			// 
			this.TimerFileSystem.Enabled = true;
			this.TimerFileSystem.Interval = 1000;
			this.TimerFileSystem.Tick += new System.EventHandler(this.TimerFileSystem_Tick);
			// 
			// AppIcons
			// 
			this.AppIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AppIcons.ImageStream")));
			this.AppIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.AppIcons.Images.SetKeyName(0, "Arrow Down.png");
			this.AppIcons.Images.SetKeyName(1, "Arrow Up.png");
			this.AppIcons.Images.SetKeyName(2, "Check.png");
			this.AppIcons.Images.SetKeyName(3, "Clock.png");
			this.AppIcons.Images.SetKeyName(4, "Close.png");
			this.AppIcons.Images.SetKeyName(5, "Crop.png");
			this.AppIcons.Images.SetKeyName(6, "Cut.png");
			this.AppIcons.Images.SetKeyName(7, "Delete.png");
			this.AppIcons.Images.SetKeyName(8, "Double Arrow Left.png");
			this.AppIcons.Images.SetKeyName(9, "Double Arrow Right.png");
			this.AppIcons.Images.SetKeyName(10, "Down Arrow.png");
			this.AppIcons.Images.SetKeyName(11, "Fill Copy.png");
			this.AppIcons.Images.SetKeyName(12, "Filters.png");
			this.AppIcons.Images.SetKeyName(13, "Folder Tight.png");
			this.AppIcons.Images.SetKeyName(14, "Grid Squares.png");
			this.AppIcons.Images.SetKeyName(15, "Ignore.png");
			this.AppIcons.Images.SetKeyName(16, "Image.png");
			this.AppIcons.Images.SetKeyName(17, "Import Display Top.png");
			this.AppIcons.Images.SetKeyName(18, "Like.png");
			this.AppIcons.Images.SetKeyName(19, "Link.png");
			this.AppIcons.Images.SetKeyName(20, "List.png");
			this.AppIcons.Images.SetKeyName(21, "Mirror Top.png");
			this.AppIcons.Images.SetKeyName(22, "Mirror.png");
			this.AppIcons.Images.SetKeyName(23, "Move.png");
			this.AppIcons.Images.SetKeyName(24, "Multiple Images.png");
			this.AppIcons.Images.SetKeyName(25, "New File.png");
			this.AppIcons.Images.SetKeyName(26, "Openn Folder.png");
			this.AppIcons.Images.SetKeyName(27, "Person Check.png");
			this.AppIcons.Images.SetKeyName(28, "Person Group.png");
			this.AppIcons.Images.SetKeyName(29, "Person.png");
			this.AppIcons.Images.SetKeyName(30, "Reload.png");
			this.AppIcons.Images.SetKeyName(31, "Save As.png");
			this.AppIcons.Images.SetKeyName(32, "Scale.png");
			this.AppIcons.Images.SetKeyName(33, "Sent to Display.png");
			this.AppIcons.Images.SetKeyName(34, "Square.png");
			this.AppIcons.Images.SetKeyName(35, "Star.png");
			this.AppIcons.Images.SetKeyName(36, "Switch User.png");
			this.AppIcons.Images.SetKeyName(37, "Up Arrow.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 548);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.Menu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PPG Pose Dump";
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			this.TabControl.ResumeLayout(false);
			this.TabCapture.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ImgCurrent)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        public new System.Windows.Forms.MenuStrip Menu;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuExit;
        public System.Windows.Forms.TabControl TabControl;
        public System.Windows.Forms.TabPage TabCapture;
        public System.Windows.Forms.TabPage TabBrowse;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.Timer TimerFileSystem;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
		public System.Windows.Forms.ImageList AppIcons;
		private System.Windows.Forms.ToolStripButton BtnNew;
		private System.Windows.Forms.ToolStripButton BtnSave;
		private System.Windows.Forms.ToolStripButton BtnFav;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton BtnRefresh;
		private System.Windows.Forms.ToolStripButton BtnSendToGame;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripButton7;
		public System.Windows.Forms.PropertyGrid PGrid;
        public System.Windows.Forms.RichTextBox RTB;
        public System.Windows.Forms.PictureBox ImgCurrent;
        public System.Windows.Forms.FlowLayoutPanel FlowPoseSet;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnShowGrid;
        private System.Windows.Forms.ToolStripButton BtnShowFullWidth;
    }
}

