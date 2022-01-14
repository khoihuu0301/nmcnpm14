using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Student
{
    public partial class Disscusions : Form
    {
        public Disscusions()
        {
            InitializeComponent();
        }

        private void problembtn_Click(object sender, EventArgs e)
        {
            Problem pr = new Problem();
            pr.Show();
        }

        private void submissionsbtn_Click(object sender, EventArgs e)
        {
            Submissions sm = new Submissions();
            sm.Show();
        }

        private void editurialbtn_Click(object sender, EventArgs e)
        {
            Editurial ed = new Editurial();
            ed.Show();
        }

        private void tutorialbtn_Click(object sender, EventArgs e)
        {
            Tutorial tt = new Tutorial();
            tt.Show();
        }
    }
}
