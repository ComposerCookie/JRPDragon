namespace JackieRPG
{
    partial class ProjectDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trvDirectory = new System.Windows.Forms.TreeView();
            this.SelectedMapContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectedMapContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDirectory
            // 
            this.trvDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDirectory.Location = new System.Drawing.Point(0, 0);
            this.trvDirectory.Name = "trvDirectory";
            this.trvDirectory.Size = new System.Drawing.Size(202, 551);
            this.trvDirectory.TabIndex = 0;
            this.trvDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDirectory_AfterSelect);
            this.trvDirectory.DoubleClick += new System.EventHandler(this.trvDirectory_DoubleClick);
            this.trvDirectory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvDirectory_MouseDown);
            // 
            // SelectedMapContextMenuStrip
            // 
            this.SelectedMapContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMapToolStripMenuItem1,
            this.removeMapToolStripMenuItem,
            this.toolStripSeparator2,
            this.addLayerToolStripMenuItem,
            this.modifyLayerToolStripMenuItem,
            this.removeLayerToolStripMenuItem,
            this.toolStripSeparator1,
            this.testToolStripMenuItem});
            this.SelectedMapContextMenuStrip.Name = "contextMenuStrip1";
            this.SelectedMapContextMenuStrip.Size = new System.Drawing.Size(153, 170);
            this.SelectedMapContextMenuStrip.Text = "Selected Map:";
            // 
            // editMapToolStripMenuItem1
            // 
            this.editMapToolStripMenuItem1.Name = "editMapToolStripMenuItem1";
            this.editMapToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editMapToolStripMenuItem1.Text = "Edit";
            this.editMapToolStripMenuItem1.Click += new System.EventHandler(this.editMapToolStripMenuItem1_Click);
            // 
            // removeMapToolStripMenuItem
            // 
            this.removeMapToolStripMenuItem.Name = "removeMapToolStripMenuItem";
            this.removeMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeMapToolStripMenuItem.Text = "Remove";
            this.removeMapToolStripMenuItem.Click += new System.EventHandler(this.removeMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // addLayerToolStripMenuItem
            // 
            this.addLayerToolStripMenuItem.Name = "addLayerToolStripMenuItem";
            this.addLayerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addLayerToolStripMenuItem.Text = "Add Layer";
            // 
            // modifyLayerToolStripMenuItem
            // 
            this.modifyLayerToolStripMenuItem.Name = "modifyLayerToolStripMenuItem";
            this.modifyLayerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.modifyLayerToolStripMenuItem.Text = "Modify Layer";
            // 
            // removeLayerToolStripMenuItem
            // 
            this.removeLayerToolStripMenuItem.Name = "removeLayerToolStripMenuItem";
            this.removeLayerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeLayerToolStripMenuItem.Text = "Remove Layer";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ProjectDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 551);
            this.Controls.Add(this.trvDirectory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectDirectory";
            this.ShowInTaskbar = false;
            this.Text = "ProjectDirectory";
            this.SelectedMapContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDirectory;
        private System.Windows.Forms.ContextMenuStrip SelectedMapContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}