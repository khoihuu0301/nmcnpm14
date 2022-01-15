using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Student
{
    public partial class Python : Form
    {
        public Python()
        {
            InitializeComponent();
        }

        private void pythonifelselbl_Click(object sender, EventArgs e)
        {

        }

        private void Certifylbl_Click(object sender, EventArgs e)
        {

        }


        private void solve1btn_Click(object sender, EventArgs e)
        {
            Problem pr = new Problem();
            pr.Show();
            this.Hide();
        }

        private void pythonlbl_Click(object sender, EventArgs e)
        {
            Problem pr = new Problem();
            pr.Show();
            this.Hide();
        }

        private void UserRealName_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }
    }
}
