namespace JackieRPG
{
    partial class MapViewerForm
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
            this.buttAdd = new System.Windows.Forms.Button();
            this.buttRemove = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.chkShowBlock = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chkShowGrid = new System.Windows.Forms.CheckBox();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblVisible = new System.Windows.Forms.Label();
            this.chkConstantUpdate = new System.Windows.Forms.CheckBox();
            this.lbltileCount = new System.Windows.Forms.Label();
            this.lstLayer = new System.Windows.Forms.ListBox();
            this.vMapScroll = new System.Windows.Forms.VScrollBar();
            this.hMapScroll = new System.Windows.Forms.HScrollBar();
            this.picMapViewer = new System.Windows.Forms.PictureBox();
            this.buttModify = new System.Windows.Forms.Button();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttUp = new System.Windows.Forms.Button();
            this.buttDown = new System.Windows.Forms.Button();
            this.lstMini = new System.Windows.Forms.ListBox();
            this.buttMiniDown = new System.Windows.Forms.Button();
            this.buttMiniUp = new System.Windows.Forms.Button();
            this.buttModifyMini = new System.Windows.Forms.Button();
            this.buttAddMini = new System.Windows.Forms.Button();
            this.buttRemoveMini = new System.Windows.Forms.Button();
            this.chkBackground = new System.Windows.Forms.CheckBox();
            this.chkGround = new System.Windows.Forms.CheckBox();
            this.chkFringe = new System.Windows.Forms.CheckBox();
            this.chkBlock = new System.Windows.Forms.CheckBox();
            this.chkEvent = new System.Windows.Forms.CheckBox();
            this.chkShowEvent = new System.Windows.Forms.CheckBox();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMapViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttAdd
            // 
            this.buttAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttAdd.Location = new System.Drawing.Point(70, 699);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(55, 22);
            this.buttAdd.TabIndex = 13;
            this.buttAdd.Text = "Add";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // buttRemove
            // 
            this.buttRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttRemove.Location = new System.Drawing.Point(73, 727);
            this.buttRemove.Name = "buttRemove";
            this.buttRemove.Size = new System.Drawing.Size(55, 22);
            this.buttRemove.TabIndex = 12;
            this.buttRemove.Text = "Remove";
            this.buttRemove.UseVisualStyleBackColor = true;
            this.buttRemove.Click += new System.EventHandler(this.buttRemove_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupbox1.Controls.Add(this.chkShowBlock);
            this.groupbox1.Controls.Add(this.lblName);
            this.groupbox1.Controls.Add(this.chkShowGrid);
            this.groupbox1.Controls.Add(this.lblOpacity);
            this.groupbox1.Controls.Add(this.lblVisible);
            this.groupbox1.Controls.Add(this.chkConstantUpdate);
            this.groupbox1.Controls.Add(this.lbltileCount);
            this.groupbox1.Location = new System.Drawing.Point(395, 573);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(245, 149);
            this.groupbox1.TabIndex = 11;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Tile Layer Property: ";
            // 
            // chkShowBlock
            // 
            this.chkShowBlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkShowBlock.AutoSize = true;
            this.chkShowBlock.Checked = true;
            this.chkShowBlock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowBlock.Location = new System.Drawing.Point(150, 80);
            this.chkShowBlock.Name = "chkShowBlock";
            this.chkShowBlock.Size = new System.Drawing.Size(89, 17);
            this.chkShowBlock.TabIndex = 29;
            this.chkShowBlock.Text = "Show Block?";
            this.chkShowBlock.UseVisualStyleBackColor = true;
            this.chkShowBlock.CheckedChanged += new System.EventHandler(this.chkShowBlock_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name: ";
            // 
            // chkShowGrid
            // 
            this.chkShowGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkShowGrid.AutoSize = true;
            this.chkShowGrid.Checked = true;
            this.chkShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowGrid.Location = new System.Drawing.Point(158, 103);
            this.chkShowGrid.Name = "chkShowGrid";
            this.chkShowGrid.Size = new System.Drawing.Size(81, 17);
            this.chkShowGrid.TabIndex = 18;
            this.chkShowGrid.Text = "Show Grid?";
            this.chkShowGrid.UseVisualStyleBackColor = true;
            this.chkShowGrid.CheckedChanged += new System.EventHandler(this.chkShowGrid_CheckedChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(21, 72);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(67, 13);
            this.lblOpacity.TabIndex = 2;
            this.lblOpacity.Text = "Opacity: 100";
            // 
            // lblVisible
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.Location = new System.Drawing.Point(21, 49);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Size = new System.Drawing.Size(68, 13);
            this.lblVisible.TabIndex = 1;
            this.lblVisible.Text = "Visible: False";
            // 
            // chkConstantUpdate
            // 
            this.chkConstantUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkConstantUpdate.AutoSize = true;
            this.chkConstantUpdate.Checked = true;
            this.chkConstantUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConstantUpdate.Location = new System.Drawing.Point(126, 126);
            this.chkConstantUpdate.Name = "chkConstantUpdate";
            this.chkConstantUpdate.Size = new System.Drawing.Size(113, 17);
            this.chkConstantUpdate.TabIndex = 15;
            this.chkConstantUpdate.Text = "Automatic Refresh";
            this.chkConstantUpdate.UseVisualStyleBackColor = true;
            this.chkConstantUpdate.CheckedChanged += new System.EventHandler(this.chkConstantUpdate_CheckedChanged);
            // 
            // lbltileCount
            // 
            this.lbltileCount.AutoSize = true;
            this.lbltileCount.Location = new System.Drawing.Point(21, 27);
            this.lbltileCount.Name = "lbltileCount";
            this.lbltileCount.Size = new System.Drawing.Size(67, 13);
            this.lbltileCount.TabIndex = 0;
            this.lbltileCount.Text = "Tile Count: 0";
            // 
            // lstLayer
            // 
            this.lstLayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstLayer.FormattingEnabled = true;
            this.lstLayer.Location = new System.Drawing.Point(11, 584);
            this.lstLayer.Name = "lstLayer";
            this.lstLayer.Size = new System.Drawing.Size(166, 108);
            this.lstLayer.TabIndex = 10;
            this.lstLayer.SelectedIndexChanged += new System.EventHandler(this.lstLayer_SelectedIndexChanged);
            // 
            // vMapScroll
            // 
            this.vMapScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vMapScroll.Location = new System.Drawing.Point(618, 11);
            this.vMapScroll.Name = "vMapScroll";
            this.vMapScroll.Size = new System.Drawing.Size(20, 536);
            this.vMapScroll.TabIndex = 9;
            this.vMapScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vMapScroll_Scroll);
            // 
            // hMapScroll
            // 
            this.hMapScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hMapScroll.Location = new System.Drawing.Point(12, 550);
            this.hMapScroll.Name = "hMapScroll";
            this.hMapScroll.Size = new System.Drawing.Size(603, 20);
            this.hMapScroll.TabIndex = 8;
            this.hMapScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hMapScroll_Scroll);
            // 
            // picMapViewer
            // 
            this.picMapViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picMapViewer.BackColor = System.Drawing.Color.Black;
            this.picMapViewer.Location = new System.Drawing.Point(12, 12);
            this.picMapViewer.Name = "picMapViewer";
            this.picMapViewer.Size = new System.Drawing.Size(603, 535);
            this.picMapViewer.TabIndex = 7;
            this.picMapViewer.TabStop = false;
            this.picMapViewer.Click += new System.EventHandler(this.picMapViewer_Click);
            this.picMapViewer.DoubleClick += new System.EventHandler(this.picMapViewer_DoubleClick);
            this.picMapViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMapViewer_MouseDown);
            this.picMapViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMapViewer_MouseUp);
            this.picMapViewer.Resize += new System.EventHandler(this.picMapViewer_Resize);
            // 
            // buttModify
            // 
            this.buttModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttModify.Location = new System.Drawing.Point(12, 727);
            this.buttModify.Name = "buttModify";
            this.buttModify.Size = new System.Drawing.Size(55, 22);
            this.buttModify.TabIndex = 14;
            this.buttModify.Text = "Modify";
            this.buttModify.UseVisualStyleBackColor = true;
            this.buttModify.Click += new System.EventHandler(this.buttModify_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 180;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // buttUp
            // 
            this.buttUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttUp.Location = new System.Drawing.Point(12, 699);
            this.buttUp.Name = "buttUp";
            this.buttUp.Size = new System.Drawing.Size(23, 22);
            this.buttUp.TabIndex = 16;
            this.buttUp.Text = "^";
            this.buttUp.UseVisualStyleBackColor = true;
            this.buttUp.Click += new System.EventHandler(this.buttUp_Click);
            // 
            // buttDown
            // 
            this.buttDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttDown.Location = new System.Drawing.Point(41, 699);
            this.buttDown.Name = "buttDown";
            this.buttDown.Size = new System.Drawing.Size(23, 22);
            this.buttDown.TabIndex = 17;
            this.buttDown.Text = "v";
            this.buttDown.UseVisualStyleBackColor = true;
            this.buttDown.Click += new System.EventHandler(this.buttDown_Click);
            // 
            // lstMini
            // 
            this.lstMini.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstMini.FormattingEnabled = true;
            this.lstMini.Location = new System.Drawing.Point(183, 584);
            this.lstMini.Name = "lstMini";
            this.lstMini.Size = new System.Drawing.Size(206, 108);
            this.lstMini.TabIndex = 19;
            this.lstMini.SelectedIndexChanged += new System.EventHandler(this.lstMini_SelectedIndexChanged);
            // 
            // buttMiniDown
            // 
            this.buttMiniDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttMiniDown.Location = new System.Drawing.Point(212, 700);
            this.buttMiniDown.Name = "buttMiniDown";
            this.buttMiniDown.Size = new System.Drawing.Size(23, 22);
            this.buttMiniDown.TabIndex = 24;
            this.buttMiniDown.Text = "v";
            this.buttMiniDown.UseVisualStyleBackColor = true;
            this.buttMiniDown.Click += new System.EventHandler(this.buttMiniDown_Click);
            // 
            // buttMiniUp
            // 
            this.buttMiniUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttMiniUp.Location = new System.Drawing.Point(183, 700);
            this.buttMiniUp.Name = "buttMiniUp";
            this.buttMiniUp.Size = new System.Drawing.Size(23, 22);
            this.buttMiniUp.TabIndex = 23;
            this.buttMiniUp.Text = "^";
            this.buttMiniUp.UseVisualStyleBackColor = true;
            this.buttMiniUp.Click += new System.EventHandler(this.buttMiniUp_Click);
            // 
            // buttModifyMini
            // 
            this.buttModifyMini.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttModifyMini.Location = new System.Drawing.Point(183, 728);
            this.buttModifyMini.Name = "buttModifyMini";
            this.buttModifyMini.Size = new System.Drawing.Size(55, 22);
            this.buttModifyMini.TabIndex = 22;
            this.buttModifyMini.Text = "Modify";
            this.buttModifyMini.UseVisualStyleBackColor = true;
            // 
            // buttAddMini
            // 
            this.buttAddMini.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttAddMini.Location = new System.Drawing.Point(241, 700);
            this.buttAddMini.Name = "buttAddMini";
            this.buttAddMini.Size = new System.Drawing.Size(55, 22);
            this.buttAddMini.TabIndex = 21;
            this.buttAddMini.Text = "Add";
            this.buttAddMini.UseVisualStyleBackColor = true;
            this.buttAddMini.Click += new System.EventHandler(this.buttAddMini_Click);
            // 
            // buttRemoveMini
            // 
            this.buttRemoveMini.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttRemoveMini.Location = new System.Drawing.Point(244, 728);
            this.buttRemoveMini.Name = "buttRemoveMini";
            this.buttRemoveMini.Size = new System.Drawing.Size(55, 22);
            this.buttRemoveMini.TabIndex = 20;
            this.buttRemoveMini.Text = "Remove";
            this.buttRemoveMini.UseVisualStyleBackColor = true;
            // 
            // chkBackground
            // 
            this.chkBackground.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkBackground.AutoSize = true;
            this.chkBackground.Checked = true;
            this.chkBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBackground.Location = new System.Drawing.Point(305, 733);
            this.chkBackground.Name = "chkBackground";
            this.chkBackground.Size = new System.Drawing.Size(122, 17);
            this.chkBackground.TabIndex = 25;
            this.chkBackground.Text = "Editting Background";
            this.chkBackground.UseVisualStyleBackColor = true;
            this.chkBackground.CheckedChanged += new System.EventHandler(this.chkBackground_CheckedChanged);
            // 
            // chkGround
            // 
            this.chkGround.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkGround.AutoSize = true;
            this.chkGround.Checked = true;
            this.chkGround.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGround.Location = new System.Drawing.Point(543, 733);
            this.chkGround.Name = "chkGround";
            this.chkGround.Size = new System.Drawing.Size(97, 17);
            this.chkGround.TabIndex = 26;
            this.chkGround.Text = "Show Ground?";
            this.chkGround.UseVisualStyleBackColor = true;
            this.chkGround.CheckedChanged += new System.EventHandler(this.chkGround_CheckedChanged);
            // 
            // chkFringe
            // 
            this.chkFringe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkFringe.AutoSize = true;
            this.chkFringe.Checked = true;
            this.chkFringe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFringe.Location = new System.Drawing.Point(541, 756);
            this.chkFringe.Name = "chkFringe";
            this.chkFringe.Size = new System.Drawing.Size(91, 17);
            this.chkFringe.TabIndex = 27;
            this.chkFringe.Text = "Show Fringe?";
            this.chkFringe.UseVisualStyleBackColor = true;
            this.chkFringe.CheckedChanged += new System.EventHandler(this.chkFringe_CheckedChanged);
            // 
            // chkBlock
            // 
            this.chkBlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkBlock.AutoSize = true;
            this.chkBlock.Location = new System.Drawing.Point(305, 756);
            this.chkBlock.Name = "chkBlock";
            this.chkBlock.Size = new System.Drawing.Size(91, 17);
            this.chkBlock.TabIndex = 28;
            this.chkBlock.Text = "Editting Block";
            this.chkBlock.UseVisualStyleBackColor = true;
            this.chkBlock.CheckedChanged += new System.EventHandler(this.chkBlock_CheckedChanged);
            // 
            // chkEvent
            // 
            this.chkEvent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkEvent.AutoSize = true;
            this.chkEvent.Location = new System.Drawing.Point(305, 779);
            this.chkEvent.Name = "chkEvent";
            this.chkEvent.Size = new System.Drawing.Size(98, 17);
            this.chkEvent.TabIndex = 29;
            this.chkEvent.Text = "Editting Event?";
            this.chkEvent.UseVisualStyleBackColor = true;
            this.chkEvent.CheckedChanged += new System.EventHandler(this.chkEvent_CheckedChanged);
            // 
            // chkShowEvent
            // 
            this.chkShowEvent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkShowEvent.AutoSize = true;
            this.chkShowEvent.Checked = true;
            this.chkShowEvent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowEvent.Location = new System.Drawing.Point(541, 779);
            this.chkShowEvent.Name = "chkShowEvent";
            this.chkShowEvent.Size = new System.Drawing.Size(90, 17);
            this.chkShowEvent.TabIndex = 30;
            this.chkShowEvent.Text = "Show Event?";
            this.chkShowEvent.UseVisualStyleBackColor = true;
            // 
            // MapViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 799);
            this.Controls.Add(this.chkShowEvent);
            this.Controls.Add(this.chkEvent);
            this.Controls.Add(this.chkBlock);
            this.Controls.Add(this.chkFringe);
            this.Controls.Add(this.chkGround);
            this.Controls.Add(this.chkBackground);
            this.Controls.Add(this.buttMiniDown);
            this.Controls.Add(this.buttMiniUp);
            this.Controls.Add(this.buttModifyMini);
            this.Controls.Add(this.buttAddMini);
            this.Controls.Add(this.buttRemoveMini);
            this.Controls.Add(this.lstMini);
            this.Controls.Add(this.buttDown);
            this.Controls.Add(this.buttUp);
            this.Controls.Add(this.buttModify);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.buttRemove);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.lstLayer);
            this.Controls.Add(this.vMapScroll);
            this.Controls.Add(this.hMapScroll);
            this.Controls.Add(this.picMapViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MapViewerForm";
            this.Text = "MapViewerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.MapViewerForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MapViewerForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MapViewerForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MapViewerForm_Resize);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMapViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Button buttRemove;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label lbltileCount;
        private System.Windows.Forms.ListBox lstLayer;
        private System.Windows.Forms.VScrollBar vMapScroll;
        private System.Windows.Forms.HScrollBar hMapScroll;
        private System.Windows.Forms.PictureBox picMapViewer;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.Button buttModify;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkConstantUpdate;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Button buttUp;
        private System.Windows.Forms.Button buttDown;
        private System.Windows.Forms.CheckBox chkShowGrid;
        private System.Windows.Forms.ListBox lstMini;
        private System.Windows.Forms.Button buttMiniDown;
        private System.Windows.Forms.Button buttMiniUp;
        private System.Windows.Forms.Button buttModifyMini;
        private System.Windows.Forms.Button buttAddMini;
        private System.Windows.Forms.Button buttRemoveMini;
        private System.Windows.Forms.CheckBox chkBackground;
        private System.Windows.Forms.CheckBox chkGround;
        private System.Windows.Forms.CheckBox chkFringe;
        private System.Windows.Forms.CheckBox chkBlock;
        private System.Windows.Forms.CheckBox chkShowBlock;
        private System.Windows.Forms.CheckBox chkEvent;
        private System.Windows.Forms.CheckBox chkShowEvent;

    }
}