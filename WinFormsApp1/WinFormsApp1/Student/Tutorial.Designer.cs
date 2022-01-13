
namespace WinFormsApp1.Student
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.panel3 = new System.Windows.Forms.Panel();
            this.notilbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnproblembtn = new System.Windows.Forms.Button();
            this.tutorialbtn = new System.Windows.Forms.Button();
            this.editurialbtn = new System.Windows.Forms.Button();
            this.disscusionsbtn = new System.Windows.Forms.Button();
            this.submissionsbtn = new System.Windows.Forms.Button();
            this.problembtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pythonifelselbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.notilbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.returnproblembtn);
            this.panel3.Location = new System.Drawing.Point(54, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 462);
            this.panel3.TabIndex = 26;
            // 
            // notilbl
            // 
            this.notilbl.AutoSize = true;
            this.notilbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notilbl.Location = new System.Drawing.Point(3, 10);
            this.notilbl.Name = "notilbl";
            this.notilbl.Size = new System.Drawing.Size(565, 63);
            this.notilbl.TabIndex = 4;
            this.notilbl.Text = "In this challenge, we test your knowledge of using if-else conditional \r\nstatemen" +
    "ts to automate decision-making processes. An if-else statement \r\nhas the followi" +
    "ng logical flow:";
            this.notilbl.Click += new System.EventHandler(this.notilbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // returnproblembtn
            // 
            this.returnproblembtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnproblembtn.Location = new System.Drawing.Point(129, 413);
            this.returnproblembtn.Name = "returnproblembtn";
            this.returnproblembtn.Size = new System.Drawing.Size(281, 33);
            this.returnproblembtn.TabIndex = 1;
            this.returnproblembtn.Text = "Solve Python If-Else problem";
            this.returnproblembtn.UseVisualStyleBackColor = true;
            this.returnproblembtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tutorialbtn
            // 
            this.tutorialbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tutorialbtn.Location = new System.Drawing.Point(535, 126);
            this.tutorialbtn.Name = "tutorialbtn";
            this.tutorialbtn.Size = new System.Drawing.Size(108, 39);
            this.tutorialbtn.TabIndex = 25;
            this.tutorialbtn.Text = "Tutorial";
            this.tutorialbtn.UseVisualStyleBackColor = true;
            // 
            // editurialbtn
            // 
            this.editurialbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editurialbtn.Location = new System.Drawing.Point(428, 126);
            this.editurialbtn.Name = "editurialbtn";
            this.editurialbtn.Size = new System.Drawing.Size(109, 39);
            this.editurialbtn.TabIndex = 24;
            this.editurialbtn.Text = "Editurial";
            this.editurialbtn.UseVisualStyleBackColor = true;
            // 
            // disscusionsbtn
            // 
            this.disscusionsbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disscusionsbtn.Location = new System.Drawing.Point(297, 126);
            this.disscusionsbtn.Name = "disscusionsbtn";
            this.disscusionsbtn.Size = new System.Drawing.Size(135, 39);
            this.disscusionsbtn.TabIndex = 23;
            this.disscusionsbtn.Text = "Discussions";
            this.disscusionsbtn.UseVisualStyleBackColor = true;
            // 
            // submissionsbtn
            // 
            this.submissionsbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submissionsbtn.Location = new System.Drawing.Point(159, 126);
            this.submissionsbtn.Name = "submissionsbtn";
            this.submissionsbtn.Size = new System.Drawing.Size(139, 39);
            this.submissionsbtn.TabIndex = 22;
            this.submissionsbtn.Text = "Submissions";
            this.submissionsbtn.UseVisualStyleBackColor = true;
            // 
            // problembtn
            // 
            this.problembtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.problembtn.Location = new System.Drawing.Point(54, 126);
            this.problembtn.Name = "problembtn";
            this.problembtn.Size = new System.Drawing.Size(107, 39);
            this.problembtn.TabIndex = 21;
            this.problembtn.Text = "Problem";
            this.problembtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pythonifelselbl);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 49);
            this.panel2.TabIndex = 20;
            // 
            // pythonifelselbl
            // 
            this.pythonifelselbl.AutoSize = true;
            this.pythonifelselbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pythonifelselbl.Location = new System.Drawing.Point(37, 4);
            this.pythonifelselbl.Name = "pythonifelselbl";
            this.pythonifelselbl.Size = new System.Drawing.Size(143, 28);
            this.pythonifelselbl.TabIndex = 0;
            this.pythonifelselbl.Text = "Python If-Else";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 50);
            this.panel1.TabIndex = 19;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tutorialbtn);
            this.Controls.Add(this.editurialbtn);
            this.Controls.Add(this.disscusionsbtn);
            this.Controls.Add(this.submissionsbtn);
            this.Controls.Add(this.problembtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button returnproblembtn;
        private System.Windows.Forms.Button tutorialbtn;
        private System.Windows.Forms.Button editurialbtn;
        private System.Windows.Forms.Button disscusionsbtn;
        private System.Windows.Forms.Button submissionsbtn;
        private System.Windows.Forms.Button problembtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pythonifelselbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label notilbl;
    }
}