using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Student;

namespace WinFormsApp1.I_O
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public static string id = "";
        public Login()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {   conn = new SqlConnection(connectionString);
            conn.Open();
            adapter = new SqlDataAdapter("Select * from NGUOIDUNG where username = '"+ UsernameBox.Text +"'", conn);
            dt = new DataTable();
            adapter.Fill(dt);

            if (PasswordBox.Text != dt.Rows[0][1].ToString())
            {
                MessageBox.Show("Wrong password");
            }
            else
            { int role = int.Parse(dt.Rows[0][2].ToString());
                switch (role)
                {
                    case 1:
                        {
                            Browse brw = new Browse();
                            brw.Show();
                            this.Hide();
                            break;
                        }

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signin sn = new Signin();
            sn.Show();
            this.Hide();
        }


        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
