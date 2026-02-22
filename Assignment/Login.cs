using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        string username = "";
        string password = "";
        public Login()
        {
            InitializeComponent();
        }

        private void regbt_Click(object sender, EventArgs e)
        {
            RegStep1 step1 = new RegStep1();
            this.Hide();
            step1.ShowDialog();
            this.Show();

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Olease fill the necessary data");
            }

            MessageBox.Show("Welcome " + username + "!");
        }
    }
}
