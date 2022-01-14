
namespace WinFormsApp1.I_O
{
    partial class Signin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Certifylbl = new System.Windows.Forms.Label();
            this.Preparelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginlbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Comfirmlbl = new System.Windows.Forms.Label();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.comfirmtxt = new System.Windows.Forms.TextBox();
            this.Signinbtn = new System.Windows.Forms.Button();
            this.suasetslbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Certifylbl);
            this.panel1.Controls.Add(this.Preparelbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 48);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Certifylbl
            // 
            this.Certifylbl.AutoSize = true;
            this.Certifylbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Certifylbl.Location = new System.Drawing.Point(172, 14);
            this.Certifylbl.Name = "Certifylbl";
            this.Certifylbl.Size = new System.Drawing.Size(77, 28);
            this.Certifylbl.TabIndex = 1;
            this.Certifylbl.Text = "Certify";
            this.Certifylbl.Click += new System.EventHandler(this.Certifylbl_Click);
            // 
            // Preparelbl
            // 
            this.Preparelbl.AutoSize = true;
            this.Preparelbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Preparelbl.Location = new System.Drawing.Point(73, 14);
            this.Preparelbl.Name = "Preparelbl";
            this.Preparelbl.Size = new System.Drawing.Size(85, 28);
            this.Preparelbl.TabIndex = 1;
            this.Preparelbl.Text = "Prepare";
            this.Preparelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(498, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Loginlbl
            // 
            this.Loginlbl.AutoSize = true;
            this.Loginlbl.Location = new System.Drawing.Point(383, 184);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(37, 15);
            this.Loginlbl.TabIndex = 2;
            this.Loginlbl.Text = "Login";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(383, 218);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(57, 15);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // Comfirmlbl
            // 
            this.Comfirmlbl.AutoSize = true;
            this.Comfirmlbl.Location = new System.Drawing.Point(383, 253);
            this.Comfirmlbl.Name = "Comfirmlbl";
            this.Comfirmlbl.Size = new System.Drawing.Size(55, 15);
            this.Comfirmlbl.TabIndex = 4;
            this.Comfirmlbl.Text = "Comfirm";
            this.Comfirmlbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(478, 179);
            this.logintxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(177, 23);
            this.logintxt.TabIndex = 5;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(478, 212);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(177, 23);
            this.passwordtxt.TabIndex = 6;
            // 
            // comfirmtxt
            // 
            this.comfirmtxt.Location = new System.Drawing.Point(478, 248);
            this.comfirmtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comfirmtxt.Name = "comfirmtxt";
            this.comfirmtxt.Size = new System.Drawing.Size(177, 23);
            this.comfirmtxt.TabIndex = 7;
            // 
            // Signinbtn
            // 
            this.Signinbtn.Location = new System.Drawing.Point(478, 290);
            this.Signinbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(177, 27);
            this.Signinbtn.TabIndex = 8;
            this.Signinbtn.Text = "Sign In";
            this.Signinbtn.UseVisualStyleBackColor = true;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // suasetslbl
            // 
            this.suasetslbl.AutoSize = true;
            this.suasetslbl.Location = new System.Drawing.Point(457, 143);
            this.suasetslbl.Name = "suasetslbl";
            this.suasetslbl.Size = new System.Drawing.Size(190, 15);
            this.suasetslbl.TabIndex = 9;
            this.suasetslbl.Text = "Sign up and start exploring the site";
            this.suasetslbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.suasetslbl);
            this.Controls.Add(this.Signinbtn);
            this.Controls.Add(this.comfirmtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.Comfirmlbl);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Loginlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signin";
            this.Text = "Signin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Preparelbl;
        private System.Windows.Forms.Label Certifylbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Loginlbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label Comfirmlbl;
        private System.Windows.Forms.TextBox logintxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox comfirmtxt;
        private System.Windows.Forms.Button Signinbtn;
        private System.Windows.Forms.Label suasetslbl;
    }
}