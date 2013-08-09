namespace JackieRPG
{
    partial class NewEvent
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttVariable = new System.Windows.Forms.Button();
            this.buttSwitch = new System.Windows.Forms.Button();
            this.buttWarp = new System.Windows.Forms.Button();
            this.buttConditioner = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttVariable);
            this.tabPage1.Controls.Add(this.buttSwitch);
            this.tabPage1.Controls.Add(this.buttWarp);
            this.tabPage1.Controls.Add(this.buttConditioner);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttVariable
            // 
            this.buttVariable.Location = new System.Drawing.Point(15, 115);
            this.buttVariable.Name = "buttVariable";
            this.buttVariable.Size = new System.Drawing.Size(82, 26);
            this.buttVariable.TabIndex = 3;
            this.buttVariable.Text = "Variable";
            this.buttVariable.UseVisualStyleBackColor = true;
            this.buttVariable.Click += new System.EventHandler(this.buttVariable_Click);
            // 
            // buttSwitch
            // 
            this.buttSwitch.Location = new System.Drawing.Point(15, 83);
            this.buttSwitch.Name = "buttSwitch";
            this.buttSwitch.Size = new System.Drawing.Size(82, 26);
            this.buttSwitch.TabIndex = 2;
            this.buttSwitch.Text = "Switch";
            this.buttSwitch.UseVisualStyleBackColor = true;
            this.buttSwitch.Click += new System.EventHandler(this.buttSwitch_Click);
            // 
            // buttWarp
            // 
            this.buttWarp.Location = new System.Drawing.Point(15, 51);
            this.buttWarp.Name = "buttWarp";
            this.buttWarp.Size = new System.Drawing.Size(82, 26);
            this.buttWarp.TabIndex = 1;
            this.buttWarp.Text = "Warp";
            this.buttWarp.UseVisualStyleBackColor = true;
            this.buttWarp.Click += new System.EventHandler(this.buttWarp_Click);
            // 
            // buttConditioner
            // 
            this.buttConditioner.Location = new System.Drawing.Point(15, 19);
            this.buttConditioner.Name = "buttConditioner";
            this.buttConditioner.Size = new System.Drawing.Size(82, 26);
            this.buttConditioner.TabIndex = 0;
            this.buttConditioner.Text = "Conditioner";
            this.buttConditioner.UseVisualStyleBackColor = true;
            this.buttConditioner.Click += new System.EventHandler(this.buttConditioner_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(381, 522);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Map";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewEvent";
            this.Text = "NewEvent";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttConditioner;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttWarp;
        private System.Windows.Forms.Button buttVariable;
        private System.Windows.Forms.Button buttSwitch;
    }
}