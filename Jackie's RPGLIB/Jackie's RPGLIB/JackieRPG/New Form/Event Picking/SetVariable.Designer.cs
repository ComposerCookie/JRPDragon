namespace JackieRPG
{
    partial class SetVariable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstVariable = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbRem = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbSet = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 415);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch Property:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstVariable);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(11, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 151);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Which Switch:";
            // 
            // lstVariable
            // 
            this.lstVariable.FormattingEnabled = true;
            this.lstVariable.Location = new System.Drawing.Point(67, 19);
            this.lstVariable.Name = "lstVariable";
            this.lstVariable.Size = new System.Drawing.Size(103, 121);
            this.lstVariable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Switch:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRem);
            this.groupBox2.Controls.Add(this.rdbDiv);
            this.groupBox2.Controls.Add(this.rdbMul);
            this.groupBox2.Controls.Add(this.rdbSub);
            this.groupBox2.Controls.Add(this.rdbAdd);
            this.groupBox2.Controls.Add(this.rdbSet);
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Location = new System.Drawing.Point(9, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification:";
            // 
            // rdbRem
            // 
            this.rdbRem.AutoSize = true;
            this.rdbRem.Location = new System.Drawing.Point(16, 144);
            this.rdbRem.Name = "rdbRem";
            this.rdbRem.Size = new System.Drawing.Size(79, 17);
            this.rdbRem.TabIndex = 9;
            this.rdbRem.TabStop = true;
            this.rdbRem.Text = "Remainder:";
            this.rdbRem.UseVisualStyleBackColor = true;
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(16, 121);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(65, 17);
            this.rdbDiv.TabIndex = 8;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "Division:";
            this.rdbDiv.UseVisualStyleBackColor = true;
            // 
            // rdbMul
            // 
            this.rdbMul.AutoSize = true;
            this.rdbMul.Location = new System.Drawing.Point(16, 98);
            this.rdbMul.Name = "rdbMul";
            this.rdbMul.Size = new System.Drawing.Size(63, 17);
            this.rdbMul.TabIndex = 7;
            this.rdbMul.TabStop = true;
            this.rdbMul.Text = "Multiply:";
            this.rdbMul.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(16, 75);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(68, 17);
            this.rdbSub.TabIndex = 6;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Subtract:";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(16, 52);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(47, 17);
            this.rdbAdd.TabIndex = 5;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add:";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbSet
            // 
            this.rdbSet.AutoSize = true;
            this.rdbSet.Location = new System.Drawing.Point(16, 29);
            this.rdbSet.Name = "rdbSet";
            this.rdbSet.Size = new System.Drawing.Size(74, 17);
            this.rdbSet.TabIndex = 4;
            this.rdbSet.TabStop = true;
            this.rdbSet.Text = "Set Value:";
            this.rdbSet.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(121, 72);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(51, 20);
            this.txtValue.TabIndex = 3;
            this.txtValue.Text = "0";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(37, 433);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(118, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SetVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "SetVariable";
            this.Text = "SetVariable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbRem;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbMul;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.RadioButton rdbSet;
    }
}