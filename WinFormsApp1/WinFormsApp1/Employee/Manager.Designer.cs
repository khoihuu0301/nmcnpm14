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
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentpic = new System.Windows.Forms.PictureBox();
            this.ttstudentlbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.couresepic = new System.Windows.Forms.PictureBox();
            this.coureselbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exercisepic = new System.Windows.Forms.PictureBox();
            this.exerciselbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.managerpic = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.managernamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couresepic)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisepic)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerpic)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.studentpic);
            this.panel2.Controls.Add(this.ttstudentlbl);
            this.panel2.Location = new System.Drawing.Point(934, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 107);
            this.panel2.TabIndex = 2;
            // 
            // studentpic
            // 
            this.studentpic.Image = ((System.Drawing.Image)(resources.GetObject("studentpic.Image")));
            this.studentpic.Location = new System.Drawing.Point(23, 12);
            this.studentpic.Name = "studentpic";
            this.studentpic.Size = new System.Drawing.Size(45, 43);
            this.studentpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentpic.TabIndex = 1;
            this.studentpic.TabStop = false;
            // 
            // ttstudentlbl
            // 
            this.ttstudentlbl.AutoSize = true;
            this.ttstudentlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttstudentlbl.Location = new System.Drawing.Point(105, 12);
            this.ttstudentlbl.Name = "ttstudentlbl";
            this.ttstudentlbl.Size = new System.Drawing.Size(137, 28);
            this.ttstudentlbl.TabIndex = 0;
            this.ttstudentlbl.Text = "Total student";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.couresepic);
            this.panel3.Controls.Add(this.coureselbl);
            this.panel3.Location = new System.Drawing.Point(262, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 107);
            this.panel3.TabIndex = 3;
            // 
            // couresepic
            // 
            this.couresepic.Image = ((System.Drawing.Image)(resources.GetObject("couresepic.Image")));
            this.couresepic.Location = new System.Drawing.Point(26, 12);
            this.couresepic.Name = "couresepic";
            this.couresepic.Size = new System.Drawing.Size(45, 43);
            this.couresepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.couresepic.TabIndex = 1;
            this.couresepic.TabStop = false;
            // 
            // coureselbl
            // 
            this.coureselbl.AutoSize = true;
            this.coureselbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coureselbl.Location = new System.Drawing.Point(155, 12);
            this.coureselbl.Name = "coureselbl";
            this.coureselbl.Size = new System.Drawing.Size(87, 28);
            this.coureselbl.TabIndex = 0;
            this.coureselbl.Text = "Courese";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exercisepic);
            this.panel4.Controls.Add(this.exerciselbl);
            this.panel4.Location = new System.Drawing.Point(594, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 107);
            this.panel4.TabIndex = 4;
            // 
            // exercisepic
            // 
            this.exercisepic.Image = ((System.Drawing.Image)(resources.GetObject("exercisepic.Image")));
            this.exercisepic.Location = new System.Drawing.Point(26, 12);
            this.exercisepic.Name = "exercisepic";
            this.exercisepic.Size = new System.Drawing.Size(45, 43);
            this.exercisepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exercisepic.TabIndex = 1;
            this.exercisepic.TabStop = false;
            // 
            // exerciselbl
            // 
            this.exerciselbl.AutoSize = true;
            this.exerciselbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exerciselbl.Location = new System.Drawing.Point(155, 12);
            this.exerciselbl.Name = "exerciselbl";
            this.exerciselbl.Size = new System.Drawing.Size(89, 28);
            this.exerciselbl.TabIndex = 0;
            this.exerciselbl.Text = "Exercise";
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
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couresepic)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisepic)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label UserRealName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox studentpic;
        private System.Windows.Forms.Label ttstudentlbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label coureselbl;
        private System.Windows.Forms.PictureBox couresepic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox exercisepic;
        private System.Windows.Forms.Label exerciselbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label managernamelbl;
        private System.Windows.Forms.PictureBox managerpic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}