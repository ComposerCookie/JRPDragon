namespace JackieRPG
{
    partial class NewActor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasicInformation = new System.Windows.Forms.TabPage();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tmrRender = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBasicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actor Property:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasicInformation);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBasicInformation
            // 
            this.tabBasicInformation.Controls.Add(this.cmbGender);
            this.tabBasicInformation.Controls.Add(this.label6);
            this.tabBasicInformation.Controls.Add(this.txtEXPModifier);
            this.tabBasicInformation.Controls.Add(this.label5);
            this.tabBasicInformation.Controls.Add(this.txtBaseLevel);
            this.tabBasicInformation.Controls.Add(this.label4);
            this.tabBasicInformation.Controls.Add(this.picSprite);
            this.tabBasicInformation.Controls.Add(this.picFace);
            this.tabBasicInformation.Controls.Add(this.txtName);
            this.tabBasicInformation.Controls.Add(this.cmbClass);
            this.tabBasicInformation.Controls.Add(this.txtDescription);
            this.tabBasicInformation.Controls.Add(this.label3);
            this.tabBasicInformation.Controls.Add(this.label2);
            this.tabBasicInformation.Controls.Add(this.label1);
            this.tabBasicInformation.Location = new System.Drawing.Point(4, 22);
            this.tabBasicInformation.Name = "tabBasicInformation";
            this.tabBasicInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicInformation.Size = new System.Drawing.Size(438, 334);
            this.tabBasicInformation.TabIndex = 0;
            this.tabBasicInformation.Text = "Basic Information";
            this.tabBasicInformation.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(238, 274);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(81, 21);
            this.cmbGender.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Gender:";
            // 
            // txtEXPModifier
            // 
            this.txtEXPModifier.Location = new System.Drawing.Point(89, 303);
            this.txtEXPModifier.Name = "txtEXPModifier";
            this.txtEXPModifier.Size = new System.Drawing.Size(72, 20);
            this.txtEXPModifier.TabIndex = 25;
            this.txtEXPModifier.Text = "100";
            this.txtEXPModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "EXP Modifer:";
            // 
            // txtBaseLevel
            // 
            this.txtBaseLevel.Location = new System.Drawing.Point(89, 274);
            this.txtBaseLevel.Name = "txtBaseLevel";
            this.txtBaseLevel.Size = new System.Drawing.Size(72, 20);
            this.txtBaseLevel.TabIndex = 23;
            this.txtBaseLevel.Text = "1";
            this.txtBaseLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Base Level:";
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.DarkGray;
            this.picSprite.Location = new System.Drawing.Point(325, 132);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(96, 128);
            this.picSprite.TabIndex = 21;
            this.picSprite.TabStop = false;
            this.picSprite.Click += new System.EventHandler(this.picSprite_Click);
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.DarkGray;
            this.picFace.Location = new System.Drawing.Point(325, 17);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(96, 96);
            this.picFace.TabIndex = 20;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "Actor1";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(89, 43);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(230, 21);
            this.cmbClass.TabIndex = 18;
            this.cmbClass.Text = "Novice";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(89, 73);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 187);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "Actor1 is the default actor created for teh lulz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Class: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(331, 404);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(412, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tmrRender
            // 
            this.tmrRender.Tick += new System.EventHandler(this.tmrRender_Tick);
            // 
            // NewActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 434);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewActor";
            this.Text = "New Actor";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBasicInformation.ResumeLayout(false);
            this.tabBasicInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasicInformation;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEXPModifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaseLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrRender;
    }
}