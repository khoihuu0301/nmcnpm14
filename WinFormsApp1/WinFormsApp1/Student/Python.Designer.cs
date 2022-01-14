
namespace WinFormsApp1.Student
{
    partial class Python
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pythonifelselbl = new System.Windows.Forms.Label();
            this.solve1btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pythonlbl = new System.Windows.Forms.Label();
            this.dc1lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.UserRealName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pythonifelselbl);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 76);
            this.panel2.TabIndex = 28;
            // 
            // pythonifelselbl
            // 
            this.pythonifelselbl.AutoSize = true;
            this.pythonifelselbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pythonifelselbl.Location = new System.Drawing.Point(38, 23);
            this.pythonifelselbl.Name = "pythonifelselbl";
            this.pythonifelselbl.Size = new System.Drawing.Size(98, 35);
            this.pythonifelselbl.TabIndex = 0;
            this.pythonifelselbl.Text = "Python";
            this.pythonifelselbl.Click += new System.EventHandler(this.pythonifelselbl_Click);
            // 
            // solve1btn
            // 
            this.solve1btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.solve1btn.Location = new System.Drawing.Point(460, 14);
            this.solve1btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solve1btn.Name = "solve1btn";
            this.solve1btn.Size = new System.Drawing.Size(103, 45);
            this.solve1btn.TabIndex = 30;
            this.solve1btn.Text = "Solve";
            this.solve1btn.UseVisualStyleBackColor = true;
            this.solve1btn.Click += new System.EventHandler(this.solve1btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dc1lbl);
            this.panel3.Controls.Add(this.pythonlbl);
            this.panel3.Controls.Add(this.solve1btn);
            this.panel3.Location = new System.Drawing.Point(38, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 126);
            this.panel3.TabIndex = 35;
            // 
            // pythonlbl
            // 
            this.pythonlbl.AutoSize = true;
            this.pythonlbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pythonlbl.Location = new System.Drawing.Point(29, 21);
            this.pythonlbl.Name = "pythonlbl";
            this.pythonlbl.Size = new System.Drawing.Size(145, 30);
            this.pythonlbl.TabIndex = 0;
            this.pythonlbl.Text = "Python If-Else";
            this.pythonlbl.Click += new System.EventHandler(this.pythonlbl_Click);
            // 
            // dc1lbl
            // 
            this.dc1lbl.AutoSize = true;
            this.dc1lbl.Location = new System.Drawing.Point(29, 96);
            this.dc1lbl.Name = "dc1lbl";
            this.dc1lbl.Size = new System.Drawing.Size(382, 20);
            this.dc1lbl.TabIndex = 31;
            this.dc1lbl.Text = "Easy, Python (Basic), Max Score: 10, Success Rate: 90.97%\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.Avatar);
            this.panel1.Controls.Add(this.UserRealName);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 63);
            this.panel1.TabIndex = 36;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(560, 15);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(692, 27);
            this.searchtxt.TabIndex = 15;
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(1376, 11);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(35, 36);
            this.Avatar.TabIndex = 3;
            this.Avatar.TabStop = false;
            // 
            // UserRealName
            // 
            this.UserRealName.AutoSize = true;
            this.UserRealName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserRealName.Location = new System.Drawing.Point(1296, 11);
            this.UserRealName.Name = "UserRealName";
            this.UserRealName.Size = new System.Drawing.Size(53, 35);
            this.UserRealName.TabIndex = 1;
            this.UserRealName.Text = "Me";
            this.UserRealName.Click += new System.EventHandler(this.UserRealName_Click);
            // 
            // Python
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Python";
            this.Text = "Python";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pythonifelselbl;
        private System.Windows.Forms.Button solve1btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pythonlbl;
        private System.Windows.Forms.Label dc1lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label UserRealName;
    }
}