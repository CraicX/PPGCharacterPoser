using System.Windows.Forms;

namespace JTPoseCore
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.AALeft = new System.Windows.Forms.Panel();
			this.RTB = new System.Windows.Forms.RichTextBox();
			this.ImgCurrent = new System.Windows.Forms.PictureBox();
			this.LblPoseName = new System.Windows.Forms.Label();
			this.AAMid = new System.Windows.Forms.Panel();
			this.PGrid = new System.Windows.Forms.PropertyGrid();
			this.AARight = new System.Windows.Forms.Panel();
			this.LblPoseCount = new System.Windows.Forms.ToolStrip();
			this.BtnShowGrid = new System.Windows.Forms.ToolStripButton();
			this.BtnShowFullWidth = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnReload = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnFavorite = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.TxtFilter = new System.Windows.Forms.ToolStripTextBox();
			this.lblSelected = new System.Windows.Forms.ToolStripLabel();
			this.FlowPoseSet = new System.Windows.Forms.FlowLayoutPanel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.BtnNew = new System.Windows.Forms.ToolStripButton();
			this.BtnSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnImport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnSendToGame = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnSwapImage = new System.Windows.Forms.ToolStripButton();
			this.BtnSettings = new System.Windows.Forms.ToolStripButton();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.IconList = new System.Windows.Forms.ImageList(this.components);
			this.TimerFileSystem = new System.Windows.Forms.Timer(this.components);
			this.AALeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgCurrent)).BeginInit();
			this.AAMid.SuspendLayout();
			this.AARight.SuspendLayout();
			this.LblPoseCount.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// AALeft
			// 
			this.AALeft.Controls.Add(this.RTB);
			this.AALeft.Controls.Add(this.ImgCurrent);
			this.AALeft.Controls.Add(this.LblPoseName);
			this.AALeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.AALeft.Location = new System.Drawing.Point(0, 33);
			this.AALeft.Name = "AALeft";
			this.AALeft.Size = new System.Drawing.Size(321, 569);
			this.AALeft.TabIndex = 0;
			// 
			// RTB
			// 
			this.RTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RTB.ForeColor = System.Drawing.Color.LemonChiffon;
			this.RTB.Location = new System.Drawing.Point(0, 357);
			this.RTB.Margin = new System.Windows.Forms.Padding(0);
			this.RTB.Name = "RTB";
			this.RTB.Size = new System.Drawing.Size(321, 212);
			this.RTB.TabIndex = 2;
			this.RTB.Text = "";
			// 
			// ImgCurrent
			// 
			this.ImgCurrent.BackColor = System.Drawing.Color.DarkGray;
			this.ImgCurrent.Dock = System.Windows.Forms.DockStyle.Top;
			this.ImgCurrent.Location = new System.Drawing.Point(0, 36);
			this.ImgCurrent.Margin = new System.Windows.Forms.Padding(0);
			this.ImgCurrent.Name = "ImgCurrent";
			this.ImgCurrent.Size = new System.Drawing.Size(321, 321);
			this.ImgCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgCurrent.TabIndex = 1;
			this.ImgCurrent.TabStop = false;
			// 
			// LblPoseName
			// 
			this.LblPoseName.BackColor = System.Drawing.Color.Silver;
			this.LblPoseName.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblPoseName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.LblPoseName.Location = new System.Drawing.Point(0, 0);
			this.LblPoseName.Name = "LblPoseName";
			this.LblPoseName.Size = new System.Drawing.Size(321, 36);
			this.LblPoseName.TabIndex = 0;
			this.LblPoseName.Text = "PoseName";
			this.LblPoseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AAMid
			// 
			this.AAMid.Controls.Add(this.PGrid);
			this.AAMid.Dock = System.Windows.Forms.DockStyle.Left;
			this.AAMid.Location = new System.Drawing.Point(321, 33);
			this.AAMid.Margin = new System.Windows.Forms.Padding(0);
			this.AAMid.Name = "AAMid";
			this.AAMid.Size = new System.Drawing.Size(289, 569);
			this.AAMid.TabIndex = 2;
			// 
			// PGrid
			// 
			this.PGrid.BackColor = System.Drawing.Color.DimGray;
			this.PGrid.CategoryForeColor = System.Drawing.Color.Chartreuse;
			this.PGrid.CategorySplitterColor = System.Drawing.Color.Gray;
			this.PGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PGrid.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PGrid.HelpBackColor = System.Drawing.Color.DimGray;
			this.PGrid.LineColor = System.Drawing.Color.DarkGray;
			this.PGrid.Location = new System.Drawing.Point(0, 0);
			this.PGrid.Margin = new System.Windows.Forms.Padding(0);
			this.PGrid.Name = "PGrid";
			this.PGrid.Size = new System.Drawing.Size(289, 569);
			this.PGrid.TabIndex = 0;
			this.PGrid.ToolbarVisible = false;
			this.PGrid.ViewBackColor = System.Drawing.Color.Silver;
			// 
			// AARight
			// 
			this.AARight.Controls.Add(this.LblPoseCount);
			this.AARight.Controls.Add(this.FlowPoseSet);
			this.AARight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AARight.Location = new System.Drawing.Point(610, 33);
			this.AARight.Margin = new System.Windows.Forms.Padding(0);
			this.AARight.Name = "AARight";
			this.AARight.Size = new System.Drawing.Size(535, 569);
			this.AARight.TabIndex = 4;
			// 
			// LblPoseCount
			// 
			this.LblPoseCount.BackColor = System.Drawing.Color.Silver;
			this.LblPoseCount.GripMargin = new System.Windows.Forms.Padding(5);
			this.LblPoseCount.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.LblPoseCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnShowGrid,
            this.BtnShowFullWidth,
            this.toolStripSeparator1,
            this.BtnReload,
            this.toolStripSeparator3,
            this.BtnFavorite,
            this.toolStripSeparator2,
            this.BtnDelete,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.TxtFilter,
            this.lblSelected});
			this.LblPoseCount.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.LblPoseCount.Location = new System.Drawing.Point(0, 0);
			this.LblPoseCount.Name = "LblPoseCount";
			this.LblPoseCount.Padding = new System.Windows.Forms.Padding(5);
			this.LblPoseCount.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.LblPoseCount.Size = new System.Drawing.Size(535, 33);
			this.LblPoseCount.TabIndex = 1;
			// 
			// BtnShowGrid
			// 
			this.BtnShowGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnShowGrid.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowGrid.Image")));
			this.BtnShowGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnShowGrid.Name = "BtnShowGrid";
			this.BtnShowGrid.Size = new System.Drawing.Size(23, 20);
			this.BtnShowGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.BtnShowGrid.ToolTipText = "View smaller grid";
			// 
			// BtnShowFullWidth
			// 
			this.BtnShowFullWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnShowFullWidth.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowFullWidth.Image")));
			this.BtnShowFullWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnShowFullWidth.Name = "BtnShowFullWidth";
			this.BtnShowFullWidth.Size = new System.Drawing.Size(23, 20);
			this.BtnShowFullWidth.ToolTipText = "view larger grid";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnReload
			// 
			this.BtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnReload.Image = ((System.Drawing.Image)(resources.GetObject("BtnReload.Image")));
			this.BtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnReload.Name = "BtnReload";
			this.BtnReload.Size = new System.Drawing.Size(23, 20);
			this.BtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnReload.ToolTipText = "Reload Poses";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnFavorite
			// 
			this.BtnFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("BtnFavorite.Image")));
			this.BtnFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnFavorite.Name = "BtnFavorite";
			this.BtnFavorite.Size = new System.Drawing.Size(23, 20);
			this.BtnFavorite.Text = "toolStripButton4";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnDelete
			// 
			this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
			this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(23, 20);
			this.BtnDelete.ToolTipText = "Delete Selected Poses";
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(49, 20);
			this.toolStripLabel1.Text = "Poses: 0";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
			// 
			// TxtFilter
			// 
			this.TxtFilter.AutoSize = false;
			this.TxtFilter.BackColor = System.Drawing.Color.LightGray;
			this.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtFilter.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
			this.TxtFilter.Name = "TxtFilter";
			this.TxtFilter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.TxtFilter.Size = new System.Drawing.Size(118, 23);
			// 
			// lblSelected
			// 
			this.lblSelected.ForeColor = System.Drawing.Color.Navy;
			this.lblSelected.Name = "lblSelected";
			this.lblSelected.Size = new System.Drawing.Size(0, 20);
			this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FlowPoseSet
			// 
			this.FlowPoseSet.AutoScroll = true;
			this.FlowPoseSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FlowPoseSet.BackColor = System.Drawing.Color.DarkGray;
			this.FlowPoseSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowPoseSet.Location = new System.Drawing.Point(0, 0);
			this.FlowPoseSet.Margin = new System.Windows.Forms.Padding(0);
			this.FlowPoseSet.Name = "FlowPoseSet";
			this.FlowPoseSet.Size = new System.Drawing.Size(535, 569);
			this.FlowPoseSet.TabIndex = 0;
			// 
			// toolStrip2
			// 
			this.toolStrip2.BackColor = System.Drawing.Color.Silver;
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnSave,
            this.toolStripSeparator5,
            this.BtnImport,
            this.toolStripSeparator6,
            this.BtnSendToGame,
            this.toolStripSeparator7,
            this.BtnSwapImage,
            this.BtnSettings});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(5);
			this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip2.Size = new System.Drawing.Size(1145, 33);
			this.toolStrip2.TabIndex = 5;
			// 
			// BtnNew
			// 
			this.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
			this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.Size = new System.Drawing.Size(23, 20);
			this.BtnNew.Text = "toolStripButton6";
			// 
			// BtnSave
			// 
			this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
			this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(23, 20);
			this.BtnSave.ToolTipText = "Save the current pose";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnImport
			// 
			this.BtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnImport.Image = ((System.Drawing.Image)(resources.GetObject("BtnImport.Image")));
			this.BtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnImport.Name = "BtnImport";
			this.BtnImport.Size = new System.Drawing.Size(23, 20);
			this.BtnImport.ToolTipText = "Import Poses from JSON PoseData";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnSendToGame
			// 
			this.BtnSendToGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSendToGame.Image = ((System.Drawing.Image)(resources.GetObject("BtnSendToGame.Image")));
			this.BtnSendToGame.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSendToGame.Name = "BtnSendToGame";
			this.BtnSendToGame.Size = new System.Drawing.Size(23, 20);
			this.BtnSendToGame.ToolTipText = "Send Pose to Game";
			this.BtnSendToGame.Click += new System.EventHandler(this.BtnSendToGame_Click_1);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnSwapImage
			// 
			this.BtnSwapImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSwapImage.Image = ((System.Drawing.Image)(resources.GetObject("BtnSwapImage.Image")));
			this.BtnSwapImage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSwapImage.Name = "BtnSwapImage";
			this.BtnSwapImage.Size = new System.Drawing.Size(23, 20);
			this.BtnSwapImage.ToolTipText = "Automatically apply poses";
			this.BtnSwapImage.Click += new System.EventHandler(this.BtnSwapImage_Click_1);
			// 
			// BtnSettings
			// 
			this.BtnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.BtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Image")));
			this.BtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSettings.Name = "BtnSettings";
			this.BtnSettings.Size = new System.Drawing.Size(23, 20);
			this.BtnSettings.Text = "toolStripButton11";
			this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
			// 
			// StatusBar
			// 
			this.StatusBar.BackColor = System.Drawing.Color.Silver;
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.StatusBar.Location = new System.Drawing.Point(0, 602);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(1145, 22);
			this.StatusBar.TabIndex = 7;
			this.StatusBar.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(39, 17);
			this.statusLabel.Text = "Ready";
			this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
			// 
			// IconList
			// 
			this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
			this.IconList.TransparentColor = System.Drawing.Color.Transparent;
			this.IconList.Images.SetKeyName(0, "Arrow Down.png");
			this.IconList.Images.SetKeyName(1, "Arrow Up.png");
			this.IconList.Images.SetKeyName(2, "Check.png");
			this.IconList.Images.SetKeyName(3, "Clock.png");
			this.IconList.Images.SetKeyName(4, "Close.png");
			this.IconList.Images.SetKeyName(5, "Crop.png");
			this.IconList.Images.SetKeyName(6, "Cut.png");
			this.IconList.Images.SetKeyName(7, "Delete.png");
			this.IconList.Images.SetKeyName(8, "Double Arrow Left.png");
			this.IconList.Images.SetKeyName(9, "Double Arrow Right.png");
			this.IconList.Images.SetKeyName(10, "Down Arrow.png");
			this.IconList.Images.SetKeyName(11, "Fill Copy.png");
			this.IconList.Images.SetKeyName(12, "Filters.png");
			this.IconList.Images.SetKeyName(13, "Folder Tight.png");
			this.IconList.Images.SetKeyName(14, "Grid Squares.png");
			this.IconList.Images.SetKeyName(15, "Ignore.png");
			this.IconList.Images.SetKeyName(16, "Image.png");
			this.IconList.Images.SetKeyName(17, "Import Display Top.png");
			this.IconList.Images.SetKeyName(18, "Like.png");
			this.IconList.Images.SetKeyName(19, "Link.png");
			this.IconList.Images.SetKeyName(20, "List.png");
			this.IconList.Images.SetKeyName(21, "Mirror Top.png");
			this.IconList.Images.SetKeyName(22, "Mirror.png");
			this.IconList.Images.SetKeyName(23, "Move.png");
			this.IconList.Images.SetKeyName(24, "Multiple Images.png");
			this.IconList.Images.SetKeyName(25, "New File.png");
			this.IconList.Images.SetKeyName(26, "Openn Folder.png");
			this.IconList.Images.SetKeyName(27, "Person Check.png");
			this.IconList.Images.SetKeyName(28, "Person Group.png");
			this.IconList.Images.SetKeyName(29, "Person.png");
			this.IconList.Images.SetKeyName(30, "Reload.png");
			this.IconList.Images.SetKeyName(31, "Save As.png");
			this.IconList.Images.SetKeyName(32, "Scale.png");
			this.IconList.Images.SetKeyName(33, "Sent to Display.png");
			this.IconList.Images.SetKeyName(34, "Settings.png");
			this.IconList.Images.SetKeyName(35, "Square.png");
			this.IconList.Images.SetKeyName(36, "Star.png");
			this.IconList.Images.SetKeyName(37, "Switch User.png");
			this.IconList.Images.SetKeyName(38, "Up Arrow.png");
			// 
			// TimerFileSystem
			// 
			this.TimerFileSystem.Enabled = true;
			this.TimerFileSystem.Interval = 1000;
			this.TimerFileSystem.Tick += new System.EventHandler(this.TimerFileSystem_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1145, 624);
			this.Controls.Add(this.AARight);
			this.Controls.Add(this.AAMid);
			this.Controls.Add(this.AALeft);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.StatusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "PPG Pose Dump";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
			this.AALeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ImgCurrent)).EndInit();
			this.AAMid.ResumeLayout(false);
			this.AARight.ResumeLayout(false);
			this.AARight.PerformLayout();
			this.LblPoseCount.ResumeLayout(false);
			this.LblPoseCount.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Panel AALeft;
		public Panel AAMid;
		public Panel AARight;
		public Label LblPoseName;
		public PictureBox ImgCurrent;
		public RichTextBox RTB;
		public ToolStrip LblPoseCount;
		public ToolStripButton BtnShowGrid;
		public ToolStripButton BtnShowFullWidth;
		public ToolStripButton BtnReload;
		public ToolStripButton BtnFavorite;
		public ToolStripButton BtnDelete;
		public ToolStripTextBox TxtFilter;
		public FlowLayoutPanel FlowPoseSet;
		public ToolStripLabel toolStripLabel1;
		public ToolStrip toolStrip2;
		public ToolStripButton BtnNew;
		public ToolStripButton BtnSave;
		public ToolStripButton BtnImport;
		public ToolStripButton BtnSendToGame;
		public ToolStripButton BtnSwapImage;
		public ToolStripSeparator toolStripSeparator1;
		public ToolStripSeparator toolStripSeparator2;
		public ToolStripSeparator toolStripSeparator3;
		public ToolStripSeparator toolStripSeparator4;
		public ToolStripSeparator toolStripSeparator5;
		public ToolStripSeparator toolStripSeparator6;
		public ToolStripSeparator toolStripSeparator7;
		public PropertyGrid PGrid;
		public ToolStripButton BtnSettings;
        public ToolStripLabel lblSelected;
		public StatusStrip StatusBar;
		public ToolStripStatusLabel statusLabel;
		private ImageList IconList;
		private System.Windows.Forms.Timer TimerFileSystem;
	}
}