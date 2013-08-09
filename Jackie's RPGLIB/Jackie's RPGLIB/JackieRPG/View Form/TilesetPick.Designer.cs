namespace JackieRPG
{
    partial class TilesetPick
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
            this.picTilesetViewer = new System.Windows.Forms.PictureBox();
            this.vTilesetScroll = new System.Windows.Forms.VScrollBar();
            this.hTilesetScroll = new System.Windows.Forms.HScrollBar();
            this.toRightTSbutt = new System.Windows.Forms.Button();
            this.toLeftTSbutt = new System.Windows.Forms.Button();
            this.txtCurTS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTilePicked = new System.Windows.Forms.Label();
            this.lblMouseLoc = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.chkShowGrid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTilesetViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTilesetViewer
            // 
            this.picTilesetViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picTilesetViewer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picTilesetViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTilesetViewer.Location = new System.Drawing.Point(12, 12);
            this.picTilesetViewer.Name = "picTilesetViewer";
            this.picTilesetViewer.Size = new System.Drawing.Size(266, 514);
            this.picTilesetViewer.TabIndex = 0;
            this.picTilesetViewer.TabStop = false;
            this.picTilesetViewer.Click += new System.EventHandler(this.picTilesetViewer_Click);
            this.picTilesetViewer.MouseHover += new System.EventHandler(this.picTilesetViewer_MouseHover);
            this.picTilesetViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTilesetViewer_MouseMove);
            this.picTilesetViewer.Resize += new System.EventHandler(this.picTilesetViewer_Resize);
            // 
            // vTilesetScroll
            // 
            this.vTilesetScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vTilesetScroll.Location = new System.Drawing.Point(281, 12);
            this.vTilesetScroll.Name = "vTilesetScroll";
            this.vTilesetScroll.Size = new System.Drawing.Size(19, 514);
            this.vTilesetScroll.TabIndex = 1;
            this.vTilesetScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vTilesetScroll_Scroll);
            // 
            // hTilesetScroll
            // 
            this.hTilesetScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hTilesetScroll.Location = new System.Drawing.Point(9, 529);
            this.hTilesetScroll.Name = "hTilesetScroll";
            this.hTilesetScroll.Size = new System.Drawing.Size(269, 19);
            this.hTilesetScroll.TabIndex = 2;
            this.hTilesetScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hTilesetScroll_Scroll);
            // 
            // toRightTSbutt
            // 
            this.toRightTSbutt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toRightTSbutt.Location = new System.Drawing.Point(237, 560);
            this.toRightTSbutt.Name = "toRightTSbutt";
            this.toRightTSbutt.Size = new System.Drawing.Size(32, 29);
            this.toRightTSbutt.TabIndex = 3;
            this.toRightTSbutt.Text = ">";
            this.toRightTSbutt.UseVisualStyleBackColor = true;
            this.toRightTSbutt.Click += new System.EventHandler(this.toRightTSbutt_Click);
            // 
            // toLeftTSbutt
            // 
            this.toLeftTSbutt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toLeftTSbutt.Location = new System.Drawing.Point(36, 560);
            this.toLeftTSbutt.Name = "toLeftTSbutt";
            this.toLeftTSbutt.Size = new System.Drawing.Size(32, 29);
            this.toLeftTSbutt.TabIndex = 4;
            this.toLeftTSbutt.Text = "<";
            this.toLeftTSbutt.UseVisualStyleBackColor = true;
            this.toLeftTSbutt.Click += new System.EventHandler(this.toLeftTSbutt_Click);
            // 
            // txtCurTS
            // 
            this.txtCurTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurTS.Location = new System.Drawing.Point(74, 565);
            this.txtCurTS.Name = "txtCurTS";
            this.txtCurTS.ReadOnly = true;
            this.txtCurTS.Size = new System.Drawing.Size(157, 13);
            this.txtCurTS.TabIndex = 5;
            this.txtCurTS.Text = "1/20";
            this.txtCurTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkShowGrid);
            this.groupBox1.Controls.Add(this.lblTilePicked);
            this.groupBox1.Controls.Add(this.lblMouseLoc);
            this.groupBox1.Location = new System.Drawing.Point(9, 595);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Information:";
            // 
            // lblTilePicked
            // 
            this.lblTilePicked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTilePicked.AutoSize = true;
            this.lblTilePicked.Location = new System.Drawing.Point(6, 47);
            this.lblTilePicked.Name = "lblTilePicked";
            this.lblTilePicked.Size = new System.Drawing.Size(90, 13);
            this.lblTilePicked.TabIndex = 1;
            this.lblTilePicked.Text = "Tile Picked\'s ID:  ";
            // 
            // lblMouseLoc
            // 
            this.lblMouseLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMouseLoc.AutoSize = true;
            this.lblMouseLoc.Location = new System.Drawing.Point(6, 25);
            this.lblMouseLoc.Name = "lblMouseLoc";
            this.lblMouseLoc.Size = new System.Drawing.Size(89, 13);
            this.lblMouseLoc.TabIndex = 0;
            this.lblMouseLoc.Text = "Mouse Location: ";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // chkShowGrid
            // 
            this.chkShowGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowGrid.AutoSize = true;
            this.chkShowGrid.Checked = true;
            this.chkShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowGrid.Location = new System.Drawing.Point(9, 89);
            this.chkShowGrid.Name = "chkShowGrid";
            this.chkShowGrid.Size = new System.Drawing.Size(81, 17);
            this.chkShowGrid.TabIndex = 19;
            this.chkShowGrid.Text = "Show Grid?";
            this.chkShowGrid.UseVisualStyleBackColor = true;
            this.chkShowGrid.CheckedChanged += new System.EventHandler(this.chkShowGrid_CheckedChanged);
            // 
            // TilesetPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCurTS);
            this.Controls.Add(this.toLeftTSbutt);
            this.Controls.Add(this.toRightTSbutt);
            this.Controls.Add(this.hTilesetScroll);
            this.Controls.Add(this.vTilesetScroll);
            this.Controls.Add(this.picTilesetViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TilesetPick";
            this.Text = "TilesetPic";
            this.ResizeBegin += new System.EventHandler(this.TilesetPick_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TilesetPick_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TilesetPick_Paint);
            this.Resize += new System.EventHandler(this.TilesetPick_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picTilesetViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTilesetViewer;
        private System.Windows.Forms.VScrollBar vTilesetScroll;
        private System.Windows.Forms.HScrollBar hTilesetScroll;
        private System.Windows.Forms.Button toRightTSbutt;
        private System.Windows.Forms.Button toLeftTSbutt;
        private System.Windows.Forms.TextBox txtCurTS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTilePicked;
        private System.Windows.Forms.Label lblMouseLoc;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.CheckBox chkShowGrid;
    }
}