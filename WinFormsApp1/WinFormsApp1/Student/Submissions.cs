using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Student
{
    public partial class Submissions : Form
    {
        public Submissions()
        {
            InitializeComponent();
        }



        private void problembtn_Click(object sender, EventArgs e)
        {
            Problem pr = new Problem();
            pr.Show();
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

        private void returnproblembtn_Click(object sender, EventArgs e)
        {
            Problem pr = new Problem();
            pr.Show();
            this.Hide();
        }
    }
}
