namespace Moon_DB
{
	partial class MoonDbForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonDbForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.listBoxMoons = new System.Windows.Forms.ListBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageMoonlist = new System.Windows.Forms.TabPage();
			this.tabPageComments = new System.Windows.Forms.TabPage();
			this.tabPageReferences = new System.Windows.Forms.TabPage();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(784, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "status bar";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
			this.toolStripStatusLabel.Text = "information";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 491);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(784, 562);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// splitContainer
			// 
			this.splitContainer.AccessibleDescription = "Group the main window";
			this.splitContainer.AccessibleName = "Main split grouper";
			this.splitContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.AccessibleDescription = "Left pane of the main split grouper";
			this.splitContainer.Panel1.AccessibleName = "Left pane of the main split grouper";
			this.splitContainer.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.splitContainer.Panel1.Controls.Add(this.listBoxMoons);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.AccessibleDescription = "Right pane of the main split grouper";
			this.splitContainer.Panel2.AccessibleName = "Right pane of the main split grouper";
			this.splitContainer.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.splitContainer.Panel2.Controls.Add(this.tabControl);
			this.splitContainer.Size = new System.Drawing.Size(784, 491);
			this.splitContainer.SplitterDistance = 261;
			this.splitContainer.TabIndex = 0;
			// 
			// listBoxMoons
			// 
			this.listBoxMoons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxMoons.FormattingEnabled = true;
			this.listBoxMoons.HorizontalScrollbar = true;
			this.listBoxMoons.Location = new System.Drawing.Point(0, 0);
			this.listBoxMoons.Name = "listBoxMoons";
			this.listBoxMoons.Size = new System.Drawing.Size(261, 491);
			this.listBoxMoons.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageMoonlist);
			this.tabControl.Controls.Add(this.tabPageComments);
			this.tabControl.Controls.Add(this.tabPageReferences);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.HotTrack = true;
			this.tabControl.ImageList = this.imageList;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.ShowToolTips = true;
			this.tabControl.Size = new System.Drawing.Size(519, 491);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageMoonlist
			// 
			this.tabPageMoonlist.AccessibleDescription = "Show the moon list";
			this.tabPageMoonlist.AccessibleName = "Moon list";
			this.tabPageMoonlist.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageMoonlist.AutoScroll = true;
			this.tabPageMoonlist.ImageKey = "moon.png";
			this.tabPageMoonlist.Location = new System.Drawing.Point(4, 23);
			this.tabPageMoonlist.Name = "tabPageMoonlist";
			this.tabPageMoonlist.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMoonlist.Size = new System.Drawing.Size(511, 464);
			this.tabPageMoonlist.TabIndex = 0;
			this.tabPageMoonlist.Text = "Moons";
			this.toolTip.SetToolTip(this.tabPageMoonlist, "Moon list");
			this.tabPageMoonlist.ToolTipText = "Moon list";
			this.tabPageMoonlist.UseVisualStyleBackColor = true;
			// 
			// tabPageComments
			// 
			this.tabPageComments.AccessibleDescription = "Show the comments";
			this.tabPageComments.AccessibleName = "Commtens";
			this.tabPageComments.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageComments.AutoScroll = true;
			this.tabPageComments.ImageKey = "comment.png";
			this.tabPageComments.Location = new System.Drawing.Point(4, 23);
			this.tabPageComments.Name = "tabPageComments";
			this.tabPageComments.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageComments.Size = new System.Drawing.Size(511, 464);
			this.tabPageComments.TabIndex = 1;
			this.tabPageComments.Text = "Comments";
			this.toolTip.SetToolTip(this.tabPageComments, "Commtens");
			this.tabPageComments.ToolTipText = "Commtens";
			this.tabPageComments.UseVisualStyleBackColor = true;
			// 
			// tabPageReferences
			// 
			this.tabPageReferences.AccessibleDescription = "Show the references";
			this.tabPageReferences.AccessibleName = "References";
			this.tabPageReferences.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageReferences.AutoScroll = true;
			this.tabPageReferences.ImageKey = "book.png";
			this.tabPageReferences.Location = new System.Drawing.Point(4, 23);
			this.tabPageReferences.Name = "tabPageReferences";
			this.tabPageReferences.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageReferences.Size = new System.Drawing.Size(511, 464);
			this.tabPageReferences.TabIndex = 2;
			this.tabPageReferences.Text = "References";
			this.toolTip.SetToolTip(this.tabPageReferences, "References");
			this.tabPageReferences.ToolTipText = "References";
			this.tabPageReferences.UseVisualStyleBackColor = true;
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(784, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menu";
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.Location = new System.Drawing.Point(3, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(111, 25);
			this.toolStrip.TabIndex = 1;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "moon.png");
			this.imageList.Images.SetKeyName(1, "comment.png");
			this.imageList.Images.SetKeyName(2, "book.png");
			// 
			// MoonDbForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MoonDbForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Moon-DB";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListBox listBoxMoons;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageMoonlist;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TabPage tabPageComments;
		private System.Windows.Forms.TabPage tabPageReferences;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ToolStrip toolStrip;
	}
}

