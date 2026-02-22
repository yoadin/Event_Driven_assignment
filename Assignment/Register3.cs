using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RegStep3 : Form
    {
        public RegStep3()
        {
            InitializeComponent();
        }

        private void FinBt_Click(object sender, EventArgs e)
        {
            if(txtCity.Text == "" || txtCountry.Text == "" || txtSubCity.Text
                 == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }
            MessageBox.Show("Registration Completed Successfully!");
            this.Close();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            RegStep2 d = new RegStep2();
            d.Show();
            this.Hide();
        }
    }
}
