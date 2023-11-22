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
            MessageBox.Show("Contact the developer team \nEmail: 22262057@dut4life.ac\nPhone: +27788821014\nAlternative email: 22202887@dut4life.ac.za\nAlternative phone: +27655465903", "ALERT");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
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
                MessageBox.Show("Enter your username and password", "Log In");
            }
            else if (txtUsername.Text == "")
            {
                lblUsernameWarning.Visible = true;
                lblPasswordWarning.Visible = false;
                MessageBox.Show("Enter your username", "Log In");
            }
            else if (txtPassword.Text == "")
            {
                lblUsernameWarning.Visible = false;
                lblPasswordWarning.Visible = true;
                MessageBox.Show("Enter your password", "Log In");
            }
            else
            {
                HR_Manager hr = new HR_Manager();
                hr.propUsername = txtUsername.Text;
                hr.propPassword = txtPassword.Text;

                if (hr.LogIn())
                {
                    hr.Active();

                    this.Hide();
                    Dashboard dash = new Dashboard();
                    dash.Username = hr.CurrentUser();
                    dash.User = hr.GetFullName();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password, try again!", "ALERT");
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

        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpassword.Checked)
            {
                txtPassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}