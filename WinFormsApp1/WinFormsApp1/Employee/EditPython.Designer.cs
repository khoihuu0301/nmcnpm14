namespace WinFormsApp1.Employee
{
    partial class EditPython
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPython));
            this.panel4 = new System.Windows.Forms.Panel();
            this.addlbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserRealName = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.managerpic = new System.Windows.Forms.PictureBox();
            this.managernamelbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dc1lbl = new System.Windows.Forms.Label();
            this.pythonlbl = new System.Windows.Forms.Label();
            this.editpic = new System.Windows.Forms.PictureBox();
            this.deletepic = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.viewstudentlbl = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerpic)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletepic)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addlbl);
            this.panel4.Location = new System.Drawing.Point(381, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 61);
            this.panel4.TabIndex = 0;
            // 
            // addlbl
            // 
            this.addlbl.AutoSize = true;
            this.addlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addlbl.Location = new System.Drawing.Point(19, 18);
            this.addlbl.Name = "addlbl";
            this.addlbl.Size = new System.Drawing.Size(129, 28);
            this.addlbl.TabIndex = 14;
            this.addlbl.Text = "Add Courses";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewlbl);
            this.panel3.Location = new System.Drawing.Point(72, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 61);
            this.panel3.TabIndex = 17;
            // 
            // viewlbl
            // 
            this.viewlbl.AutoSize = true;
            this.viewlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewlbl.Location = new System.Drawing.Point(19, 18);
            this.viewlbl.Name = "viewlbl";
            this.viewlbl.Size = new System.Drawing.Size(137, 28);
            this.viewlbl.TabIndex = 0;
            this.viewlbl.Text = "View Courses";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(198, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 109);
            this.panel2.TabIndex = 18;
            // 
            // UserRealName
            // 
            this.UserRealName.AutoSize = true;
            this.UserRealName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserRealName.Location = new System.Drawing.Point(1134, 8);
            this.UserRealName.Name = "UserRealName";
            this.UserRealName.Size = new System.Drawing.Size(42, 28);
            this.UserRealName.TabIndex = 1;
            this.UserRealName.Text = "Me";
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(1204, 8);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(31, 27);
            this.Avatar.TabIndex = 3;
            this.Avatar.TabStop = false;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(490, 11);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(606, 23);
            this.searchtxt.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.Avatar);
            this.panel1.Controls.Add(this.UserRealName);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 47);
            this.panel1.TabIndex = 14;
            // 
            // managerpic
            // 
            this.managerpic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.managerpic.Image = ((System.Drawing.Image)(resources.GetObject("managerpic.Image")));
            this.managerpic.Location = new System.Drawing.Point(9, 7);
            this.managerpic.Name = "managerpic";
            this.managerpic.Size = new System.Drawing.Size(40, 40);
            this.managerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.managerpic.TabIndex = 0;
            this.managerpic.TabStop = false;
            // 
            // managernamelbl
            // 
            this.managernamelbl.AutoSize = true;
            this.managernamelbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.managernamelbl.Location = new System.Drawing.Point(55, 19);
            this.managernamelbl.Name = "managernamelbl";
            this.managernamelbl.Size = new System.Drawing.Size(96, 28);
            this.managernamelbl.TabIndex = 1;
            this.managernamelbl.Text = "Manager";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.managernamelbl);
            this.panel5.Controls.Add(this.managerpic);
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 642);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.deletepic);
            this.panel6.Controls.Add(this.editpic);
            this.panel6.Controls.Add(this.dc1lbl);
            this.panel6.Controls.Add(this.pythonlbl);
            this.panel6.Location = new System.Drawing.Point(270, 216);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(503, 94);
            this.panel6.TabIndex = 36;
            // 
            // dc1lbl
            // 
            this.dc1lbl.AutoSize = true;
            this.dc1lbl.Location = new System.Drawing.Point(25, 72);
            this.dc1lbl.Name = "dc1lbl";
            this.dc1lbl.Size = new System.Drawing.Size(307, 15);
            this.dc1lbl.TabIndex = 31;
            this.dc1lbl.Text = "Easy, Python (Basic), Max Score: 10, Success Rate: 90.97%\r\n";
            // 
            // pythonlbl
            // 
            this.pythonlbl.AutoSize = true;
            this.pythonlbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pythonlbl.Location = new System.Drawing.Point(25, 16);
            this.pythonlbl.Name = "pythonlbl";
            this.pythonlbl.Size = new System.Drawing.Size(121, 25);
            this.pythonlbl.TabIndex = 0;
            this.pythonlbl.Text = "Python If-Else";
            // 
            // editpic
            // 
            this.editpic.Image = ((System.Drawing.Image)(resources.GetObject("editpic.Image")));
            this.editpic.Location = new System.Drawing.Point(399, 11);
            this.editpic.Name = "editpic";
            this.editpic.Size = new System.Drawing.Size(30, 30);
            this.editpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editpic.TabIndex = 33;
            this.editpic.TabStop = false;
            // 
            // deletepic
            // 
            this.deletepic.Image = ((System.Drawing.Image)(resources.GetObject("deletepic.Image")));
            this.deletepic.Location = new System.Drawing.Point(457, 11);
            this.deletepic.Name = "deletepic";
            this.deletepic.Size = new System.Drawing.Size(30, 30);
            this.deletepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletepic.TabIndex = 34;
            this.deletepic.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.viewstudentlbl);
            this.panel7.Location = new System.Drawing.Point(698, 48);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 61);
            this.panel7.TabIndex = 37;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // viewstudentlbl
            // 
            this.viewstudentlbl.AutoSize = true;
            this.viewstudentlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewstudentlbl.Location = new System.Drawing.Point(19, 18);
            this.viewstudentlbl.Name = "viewstudentlbl";
            this.viewstudentlbl.Size = new System.Drawing.Size(138, 28);
            this.viewstudentlbl.TabIndex = 0;
            this.viewstudentlbl.Text = "View Student";
            // 
            // EditPython
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "EditPython";
            this.Text = "EditPython";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerpic)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletepic)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label addlbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label viewlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserRealName;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox managerpic;
        private System.Windows.Forms.Label managernamelbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox deletepic;
        private System.Windows.Forms.PictureBox editpic;
        private System.Windows.Forms.Label dc1lbl;
        private System.Windows.Forms.Label pythonlbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label viewstudentlbl;
    }
}