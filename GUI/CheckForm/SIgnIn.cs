namespace GUI.CheckForm
{
    public partial class SIgnIn : Form
    {
        Form1 form1 = new Form1();
        SignUp signUp = new SignUp();
        Forgot forgot = new Forgot();
        public SIgnIn()
        {
            InitializeComponent();
        }
        private void Sign_in_Click(object sender, EventArgs e)
        {
            Hide();
            form1.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signUp.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            forgot.ShowDialog();
        }
    }
}
