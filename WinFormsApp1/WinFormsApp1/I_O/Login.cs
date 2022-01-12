using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void Learninglbl_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
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
                            break;
                        }

                }
            }
        }
    }
}
