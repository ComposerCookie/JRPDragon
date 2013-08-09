namespace JackieRPG
{
    partial class ActorManagerForm
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
            this.lstActor = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabActor = new System.Windows.Forms.TabControl();
            this.tabActorBasic = new System.Windows.Forms.TabPage();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAnimation = new System.Windows.Forms.CheckBox();
            this.picAnimation = new System.Windows.Forms.PictureBox();
            this.txtEXPModifier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaseLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addButt = new System.Windows.Forms.Button();
            this.removeButt = new System.Windows.Forms.Button();
            this.buttUpdate = new System.Windows.Forms.Button();
            this.tmrAnimationRefresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabActor.SuspendLayout();
            this.tabActorBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstActor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actor List:";
            // 
            // lstActor
            // 
            this.lstActor.FormattingEnabled = true;
            this.lstActor.Location = new System.Drawing.Point(6, 19);
            this.lstActor.Name = "lstActor";
            this.lstActor.Size = new System.Drawing.Size(129, 368);
            this.lstActor.TabIndex = 0;
            this.lstActor.SelectedIndexChanged += new System.EventHandler(this.lstActor_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabActor);
            this.groupBox2.Location = new System.Drawing.Point(159, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actor Property:";
            // 
            // tabActor
            // 
            this.tabActor.Controls.Add(this.tabActorBasic);
            this.tabActor.Controls.Add(this.tabPage2);
            this.tabActor.Location = new System.Drawing.Point(10, 19);
            this.tabActor.Name = "tabActor";
            this.tabActor.SelectedIndex = 0;
            this.tabActor.Size = new System.Drawing.Size(447, 368);
            this.tabActor.TabIndex = 0;
            // 
            // tabActorBasic
            // 
            this.tabActorBasic.Controls.Add(this.cmbGender);
            this.tabActorBasic.Controls.Add(this.label6);
            this.tabActorBasic.Controls.Add(this.chkAnimation);
            this.tabActorBasic.Controls.Add(this.picAnimation);
            this.tabActorBasic.Controls.Add(this.txtEXPModifier);
            this.tabActorBasic.Controls.Add(this.label5);
            this.tabActorBasic.Controls.Add(this.txtBaseLevel);
            this.tabActorBasic.Controls.Add(this.label4);
            this.tabActorBasic.Controls.Add(this.picSprite);
            this.tabActorBasic.Controls.Add(this.picFace);
            this.tabActorBasic.Controls.Add(this.txtName);
            this.tabActorBasic.Controls.Add(this.cmbClass);
            this.tabActorBasic.Controls.Add(this.txtDescription);
            this.tabActorBasic.Controls.Add(this.label3);
            this.tabActorBasic.Controls.Add(this.label2);
            this.tabActorBasic.Controls.Add(this.label1);
            this.tabActorBasic.Location = new System.Drawing.Point(4, 22);
            this.tabActorBasic.Name = "tabActorBasic";
            this.tabActorBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabActorBasic.Size = new System.Drawing.Size(439, 342);
            this.tabActorBasic.TabIndex = 0;
            this.tabActorBasic.Text = "Basic Information";
            this.tabActorBasic.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(216, 276);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(81, 21);
            this.cmbGender.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gender:";
            // 
            // chkAnimation
            // 
            this.chkAnimation.AutoSize = true;
            this.chkAnimation.Location = new System.Drawing.Point(315, 277);
            this.chkAnimation.Name = "chkAnimation";
            this.chkAnimation.Size = new System.Drawing.Size(70, 17);
            this.chkAnimation.TabIndex = 15;
            this.chkAnimation.Text = "Animate?";
            this.chkAnimation.UseVisualStyleBackColor = true;
            // 
            // picAnimation
            // 
            this.picAnimation.Location = new System.Drawing.Point(391, 276);
            this.picAnimation.Name = "picAnimation";
            this.picAnimation.Size = new System.Drawing.Size(32, 32);
            this.picAnimation.TabIndex = 14;
            this.picAnimation.TabStop = false;
            // 
            // txtEXPModifier
            // 
            this.txtEXPModifier.Location = new System.Drawing.Point(91, 305);
            this.txtEXPModifier.Name = "txtEXPModifier";
            this.txtEXPModifier.Size = new System.Drawing.Size(68, 20);
            this.txtEXPModifier.TabIndex = 13;
            this.txtEXPModifier.Text = "100";
            this.txtEXPModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "EXP Modifer:";
            // 
            // txtBaseLevel
            // 
            this.txtBaseLevel.Location = new System.Drawing.Point(91, 276);
            this.txtBaseLevel.Name = "txtBaseLevel";
            this.txtBaseLevel.Size = new System.Drawing.Size(68, 20);
            this.txtBaseLevel.TabIndex = 11;
            this.txtBaseLevel.Text = "1";
            this.txtBaseLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Base Level:";
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.DarkGray;
            this.picSprite.Location = new System.Drawing.Point(327, 134);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(96, 128);
            this.picSprite.TabIndex = 9;
            this.picSprite.TabStop = false;
            this.picSprite.Click += new System.EventHandler(this.picSprite_Click);
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.DarkGray;
            this.picFace.Location = new System.Drawing.Point(327, 19);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(96, 96);
            this.picFace.TabIndex = 7;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Actor1";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(91, 45);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(230, 21);
            this.cmbClass.TabIndex = 4;
            this.cmbClass.Text = "Novice";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 75);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 187);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "Actor1 is the default actor created for teh lulz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(12, 414);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(68, 24);
            this.addButt.TabIndex = 2;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // removeButt
            // 
            this.removeButt.Location = new System.Drawing.Point(86, 414);
            this.removeButt.Name = "removeButt";
            this.removeButt.Size = new System.Drawing.Size(68, 24);
            this.removeButt.TabIndex = 3;
            this.removeButt.Text = "Remove";
            this.removeButt.UseVisualStyleBackColor = true;
            // 
            // buttUpdate
            // 
            this.buttUpdate.Location = new System.Drawing.Point(544, 415);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(68, 24);
            this.buttUpdate.TabIndex = 6;
            this.buttUpdate.Text = "Update";
            this.buttUpdate.UseVisualStyleBackColor = true;
            // 
            // tmrAnimationRefresh
            // 
            this.tmrAnimationRefresh.Tick += new System.EventHandler(this.tmrAnimationRefresh_Tick);
            // 
            // ActorManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 448);
            this.Controls.Add(this.removeButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttUpdate);
            this.Name = "ActorManagerForm";
            this.Text = "Actor Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabActor.ResumeLayout(false);
            this.tabActorBasic.ResumeLayout(false);
            this.tabActorBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstActor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabActor;
        private System.Windows.Forms.TabPage tabActorBasic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button removeButt;
        private System.Windows.Forms.Button buttUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.TextBox txtEXPModifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaseLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAnimation;
        private System.Windows.Forms.PictureBox picAnimation;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrAnimationRefresh;
    }
}