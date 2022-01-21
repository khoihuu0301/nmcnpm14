using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pypic_Click(object sender, EventArgs e)
        {
            Student.Python py = new Student.Python();
            py.Show();
            this.Hide();

        }

        private void UserRealName_Click(object sender, EventArgs e)
        {
            Student.Profile pf = new Student.Profile();
            pf.Show();
            this.Hide();
        }
    }
}
