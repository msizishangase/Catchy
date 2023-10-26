namespace Catchy_Digital_Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relax, try to remember your password!", "ALERT");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HR_Manager hr = new HR_Manager();
            hr.propUsername = txtUsername.Text;
            hr.propPassword = txtPassword.Text;
            
            if (hr.LogIn() != "")
            {
                Dashboard dash = new Dashboard();
                dash.Username = hr.LogIn();
                dash.Show();
                this.Hide();
            }
            else if (hr.LogIn() == "")
            {
                MessageBox.Show("Check credentials and try again!", "ALERT");
            }
        }
    }
}