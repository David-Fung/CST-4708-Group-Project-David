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
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void BTNcreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\David\\Downloads\\Comics\\Comics.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();


            if (string.IsNullOrEmpty(TBusername.Text) || string.IsNullOrEmpty(TBpassword.Text) || string.IsNullOrEmpty(TBfirstname.Text) || string.IsNullOrEmpty(TBlastname.Text) || string.IsNullOrEmpty(TBcreditcard.Text)|| string.IsNullOrEmpty(TBverifypassword.Text) )
            {
                MessageBox.Show("Please fill out all required fields.", "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBcreditcard.Text.Length < 19) 
            {
                MessageBox.Show("Credit card number cannot contain less than 16 digits.", "Invalid Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBpassword.Text != TBverifypassword.Text)
            {
                MessageBox.Show("Verify Password Does Not Match.", "Passwords Do Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert Into Customer (FirstName, LastName, Username, Password) Values (@FirstName, @LastName, @Username, @Password)", con);
                cmd.Parameters.Add("@FirstName", TBfirstname.Text);
                cmd.Parameters.Add("@LastName", TBlastname.Text);
                cmd.Parameters.Add("@Username", TBusername.Text);
                cmd.Parameters.Add("@Password", TBpassword.Text);
                cmd.ExecuteNonQuery();

                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }

        }

        private void TBcreditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Credit card number cannot contain letters.", "Invalid Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TBcreditcard.Text.Replace("-", "").Length % 4 == 0 && TBcreditcard.Text.Length != 0 && TBcreditcard.Text.Substring(TBcreditcard.Text.Length - 1) != "-")
            {
                if (TBcreditcard.TextLength < 19)
                {
                    this.TBcreditcard.Text = this.TBcreditcard.Text + "-";
                    this.TBcreditcard.Select(this.TBcreditcard.Text.Length, 1);
                }
                else 
                {
                    e.Handled = true;
                }
            }

        }

        private void TBfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("First name cannot contain digits.", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Last name cannot contain digits.", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
