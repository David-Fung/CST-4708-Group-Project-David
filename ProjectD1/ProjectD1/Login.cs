using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectD1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            TBusername.Select();
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            //  Establish a connection
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\David\\Downloads\\Comics\\Comics.mdf;Integrated Security=True;Connect Timeout=30";
            myconn.Open();
            SqlDataReader reader;

            //  Make a SQLCommand object
            SqlCommand mycommand = new SqlCommand();

            mycommand.CommandText = "SELECT * FROM Customer WHERE Username = @username and Password = @password";
            mycommand.Parameters.Add("@username", SqlDbType.VarChar, 50);
            mycommand.Parameters["@username"].Value = TBusername.Text;
            mycommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
            mycommand.Parameters["@Password"].Value = TBpassword.Text;
            mycommand.Connection = myconn;

            reader = mycommand.ExecuteReader();



            if (reader.HasRows)
            {
                MessageBox.Show("Welcome.");
            }
            else if (TBusername.Text == "" || TBpassword.Text == "")
            {
                MessageBox.Show("Please enter a username and a password.", "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid Account Information. Please Try Again.", "Invalid Account Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LLaboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs aboutus = new AboutUs();
            aboutus.Show();
        }

        private void BTNregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
    
        }

        private void LLcontactus_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.Show();
        }
    }
}
