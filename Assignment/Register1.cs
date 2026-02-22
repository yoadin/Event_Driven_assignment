namespace Assignment
{
    public partial class RegStep1 : Form
    {
        public RegStep1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nxBt1_Click(object sender, EventArgs e)
        {
            if(txtfirstname.Text == "" || txtFatherName.Text == "" || txtGfname.Text == ""){
                MessageBox.Show("Please Fill in the the name Fields");
                return;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Please Select a Valid Date of Birth");
                return;
            }
            
            this.Hide();
            RegStep2 step2 = new RegStep2();
            step2.ShowDialog();
            this.Close();
        }

        private void bckbtn1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
