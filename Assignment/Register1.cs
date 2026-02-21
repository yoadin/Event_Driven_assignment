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
            RegStep2 s = new RegStep2();
            s.Show();
            this.Hide();
        }
    }
}
