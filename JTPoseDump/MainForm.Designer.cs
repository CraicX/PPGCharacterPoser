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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.TimerFileSystem = new System.Windows.Forms.Timer(this.components);
			this.AppIcons = new System.Windows.Forms.ImageList(this.components);
			this.AAA = new System.Windows.Forms.Panel();
			this.ARight = new System.Windows.Forms.Panel();
			this.FlowPoseSet = new System.Windows.Forms.FlowLayoutPanel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.BtnShowGrid = new System.Windows.Forms.ToolStripButton();
			this.BtnShowFullWidth = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnReload = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnFavorite = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnDelete = new System.Windows.Forms.ToolStripButton();
			this.TxtFilter = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.LblPoseCount = new System.Windows.Forms.ToolStripLabel();
			this.lblSelected = new System.Windows.Forms.ToolStripLabel();
			this.AMid = new System.Windows.Forms.Panel();
			this.PGrid = new System.Windows.Forms.PropertyGrid();
			this.ALeft = new System.Windows.Forms.Panel();
			this.RTB = new System.Windows.Forms.RichTextBox();
			this.ImgCurrent = new System.Windows.Forms.PictureBox();
			this.LblPoseName = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.BtnNew = new System.Windows.Forms.ToolStripButton();
			this.BtnSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnImport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnSendToGame = new System.Windows.Forms.ToolStripButton();
			this.BtnSwapImage = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1.SuspendLayout();
			this.AAA.SuspendLayout();
			this.ARight.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.AMid.SuspendLayout();
			this.ALeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgCurrent)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
			this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 441);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip1.Size = new System.Drawing.Size(972, 22);
			this.statusStrip1.TabIndex = 2;
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
			// AAA
			// 
			this.AAA.Controls.Add(this.ARight);
			this.AAA.Controls.Add(this.AMid);
			this.AAA.Controls.Add(this.ALeft);
			this.AAA.Controls.Add(this.toolStrip1);
			this.AAA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AAA.Location = new System.Drawing.Point(0, 0);
			this.AAA.Margin = new System.Windows.Forms.Padding(0);
			this.AAA.Name = "AAA";
			this.AAA.Size = new System.Drawing.Size(972, 441);
			this.AAA.TabIndex = 3;
			// 
			// ARight
			// 
			this.ARight.Controls.Add(this.FlowPoseSet);
			this.ARight.Controls.Add(this.toolStrip2);
			this.ARight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ARight.Location = new System.Drawing.Point(562, 25);
			this.ARight.Margin = new System.Windows.Forms.Padding(0);
			this.ARight.Name = "ARight";
			this.ARight.Size = new System.Drawing.Size(410, 416);
			this.ARight.TabIndex = 2;
			// 
			// FlowPoseSet
			// 
			this.FlowPoseSet.AutoScroll = true;
			this.FlowPoseSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FlowPoseSet.BackColor = System.Drawing.Color.DarkGray;
			this.FlowPoseSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowPoseSet.Location = new System.Drawing.Point(0, 25);
			this.FlowPoseSet.Margin = new System.Windows.Forms.Padding(0);
			this.FlowPoseSet.Name = "FlowPoseSet";
			this.FlowPoseSet.Padding = new System.Windows.Forms.Padding(5);
			this.FlowPoseSet.Size = new System.Drawing.Size(410, 391);
			this.FlowPoseSet.TabIndex = 5;
			// 
			// toolStrip2
			// 
			this.toolStrip2.BackColor = System.Drawing.Color.Silver;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnShowGrid,
            this.BtnShowFullWidth,
            this.toolStripSeparator4,
            this.BtnReload,
            this.toolStripSeparator5,
            this.BtnFavorite,
            this.toolStripSeparator6,
            this.BtnDelete,
            this.TxtFilter,
            this.toolStripSeparator3,
            this.LblPoseCount,
            this.lblSelected});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(410, 25);
			this.toolStrip2.TabIndex = 4;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// BtnShowGrid
			// 
			this.BtnShowGrid.BackColor = System.Drawing.Color.Silver;
			this.BtnShowGrid.Checked = true;
			this.BtnShowGrid.CheckOnClick = true;
			this.BtnShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
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
			this.BtnShowFullWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnShowFullWidth.Image = global::JTPoseDump.Properties.Resources.Mirror_Top;
			this.BtnShowFullWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnShowFullWidth.Margin = new System.Windows.Forms.Padding(0);
			this.BtnShowFullWidth.Name = "BtnShowFullWidth";
			this.BtnShowFullWidth.Size = new System.Drawing.Size(23, 25);
			this.BtnShowFullWidth.ToolTipText = "Full Width";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnReload
			// 
			this.BtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnReload.Image = global::JTPoseDump.Properties.Resources.Reload;
			this.BtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnReload.Margin = new System.Windows.Forms.Padding(0);
			this.BtnReload.Name = "BtnReload";
			this.BtnReload.Size = new System.Drawing.Size(23, 25);
			this.BtnReload.Text = "toolStripButton1";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnFavorite
			// 
			this.BtnFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnFavorite.Image = global::JTPoseDump.Properties.Resources.Star;
			this.BtnFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnFavorite.Name = "BtnFavorite";
			this.BtnFavorite.Size = new System.Drawing.Size(23, 22);
			this.BtnFavorite.Text = "toolStripButton2";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
			// TxtFilter
			// 
			this.TxtFilter.AutoSize = false;
			this.TxtFilter.BackColor = System.Drawing.Color.LightGray;
			this.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtFilter.CausesValidation = false;
			this.TxtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TxtFilter.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
			this.TxtFilter.Name = "TxtFilter";
			this.TxtFilter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.TxtFilter.Size = new System.Drawing.Size(100, 23);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// LblPoseCount
			// 
			this.LblPoseCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.LblPoseCount.Name = "LblPoseCount";
			this.LblPoseCount.Size = new System.Drawing.Size(49, 22);
			this.LblPoseCount.Text = "Poses: 0";
			// 
			// lblSelected
			// 
			this.lblSelected.AutoToolTip = true;
			this.lblSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.lblSelected.ForeColor = System.Drawing.Color.MediumBlue;
			this.lblSelected.Name = "lblSelected";
			this.lblSelected.Size = new System.Drawing.Size(0, 22);
			this.lblSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			// 
			// AMid
			// 
			this.AMid.Controls.Add(this.PGrid);
			this.AMid.Dock = System.Windows.Forms.DockStyle.Left;
			this.AMid.Location = new System.Drawing.Point(321, 25);
			this.AMid.Margin = new System.Windows.Forms.Padding(0);
			this.AMid.Name = "AMid";
			this.AMid.Size = new System.Drawing.Size(241, 416);
			this.AMid.TabIndex = 1;
			// 
			// PGrid
			// 
			this.PGrid.BackColor = System.Drawing.Color.Gray;
			this.PGrid.CategoryForeColor = System.Drawing.Color.Chartreuse;
			this.PGrid.CategorySplitterColor = System.Drawing.Color.Gray;
			this.PGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PGrid.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PGrid.HelpBackColor = System.Drawing.Color.Gray;
			this.PGrid.LineColor = System.Drawing.Color.DimGray;
			this.PGrid.Location = new System.Drawing.Point(0, 0);
			this.PGrid.Margin = new System.Windows.Forms.Padding(0);
			this.PGrid.Name = "PGrid";
			this.PGrid.Size = new System.Drawing.Size(241, 416);
			this.PGrid.TabIndex = 1;
			this.PGrid.ToolbarVisible = false;
			this.PGrid.ViewBackColor = System.Drawing.Color.Silver;
			// 
			// ALeft
			// 
			this.ALeft.Controls.Add(this.RTB);
			this.ALeft.Controls.Add(this.ImgCurrent);
			this.ALeft.Controls.Add(this.LblPoseName);
			this.ALeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.ALeft.Location = new System.Drawing.Point(0, 25);
			this.ALeft.Margin = new System.Windows.Forms.Padding(0);
			this.ALeft.Name = "ALeft";
			this.ALeft.Size = new System.Drawing.Size(321, 416);
			this.ALeft.TabIndex = 0;
			// 
			// RTB
			// 
			this.RTB.BackColor = System.Drawing.Color.DarkGray;
			this.RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RTB.Location = new System.Drawing.Point(0, 344);
			this.RTB.Margin = new System.Windows.Forms.Padding(0);
			this.RTB.Name = "RTB";
			this.RTB.Size = new System.Drawing.Size(321, 72);
			this.RTB.TabIndex = 5;
			this.RTB.Text = "";
			// 
			// ImgCurrent
			// 
			this.ImgCurrent.BackColor = System.Drawing.Color.Gray;
			this.ImgCurrent.Dock = System.Windows.Forms.DockStyle.Top;
			this.ImgCurrent.Location = new System.Drawing.Point(0, 23);
			this.ImgCurrent.Margin = new System.Windows.Forms.Padding(0);
			this.ImgCurrent.Name = "ImgCurrent";
			this.ImgCurrent.Size = new System.Drawing.Size(321, 321);
			this.ImgCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgCurrent.TabIndex = 6;
			this.ImgCurrent.TabStop = false;
			// 
			// LblPoseName
			// 
			this.LblPoseName.BackColor = System.Drawing.Color.LightGray;
			this.LblPoseName.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblPoseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LblPoseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.LblPoseName.Location = new System.Drawing.Point(0, 0);
			this.LblPoseName.Margin = new System.Windows.Forms.Padding(0);
			this.LblPoseName.Name = "LblPoseName";
			this.LblPoseName.Size = new System.Drawing.Size(321, 23);
			this.LblPoseName.TabIndex = 7;
			this.LblPoseName.Text = "PoseName";
			this.LblPoseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Silver;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnSave,
            this.toolStripSeparator1,
            this.BtnImport,
            this.toolStripSeparator2,
            this.BtnSendToGame,
            this.BtnSwapImage});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(972, 25);
			this.toolStrip1.TabIndex = 4;
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnImport
			// 
			this.BtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnImport.Image = global::JTPoseDump.Properties.Resources.Import_Display_Top;
			this.BtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnImport.Name = "BtnImport";
			this.BtnImport.Size = new System.Drawing.Size(23, 22);
			this.BtnImport.Text = "toolStripButton1";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnSendToGame
			// 
			this.BtnSendToGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSendToGame.Image = global::JTPoseDump.Properties.Resources.Up_Arrow;
			this.BtnSendToGame.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSendToGame.Name = "BtnSendToGame";
			this.BtnSendToGame.Size = new System.Drawing.Size(23, 22);
			this.BtnSendToGame.Text = "toolStripButton6";
			// 
			// BtnSwapImage
			// 
			this.BtnSwapImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSwapImage.Image = global::JTPoseDump.Properties.Resources.Switch_User;
			this.BtnSwapImage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSwapImage.Name = "BtnSwapImage";
			this.BtnSwapImage.Size = new System.Drawing.Size(23, 22);
			this.BtnSwapImage.Text = "toolStripButton1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(972, 463);
			this.Controls.Add(this.AAA);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PPG Pose Dump";
			this.TopMost = true;
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.AAA.ResumeLayout(false);
			this.AAA.PerformLayout();
			this.ARight.ResumeLayout(false);
			this.ARight.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.AMid.ResumeLayout(false);
			this.ALeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ImgCurrent)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Timer TimerFileSystem;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
		public System.Windows.Forms.ImageList AppIcons;
        public System.Windows.Forms.Panel AAA;
        public System.Windows.Forms.Panel ARight;
        public System.Windows.Forms.FlowLayoutPanel FlowPoseSet;
        public System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton BtnShowGrid;
        public System.Windows.Forms.ToolStripButton BtnShowFullWidth;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton BtnReload;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton BtnFavorite;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripTextBox TxtFilter;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.ToolStripLabel LblPoseCount;
        public System.Windows.Forms.Panel AMid;
        public System.Windows.Forms.PropertyGrid PGrid;
        public System.Windows.Forms.Panel ALeft;
        public System.Windows.Forms.RichTextBox RTB;
        public System.Windows.Forms.PictureBox ImgCurrent;
        public System.Windows.Forms.Label LblPoseName;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton BtnNew;
        public System.Windows.Forms.ToolStripButton BtnSave;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton BtnImport;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton BtnSendToGame;
        public System.Windows.Forms.ToolStripButton BtnSwapImage;
		public System.Windows.Forms.ToolStripLabel lblSelected;
	}
}

