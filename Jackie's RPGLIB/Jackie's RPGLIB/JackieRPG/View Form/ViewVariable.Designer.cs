namespace JackieRPG
{
    partial class ViewVariable
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
            this.buttAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVariable = new System.Windows.Forms.ListBox();
            this.buttRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttAdd
            // 
            this.buttAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttAdd.Location = new System.Drawing.Point(13, 374);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(75, 27);
            this.buttAdd.TabIndex = 23;
            this.buttAdd.Text = "Add";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVariable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 356);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable Property:";
            // 
            // lstVariable
            // 
            this.lstVariable.FormattingEnabled = true;
            this.lstVariable.Location = new System.Drawing.Point(6, 19);
            this.lstVariable.Name = "lstVariable";
            this.lstVariable.Size = new System.Drawing.Size(145, 329);
            this.lstVariable.TabIndex = 1;
            this.lstVariable.SelectedIndexChanged += new System.EventHandler(this.lstVariable_SelectedIndexChanged);
            // 
            // buttRemove
            // 
            this.buttRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttRemove.Location = new System.Drawing.Point(94, 374);
            this.buttRemove.Name = "buttRemove";
            this.buttRemove.Size = new System.Drawing.Size(75, 27);
            this.buttRemove.TabIndex = 24;
            this.buttRemove.Text = "Remove";
            this.buttRemove.UseVisualStyleBackColor = true;
            // 
            // ViewVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 405);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttRemove);
            this.Name = "ViewVariable";
            this.Text = "ViewVariable";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstVariable;
        private System.Windows.Forms.Button buttRemove;
    }
}