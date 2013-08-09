namespace JackieRPG
{
    partial class NewWarp
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWarpY = new System.Windows.Forms.TextBox();
            this.txtWarpX = new System.Windows.Forms.TextBox();
            this.txtWarpMap = new System.Windows.Forms.TextBox();
            this.lblMapY = new System.Windows.Forms.Label();
            this.lblMapX = new System.Windows.Forms.Label();
            this.lblWarpMap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(10, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(91, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWarpY);
            this.groupBox1.Controls.Add(this.txtWarpX);
            this.groupBox1.Controls.Add(this.txtWarpMap);
            this.groupBox1.Controls.Add(this.lblMapY);
            this.groupBox1.Controls.Add(this.lblMapX);
            this.groupBox1.Controls.Add(this.lblWarpMap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property:";
            // 
            // txtWarpY
            // 
            this.txtWarpY.Location = new System.Drawing.Point(80, 67);
            this.txtWarpY.Name = "txtWarpY";
            this.txtWarpY.Size = new System.Drawing.Size(60, 20);
            this.txtWarpY.TabIndex = 5;
            // 
            // txtWarpX
            // 
            this.txtWarpX.Location = new System.Drawing.Point(80, 45);
            this.txtWarpX.Name = "txtWarpX";
            this.txtWarpX.Size = new System.Drawing.Size(60, 20);
            this.txtWarpX.TabIndex = 4;
            // 
            // txtWarpMap
            // 
            this.txtWarpMap.Location = new System.Drawing.Point(80, 23);
            this.txtWarpMap.Name = "txtWarpMap";
            this.txtWarpMap.Size = new System.Drawing.Size(60, 20);
            this.txtWarpMap.TabIndex = 3;
            // 
            // lblMapY
            // 
            this.lblMapY.AutoSize = true;
            this.lblMapY.Location = new System.Drawing.Point(13, 70);
            this.lblMapY.Name = "lblMapY";
            this.lblMapY.Size = new System.Drawing.Size(46, 13);
            this.lblMapY.TabIndex = 2;
            this.lblMapY.Text = "Warp Y:";
            // 
            // lblMapX
            // 
            this.lblMapX.AutoSize = true;
            this.lblMapX.Location = new System.Drawing.Point(13, 48);
            this.lblMapX.Name = "lblMapX";
            this.lblMapX.Size = new System.Drawing.Size(46, 13);
            this.lblMapX.TabIndex = 1;
            this.lblMapX.Text = "Warp X:";
            // 
            // lblWarpMap
            // 
            this.lblWarpMap.AutoSize = true;
            this.lblWarpMap.Location = new System.Drawing.Point(13, 26);
            this.lblWarpMap.Name = "lblWarpMap";
            this.lblWarpMap.Size = new System.Drawing.Size(60, 13);
            this.lblWarpMap.TabIndex = 0;
            this.lblWarpMap.Text = "Warp Map:";
            // 
            // NewWarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 161);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewWarp";
            this.Text = "NewWarp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWarpY;
        private System.Windows.Forms.TextBox txtWarpX;
        private System.Windows.Forms.TextBox txtWarpMap;
        private System.Windows.Forms.Label lblMapY;
        private System.Windows.Forms.Label lblMapX;
        private System.Windows.Forms.Label lblWarpMap;
    }
}