using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Student
{
    public partial class Problem : Form
    {
        public Problem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void asd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void tutorialbtn_Click(object sender, EventArgs e)
        {
            Tutorial tt = new Tutorial();
            tt.Show();
            this.Hide();
        }

        private void problembtn_Click(object sender, EventArgs e)
        {

        }

        private void UserRealName_Click(object sender, EventArgs e)
        {

        }
    }
}
