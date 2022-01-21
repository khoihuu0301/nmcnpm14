namespace WinFormsApp1.Employee
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.UserRealName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.managernamelbl = new System.Windows.Forms.Label();
            this.managerpic = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pythonpic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addlbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewlbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.viewstudentlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pythonpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.Avatar);
            this.panel1.Controls.Add(this.UserRealName);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 47);
            this.panel1.TabIndex = 1;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(490, 11);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(606, 23);
            this.searchtxt.TabIndex = 15;
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(1204, 8);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(31, 27);
            this.Avatar.TabIndex = 3;
            this.Avatar.TabStop = false;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.managernamelbl);
            this.panel5.Controls.Add(this.managerpic);
            this.panel5.Location = new System.Drawing.Point(3, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 642);
            this.panel5.TabIndex = 5;
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
            // pythonpic
            // 
            this.pythonpic.Image = ((System.Drawing.Image)(resources.GetObject("pythonpic.Image")));
            this.pythonpic.Location = new System.Drawing.Point(273, 233);
            this.pythonpic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pythonpic.Name = "pythonpic";
            this.pythonpic.Size = new System.Drawing.Size(270, 100);
            this.pythonpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pythonpic.TabIndex = 11;
            this.pythonpic.TabStop = false;
            this.pythonpic.Click += new System.EventHandler(this.pythonpic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 421);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(201, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 109);
            this.panel2.TabIndex = 13;
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
            this.viewlbl.Click += new System.EventHandler(this.viewlbl_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.viewstudentlbl);
            this.panel6.Location = new System.Drawing.Point(698, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 61);
            this.panel6.TabIndex = 18;
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
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pythonpic);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Manager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pythonpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label UserRealName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label managernamelbl;
        private System.Windows.Forms.PictureBox managerpic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pythonpic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label addlbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label viewlbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label viewstudentlbl;
    }
}