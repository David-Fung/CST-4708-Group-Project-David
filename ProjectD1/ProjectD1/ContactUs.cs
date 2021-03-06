﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectD1
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
            TBemail.Select();
        }

        private void BTNsend_Click(object sender, EventArgs e)
        {
            if (TBemail.Text.Length == 0)
            {
                MessageBox.Show("Please enter your email address.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TBemail.Text.Contains("@") || !TBemail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBmessage.Text.Length == 0)
            {
                MessageBox.Show("Please enter a message.", "Missing Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Message sent. Thank you for contacting us!");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
