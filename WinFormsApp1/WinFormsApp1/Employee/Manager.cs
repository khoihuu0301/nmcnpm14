using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Employee
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pythonpic_Click(object sender, EventArgs e)
        {
            EditPython ep = new EditPython();
            ep.Show();
            this.Hide();
        }

        private void viewlbl_Click(object sender, EventArgs e)
        {
            
        }

        private void UserRealName_Click(object sender, EventArgs e)
        {

        }
    }
}
