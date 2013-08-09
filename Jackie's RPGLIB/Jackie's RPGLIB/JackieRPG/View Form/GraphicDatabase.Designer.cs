namespace JackieRPG
{
    partial class GraphicDatabase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabGraphic = new System.Windows.Forms.TabControl();
            this.tabSprite = new System.Windows.Forms.TabPage();
            this.vSpriteScroll = new System.Windows.Forms.VScrollBar();
            this.hSpriteScroll = new System.Windows.Forms.HScrollBar();
            this.lstSprite = new System.Windows.Forms.ListBox();
            this.buttDeleteSprite = new System.Windows.Forms.Button();
            this.buttAddSprite = new System.Windows.Forms.Button();
            this.buttModifySprite = new System.Windows.Forms.Button();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabTileset = new System.Windows.Forms.TabPage();
            this.lstTileset = new System.Windows.Forms.ListBox();
            this.buttDelete = new System.Windows.Forms.Button();
            this.buttAddTileset = new System.Windows.Forms.Button();
            this.buttModifyTileset = new System.Windows.Forms.Button();
            this.grpTilesetProperty = new System.Windows.Forms.GroupBox();
            this.lblEditting = new System.Windows.Forms.Label();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.vTilesetScroll = new System.Windows.Forms.VScrollBar();
            this.hTilesetScroll = new System.Windows.Forms.HScrollBar();
            this.picTilesetViewer = new System.Windows.Forms.PictureBox();
            this.tabAnimation = new System.Windows.Forms.TabPage();
            this.tabFace = new System.Windows.Forms.TabPage();
            this.chkAnimation = new System.Windows.Forms.CheckBox();
            this.picSpriteAnimation = new System.Windows.Forms.PictureBox();
            this.tmrRefresher = new System.Windows.Forms.Timer(this.components);
            this.vFaceScroll = new System.Windows.Forms.VScrollBar();
            this.hFaceScroll = new System.Windows.Forms.HScrollBar();
            this.lstFace = new System.Windows.Forms.ListBox();
            this.buttDeleteFace = new System.Windows.Forms.Button();
            this.buttAddFace = new System.Windows.Forms.Button();
            this.buttModifyFace = new System.Windows.Forms.Button();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.TabGraphic.SuspendLayout();
            this.tabSprite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            this.tabTileset.SuspendLayout();
            this.grpTilesetProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTilesetViewer)).BeginInit();
            this.tabFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpriteAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabGraphic);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphic:";
            // 
            // TabGraphic
            // 
            this.TabGraphic.Controls.Add(this.tabSprite);
            this.TabGraphic.Controls.Add(this.tabTileset);
            this.TabGraphic.Controls.Add(this.tabAnimation);
            this.TabGraphic.Controls.Add(this.tabFace);
            this.TabGraphic.Location = new System.Drawing.Point(11, 18);
            this.TabGraphic.Name = "TabGraphic";
            this.TabGraphic.SelectedIndex = 0;
            this.TabGraphic.Size = new System.Drawing.Size(623, 501);
            this.TabGraphic.TabIndex = 0;
            this.TabGraphic.Click += new System.EventHandler(this.TabGraphic_Click);
            // 
            // tabSprite
            // 
            this.tabSprite.Controls.Add(this.chkAnimation);
            this.tabSprite.Controls.Add(this.picSpriteAnimation);
            this.tabSprite.Controls.Add(this.vSpriteScroll);
            this.tabSprite.Controls.Add(this.hSpriteScroll);
            this.tabSprite.Controls.Add(this.lstSprite);
            this.tabSprite.Controls.Add(this.buttDeleteSprite);
            this.tabSprite.Controls.Add(this.buttAddSprite);
            this.tabSprite.Controls.Add(this.buttModifySprite);
            this.tabSprite.Controls.Add(this.picSprite);
            this.tabSprite.Controls.Add(this.groupBox2);
            this.tabSprite.Location = new System.Drawing.Point(4, 22);
            this.tabSprite.Name = "tabSprite";
            this.tabSprite.Padding = new System.Windows.Forms.Padding(3);
            this.tabSprite.Size = new System.Drawing.Size(615, 475);
            this.tabSprite.TabIndex = 0;
            this.tabSprite.Text = "Sprite";
            this.tabSprite.UseVisualStyleBackColor = true;
            // 
            // vSpriteScroll
            // 
            this.vSpriteScroll.Location = new System.Drawing.Point(376, 17);
            this.vSpriteScroll.Name = "vSpriteScroll";
            this.vSpriteScroll.Size = new System.Drawing.Size(20, 239);
            this.vSpriteScroll.TabIndex = 16;
            this.vSpriteScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSpriteScroll_Scroll);
            // 
            // hSpriteScroll
            // 
            this.hSpriteScroll.Location = new System.Drawing.Point(189, 259);
            this.hSpriteScroll.Name = "hSpriteScroll";
            this.hSpriteScroll.Size = new System.Drawing.Size(184, 17);
            this.hSpriteScroll.TabIndex = 15;
            this.hSpriteScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSpriteScroll_Scroll);
            // 
            // lstSprite
            // 
            this.lstSprite.FormattingEnabled = true;
            this.lstSprite.Location = new System.Drawing.Point(17, 17);
            this.lstSprite.Name = "lstSprite";
            this.lstSprite.Size = new System.Drawing.Size(157, 446);
            this.lstSprite.TabIndex = 14;
            this.lstSprite.SelectedIndexChanged += new System.EventHandler(this.lstSprite_SelectedIndexChanged);
            // 
            // buttDeleteSprite
            // 
            this.buttDeleteSprite.Location = new System.Drawing.Point(545, 434);
            this.buttDeleteSprite.Name = "buttDeleteSprite";
            this.buttDeleteSprite.Size = new System.Drawing.Size(51, 23);
            this.buttDeleteSprite.TabIndex = 13;
            this.buttDeleteSprite.Text = "Delete";
            this.buttDeleteSprite.UseVisualStyleBackColor = true;
            // 
            // buttAddSprite
            // 
            this.buttAddSprite.Location = new System.Drawing.Point(431, 434);
            this.buttAddSprite.Name = "buttAddSprite";
            this.buttAddSprite.Size = new System.Drawing.Size(51, 23);
            this.buttAddSprite.TabIndex = 12;
            this.buttAddSprite.Text = "Add";
            this.buttAddSprite.UseVisualStyleBackColor = true;
            this.buttAddSprite.Click += new System.EventHandler(this.buttAddSprite_Click);
            // 
            // buttModifySprite
            // 
            this.buttModifySprite.Location = new System.Drawing.Point(488, 434);
            this.buttModifySprite.Name = "buttModifySprite";
            this.buttModifySprite.Size = new System.Drawing.Size(51, 23);
            this.buttModifySprite.TabIndex = 11;
            this.buttModifySprite.Text = "Modify";
            this.buttModifySprite.UseVisualStyleBackColor = true;
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.DarkGray;
            this.picSprite.Location = new System.Drawing.Point(189, 17);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(184, 239);
            this.picSprite.TabIndex = 10;
            this.picSprite.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(419, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 411);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sprite Property:";
            // 
            // tabTileset
            // 
            this.tabTileset.Controls.Add(this.lstTileset);
            this.tabTileset.Controls.Add(this.buttDelete);
            this.tabTileset.Controls.Add(this.buttAddTileset);
            this.tabTileset.Controls.Add(this.buttModifyTileset);
            this.tabTileset.Controls.Add(this.grpTilesetProperty);
            this.tabTileset.Controls.Add(this.vTilesetScroll);
            this.tabTileset.Controls.Add(this.hTilesetScroll);
            this.tabTileset.Controls.Add(this.picTilesetViewer);
            this.tabTileset.Location = new System.Drawing.Point(4, 22);
            this.tabTileset.Name = "tabTileset";
            this.tabTileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileset.Size = new System.Drawing.Size(615, 475);
            this.tabTileset.TabIndex = 1;
            this.tabTileset.Text = "Tileset";
            this.tabTileset.UseVisualStyleBackColor = true;
            // 
            // lstTileset
            // 
            this.lstTileset.FormattingEnabled = true;
            this.lstTileset.Location = new System.Drawing.Point(6, 10);
            this.lstTileset.Name = "lstTileset";
            this.lstTileset.Size = new System.Drawing.Size(141, 459);
            this.lstTileset.TabIndex = 11;
            this.lstTileset.SelectedIndexChanged += new System.EventHandler(this.lstTileset_SelectedIndexChanged);
            // 
            // buttDelete
            // 
            this.buttDelete.Location = new System.Drawing.Point(553, 446);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(51, 23);
            this.buttDelete.TabIndex = 10;
            this.buttDelete.Text = "Delete";
            this.buttDelete.UseVisualStyleBackColor = true;
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // buttAddTileset
            // 
            this.buttAddTileset.Location = new System.Drawing.Point(439, 446);
            this.buttAddTileset.Name = "buttAddTileset";
            this.buttAddTileset.Size = new System.Drawing.Size(51, 23);
            this.buttAddTileset.TabIndex = 9;
            this.buttAddTileset.Text = "Add";
            this.buttAddTileset.UseVisualStyleBackColor = true;
            this.buttAddTileset.Click += new System.EventHandler(this.buttAddTileset_Click);
            // 
            // buttModifyTileset
            // 
            this.buttModifyTileset.Location = new System.Drawing.Point(496, 446);
            this.buttModifyTileset.Name = "buttModifyTileset";
            this.buttModifyTileset.Size = new System.Drawing.Size(51, 23);
            this.buttModifyTileset.TabIndex = 8;
            this.buttModifyTileset.Text = "Modify";
            this.buttModifyTileset.UseVisualStyleBackColor = true;
            this.buttModifyTileset.Click += new System.EventHandler(this.buttModifyTileset_Click);
            // 
            // grpTilesetProperty
            // 
            this.grpTilesetProperty.Controls.Add(this.lblEditting);
            this.grpTilesetProperty.Controls.Add(this.picRefresh);
            this.grpTilesetProperty.Controls.Add(this.lblName);
            this.grpTilesetProperty.Location = new System.Drawing.Point(439, 10);
            this.grpTilesetProperty.Name = "grpTilesetProperty";
            this.grpTilesetProperty.Size = new System.Drawing.Size(165, 430);
            this.grpTilesetProperty.TabIndex = 3;
            this.grpTilesetProperty.TabStop = false;
            this.grpTilesetProperty.Text = "Property:";
            this.grpTilesetProperty.Enter += new System.EventHandler(this.grpTilesetProperty_Enter);
            // 
            // lblEditting
            // 
            this.lblEditting.AutoSize = true;
            this.lblEditting.Location = new System.Drawing.Point(6, 25);
            this.lblEditting.Name = "lblEditting";
            this.lblEditting.Size = new System.Drawing.Size(121, 13);
            this.lblEditting.TabIndex = 4;
            this.lblEditting.Text = "Editing Tileset: 9999999";
            // 
            // picRefresh
            // 
            this.picRefresh.Location = new System.Drawing.Point(127, 19);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(32, 31);
            this.picRefresh.TabIndex = 1;
            this.picRefresh.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // vTilesetScroll
            // 
            this.vTilesetScroll.Location = new System.Drawing.Point(414, 7);
            this.vTilesetScroll.Name = "vTilesetScroll";
            this.vTilesetScroll.Size = new System.Drawing.Size(20, 440);
            this.vTilesetScroll.TabIndex = 2;
            this.vTilesetScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vTilesetScroll_Scroll);
            // 
            // hTilesetScroll
            // 
            this.hTilesetScroll.Location = new System.Drawing.Point(153, 451);
            this.hTilesetScroll.Name = "hTilesetScroll";
            this.hTilesetScroll.Size = new System.Drawing.Size(256, 17);
            this.hTilesetScroll.TabIndex = 1;
            this.hTilesetScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hTilesetScroll_Scroll);
            // 
            // picTilesetViewer
            // 
            this.picTilesetViewer.BackColor = System.Drawing.Color.DarkGray;
            this.picTilesetViewer.Location = new System.Drawing.Point(153, 6);
            this.picTilesetViewer.Name = "picTilesetViewer";
            this.picTilesetViewer.Size = new System.Drawing.Size(256, 442);
            this.picTilesetViewer.TabIndex = 0;
            this.picTilesetViewer.TabStop = false;
            // 
            // tabAnimation
            // 
            this.tabAnimation.Location = new System.Drawing.Point(4, 22);
            this.tabAnimation.Name = "tabAnimation";
            this.tabAnimation.Size = new System.Drawing.Size(615, 475);
            this.tabAnimation.TabIndex = 2;
            this.tabAnimation.Text = "Animation";
            this.tabAnimation.UseVisualStyleBackColor = true;
            // 
            // tabFace
            // 
            this.tabFace.Controls.Add(this.vFaceScroll);
            this.tabFace.Controls.Add(this.hFaceScroll);
            this.tabFace.Controls.Add(this.lstFace);
            this.tabFace.Controls.Add(this.buttDeleteFace);
            this.tabFace.Controls.Add(this.buttAddFace);
            this.tabFace.Controls.Add(this.buttModifyFace);
            this.tabFace.Controls.Add(this.picFace);
            this.tabFace.Controls.Add(this.groupBox3);
            this.tabFace.Location = new System.Drawing.Point(4, 22);
            this.tabFace.Name = "tabFace";
            this.tabFace.Size = new System.Drawing.Size(615, 475);
            this.tabFace.TabIndex = 3;
            this.tabFace.Text = "Face";
            this.tabFace.UseVisualStyleBackColor = true;
            // 
            // chkAnimation
            // 
            this.chkAnimation.AutoSize = true;
            this.chkAnimation.Location = new System.Drawing.Point(189, 446);
            this.chkAnimation.Name = "chkAnimation";
            this.chkAnimation.Size = new System.Drawing.Size(70, 17);
            this.chkAnimation.TabIndex = 18;
            this.chkAnimation.Text = "Animate?";
            this.chkAnimation.UseVisualStyleBackColor = true;
            // 
            // picSpriteAnimation
            // 
            this.picSpriteAnimation.Location = new System.Drawing.Point(189, 289);
            this.picSpriteAnimation.Name = "picSpriteAnimation";
            this.picSpriteAnimation.Size = new System.Drawing.Size(136, 139);
            this.picSpriteAnimation.TabIndex = 17;
            this.picSpriteAnimation.TabStop = false;
            // 
            // tmrRefresher
            // 
            this.tmrRefresher.Interval = 180;
            this.tmrRefresher.Tick += new System.EventHandler(this.tmrRefresher_Tick);
            // 
            // vFaceScroll
            // 
            this.vFaceScroll.Location = new System.Drawing.Point(290, 12);
            this.vFaceScroll.Name = "vFaceScroll";
            this.vFaceScroll.Size = new System.Drawing.Size(20, 96);
            this.vFaceScroll.TabIndex = 26;
            // 
            // hFaceScroll
            // 
            this.hFaceScroll.Location = new System.Drawing.Point(191, 111);
            this.hFaceScroll.Name = "hFaceScroll";
            this.hFaceScroll.Size = new System.Drawing.Size(96, 17);
            this.hFaceScroll.TabIndex = 25;
            this.hFaceScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hFaceScroll_Scroll);
            // 
            // lstFace
            // 
            this.lstFace.FormattingEnabled = true;
            this.lstFace.Location = new System.Drawing.Point(19, 12);
            this.lstFace.Name = "lstFace";
            this.lstFace.Size = new System.Drawing.Size(157, 446);
            this.lstFace.TabIndex = 24;
            this.lstFace.SelectedIndexChanged += new System.EventHandler(this.lstFace_SelectedIndexChanged);
            // 
            // buttDeleteFace
            // 
            this.buttDeleteFace.Location = new System.Drawing.Point(547, 429);
            this.buttDeleteFace.Name = "buttDeleteFace";
            this.buttDeleteFace.Size = new System.Drawing.Size(51, 23);
            this.buttDeleteFace.TabIndex = 23;
            this.buttDeleteFace.Text = "Delete";
            this.buttDeleteFace.UseVisualStyleBackColor = true;
            // 
            // buttAddFace
            // 
            this.buttAddFace.Location = new System.Drawing.Point(433, 429);
            this.buttAddFace.Name = "buttAddFace";
            this.buttAddFace.Size = new System.Drawing.Size(51, 23);
            this.buttAddFace.TabIndex = 22;
            this.buttAddFace.Text = "Add";
            this.buttAddFace.UseVisualStyleBackColor = true;
            this.buttAddFace.Click += new System.EventHandler(this.buttAddFace_Click);
            // 
            // buttModifyFace
            // 
            this.buttModifyFace.Location = new System.Drawing.Point(490, 429);
            this.buttModifyFace.Name = "buttModifyFace";
            this.buttModifyFace.Size = new System.Drawing.Size(51, 23);
            this.buttModifyFace.TabIndex = 21;
            this.buttModifyFace.Text = "Modify";
            this.buttModifyFace.UseVisualStyleBackColor = true;
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.DarkGray;
            this.picFace.Location = new System.Drawing.Point(191, 12);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(96, 96);
            this.picFace.TabIndex = 20;
            this.picFace.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(313, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 153);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Face Property:";
            // 
            // GraphicDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 539);
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicDatabase";
            this.Text = "Graphic Database";
            this.Load += new System.EventHandler(this.GraphicDatabase_Load);
            this.groupBox1.ResumeLayout(false);
            this.TabGraphic.ResumeLayout(false);
            this.tabSprite.ResumeLayout(false);
            this.tabSprite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            this.tabTileset.ResumeLayout(false);
            this.grpTilesetProperty.ResumeLayout(false);
            this.grpTilesetProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTilesetViewer)).EndInit();
            this.tabFace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSpriteAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabGraphic;
        private System.Windows.Forms.TabPage tabSprite;
        private System.Windows.Forms.TabPage tabTileset;
        private System.Windows.Forms.PictureBox picTilesetViewer;
        private System.Windows.Forms.VScrollBar vTilesetScroll;
        private System.Windows.Forms.HScrollBar hTilesetScroll;
        private System.Windows.Forms.TabPage tabAnimation;
        private System.Windows.Forms.GroupBox grpTilesetProperty;
        private System.Windows.Forms.Label lblEditting;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button buttDelete;
        private System.Windows.Forms.Button buttAddTileset;
        private System.Windows.Forms.Button buttModifyTileset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabFace;
        private System.Windows.Forms.VScrollBar vSpriteScroll;
        private System.Windows.Forms.HScrollBar hSpriteScroll;
        private System.Windows.Forms.ListBox lstSprite;
        private System.Windows.Forms.Button buttDeleteSprite;
        private System.Windows.Forms.Button buttAddSprite;
        private System.Windows.Forms.Button buttModifySprite;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.ListBox lstTileset;
        private System.Windows.Forms.CheckBox chkAnimation;
        private System.Windows.Forms.PictureBox picSpriteAnimation;
        private System.Windows.Forms.Timer tmrRefresher;
        private System.Windows.Forms.VScrollBar vFaceScroll;
        private System.Windows.Forms.HScrollBar hFaceScroll;
        private System.Windows.Forms.ListBox lstFace;
        private System.Windows.Forms.Button buttDeleteFace;
        private System.Windows.Forms.Button buttAddFace;
        private System.Windows.Forms.Button buttModifyFace;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}