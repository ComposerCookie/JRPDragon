namespace JackieRPG
{
    partial class NewConditioner
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
            this.txtReqY = new System.Windows.Forms.TextBox();
            this.txtReqX = new System.Windows.Forms.TextBox();
            this.txtReqMap = new System.Windows.Forms.TextBox();
            this.lblReqY = new System.Windows.Forms.Label();
            this.lblReqX = new System.Windows.Forms.Label();
            this.lblReqMap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkConditionerType = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRequiredVariable = new System.Windows.Forms.Label();
            this.lblReqVarValue = new System.Windows.Forms.Label();
            this.txtReqVarValue = new System.Windows.Forms.TextBox();
            this.lblReqSwitch = new System.Windows.Forms.Label();
            this.lblReqSwiValue = new System.Windows.Forms.Label();
            this.cmbSwitchValue = new System.Windows.Forms.ComboBox();
            this.lstVariable = new System.Windows.Forms.ListBox();
            this.lstSwitch = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSwitch);
            this.groupBox1.Controls.Add(this.lstVariable);
            this.groupBox1.Controls.Add(this.cmbSwitchValue);
            this.groupBox1.Controls.Add(this.lblReqSwiValue);
            this.groupBox1.Controls.Add(this.lblReqSwitch);
            this.groupBox1.Controls.Add(this.txtReqVarValue);
            this.groupBox1.Controls.Add(this.lblReqVarValue);
            this.groupBox1.Controls.Add(this.lblRequiredVariable);
            this.groupBox1.Controls.Add(this.txtReqY);
            this.groupBox1.Controls.Add(this.txtReqX);
            this.groupBox1.Controls.Add(this.txtReqMap);
            this.groupBox1.Controls.Add(this.lblReqY);
            this.groupBox1.Controls.Add(this.lblReqX);
            this.groupBox1.Controls.Add(this.lblReqMap);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property:";
            // 
            // txtReqY
            // 
            this.txtReqY.Location = new System.Drawing.Point(96, 67);
            this.txtReqY.Name = "txtReqY";
            this.txtReqY.Size = new System.Drawing.Size(129, 20);
            this.txtReqY.TabIndex = 5;
            this.txtReqY.Text = "0";
            this.txtReqY.Visible = false;
            // 
            // txtReqX
            // 
            this.txtReqX.Location = new System.Drawing.Point(96, 45);
            this.txtReqX.Name = "txtReqX";
            this.txtReqX.Size = new System.Drawing.Size(129, 20);
            this.txtReqX.TabIndex = 4;
            this.txtReqX.Text = "0";
            this.txtReqX.Visible = false;
            // 
            // txtReqMap
            // 
            this.txtReqMap.Location = new System.Drawing.Point(96, 23);
            this.txtReqMap.Name = "txtReqMap";
            this.txtReqMap.Size = new System.Drawing.Size(129, 20);
            this.txtReqMap.TabIndex = 3;
            this.txtReqMap.Text = "0";
            this.txtReqMap.Visible = false;
            // 
            // lblReqY
            // 
            this.lblReqY.AutoSize = true;
            this.lblReqY.Location = new System.Drawing.Point(13, 70);
            this.lblReqY.Name = "lblReqY";
            this.lblReqY.Size = new System.Drawing.Size(77, 13);
            this.lblReqY.TabIndex = 2;
            this.lblReqY.Text = "Required Map:";
            this.lblReqY.Visible = false;
            // 
            // lblReqX
            // 
            this.lblReqX.AutoSize = true;
            this.lblReqX.Location = new System.Drawing.Point(13, 48);
            this.lblReqX.Name = "lblReqX";
            this.lblReqX.Size = new System.Drawing.Size(77, 13);
            this.lblReqX.TabIndex = 1;
            this.lblReqX.Text = "Required Map:";
            this.lblReqX.Visible = false;
            // 
            // lblReqMap
            // 
            this.lblReqMap.AutoSize = true;
            this.lblReqMap.Location = new System.Drawing.Point(13, 26);
            this.lblReqMap.Name = "lblReqMap";
            this.lblReqMap.Size = new System.Drawing.Size(77, 13);
            this.lblReqMap.TabIndex = 0;
            this.lblReqMap.Text = "Required Map:";
            this.lblReqMap.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkConditionerType);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conditioner Type:";
            // 
            // chkConditionerType
            // 
            this.chkConditionerType.FormattingEnabled = true;
            this.chkConditionerType.Items.AddRange(new object[] {
            "Location",
            "Variable",
            "Switch"});
            this.chkConditionerType.Location = new System.Drawing.Point(118, 19);
            this.chkConditionerType.Name = "chkConditionerType";
            this.chkConditionerType.Size = new System.Drawing.Size(172, 21);
            this.chkConditionerType.TabIndex = 2;
            this.chkConditionerType.Text = "Pick one";
            this.chkConditionerType.SelectedIndexChanged += new System.EventHandler(this.chkConditionerType_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(162, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(243, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblRequiredVariable
            // 
            this.lblRequiredVariable.AutoSize = true;
            this.lblRequiredVariable.Location = new System.Drawing.Point(13, 26);
            this.lblRequiredVariable.Name = "lblRequiredVariable";
            this.lblRequiredVariable.Size = new System.Drawing.Size(94, 13);
            this.lblRequiredVariable.TabIndex = 6;
            this.lblRequiredVariable.Text = "Required Variable:";
            this.lblRequiredVariable.Visible = false;
            // 
            // lblReqVarValue
            // 
            this.lblReqVarValue.AutoSize = true;
            this.lblReqVarValue.Location = new System.Drawing.Point(13, 110);
            this.lblReqVarValue.Name = "lblReqVarValue";
            this.lblReqVarValue.Size = new System.Drawing.Size(83, 13);
            this.lblReqVarValue.TabIndex = 8;
            this.lblReqVarValue.Text = "Required Value:";
            this.lblReqVarValue.Visible = false;
            // 
            // txtReqVarValue
            // 
            this.txtReqVarValue.Location = new System.Drawing.Point(110, 107);
            this.txtReqVarValue.Name = "txtReqVarValue";
            this.txtReqVarValue.Size = new System.Drawing.Size(115, 20);
            this.txtReqVarValue.TabIndex = 9;
            this.txtReqVarValue.Text = "0";
            this.txtReqVarValue.Visible = false;
            // 
            // lblReqSwitch
            // 
            this.lblReqSwitch.AutoSize = true;
            this.lblReqSwitch.Location = new System.Drawing.Point(13, 26);
            this.lblReqSwitch.Name = "lblReqSwitch";
            this.lblReqSwitch.Size = new System.Drawing.Size(85, 13);
            this.lblReqSwitch.TabIndex = 10;
            this.lblReqSwitch.Text = "Required Switch";
            this.lblReqSwitch.Visible = false;
            // 
            // lblReqSwiValue
            // 
            this.lblReqSwiValue.AutoSize = true;
            this.lblReqSwiValue.Location = new System.Drawing.Point(13, 110);
            this.lblReqSwiValue.Name = "lblReqSwiValue";
            this.lblReqSwiValue.Size = new System.Drawing.Size(83, 13);
            this.lblReqSwiValue.TabIndex = 11;
            this.lblReqSwiValue.Text = "Required Value:";
            this.lblReqSwiValue.Visible = false;
            // 
            // cmbSwitchValue
            // 
            this.cmbSwitchValue.FormattingEnabled = true;
            this.cmbSwitchValue.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbSwitchValue.Location = new System.Drawing.Point(110, 107);
            this.cmbSwitchValue.Name = "cmbSwitchValue";
            this.cmbSwitchValue.Size = new System.Drawing.Size(115, 21);
            this.cmbSwitchValue.TabIndex = 13;
            this.cmbSwitchValue.Text = "True";
            // 
            // lstVariable
            // 
            this.lstVariable.FormattingEnabled = true;
            this.lstVariable.Location = new System.Drawing.Point(113, 23);
            this.lstVariable.Name = "lstVariable";
            this.lstVariable.Size = new System.Drawing.Size(112, 69);
            this.lstVariable.TabIndex = 14;
            this.lstVariable.Visible = false;
            // 
            // lstSwitch
            // 
            this.lstSwitch.FormattingEnabled = true;
            this.lstSwitch.Location = new System.Drawing.Point(113, 23);
            this.lstSwitch.Name = "lstSwitch";
            this.lstSwitch.Size = new System.Drawing.Size(112, 69);
            this.lstSwitch.TabIndex = 15;
            this.lstSwitch.Visible = false;
            // 
            // NewConditioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 251);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewConditioner";
            this.Text = "NewConditioner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chkConditionerType;
        private System.Windows.Forms.TextBox txtReqY;
        private System.Windows.Forms.TextBox txtReqX;
        private System.Windows.Forms.TextBox txtReqMap;
        private System.Windows.Forms.Label lblReqY;
        private System.Windows.Forms.Label lblReqX;
        private System.Windows.Forms.Label lblReqMap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRequiredVariable;
        private System.Windows.Forms.Label lblReqSwiValue;
        private System.Windows.Forms.Label lblReqSwitch;
        private System.Windows.Forms.TextBox txtReqVarValue;
        private System.Windows.Forms.Label lblReqVarValue;
        private System.Windows.Forms.ComboBox cmbSwitchValue;
        private System.Windows.Forms.ListBox lstSwitch;
        private System.Windows.Forms.ListBox lstVariable;
    }
}