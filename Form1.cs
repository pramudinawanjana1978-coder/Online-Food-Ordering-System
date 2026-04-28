namespace Resturent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textBoxuser.Text;
            String Password = textBoxpass.Text;
            if (username == "admin" && Password == "1234")
            {

                Home1 home = new Home1();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalidate username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
