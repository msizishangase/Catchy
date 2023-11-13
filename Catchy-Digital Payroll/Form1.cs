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
            MessageBox.Show("Contact the developer team \ncatchypayroll@gmail.com\n+27755462801", "ALERT");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            lblUsernameWarning.Visible = false;
            lblPasswordWarning.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                lblUsernameWarning.Visible = true;
                lblPasswordWarning.Visible = true;
            }
            else if (txtUsername.Text == "")
            {
                lblUsernameWarning.Visible = true;
                lblPasswordWarning.Visible = false;
            }
            else if (txtPassword.Text == "")
            {
                lblUsernameWarning.Visible = false;
                lblPasswordWarning.Visible = true;
            }
            else
            {
                HR_Manager hr = new HR_Manager();
                hr.propUsername = txtUsername.Text;
                hr.propPassword = txtPassword.Text;
                hr.Active();

                if (hr.LogIn())
                {
                    Dashboard dash = new Dashboard();
                    dash.Username = hr.CurrentUser();
                    dash.User = hr.GetFullName();
                    dash.Show();

                    Profile profile = new Profile();
                    profile.MyName = txtUsername.Text;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect credentials, try again!", "ALERT");
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblUsernameWarning.Visible = true;
            }
            else
            {
                lblUsernameWarning.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblPasswordWarning.Visible = true;
            }
            else
            {
                lblPasswordWarning.Visible = false;
            }
        }
    }
}