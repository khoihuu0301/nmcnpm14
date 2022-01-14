using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Student
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notilbl_Click(object sender, EventArgs e)
        {

        }

        private void problembtn_Click(object sender, EventArgs e)
        {
            Problem pr = new Problem();
            pr.Show();
            this.Hide();
        }

        private void submissionsbtn_Click(object sender, EventArgs e)
        {
            Submissions sm = new Submissions();
            sm.Show();
            this.Hide();
        }

        private void disscusionsbtn_Click(object sender, EventArgs e)
        {
            Disscusions dc = new Disscusions();
            dc.Show();
            this.Hide();
        }

        private void editurialbtn_Click(object sender, EventArgs e)
        {
            Editurial ed = new Editurial();
            ed.Show();
            this.Hide();
        }

        private void returnproblembtn_Click(object sender, EventArgs e)
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

        private void Tutorial_Load(object sender, EventArgs e)
        {

        }
    }
}
