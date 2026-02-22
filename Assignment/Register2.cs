using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RegStep2 : Form
    {
        public RegStep2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BckBt1_Click(object sender, EventArgs e)
        {
            RegStep1 b = new RegStep1();
            b.Show();
            this.Hide();
        }

        private void Nxbt2_Click(object sender, EventArgs e)
        {
            if(txtUni.Text == "" || txtDep.Text == "" || comboBoxDeg.Items == null || graduationYear.Value == 0)
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            
            this.Hide();
            RegStep3 step3 = new RegStep3();
            step3.ShowDialog();

            this.Close();
        }
    }
}
