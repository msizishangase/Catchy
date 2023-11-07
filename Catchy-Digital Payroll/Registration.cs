using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catchy_Digital_Payroll
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txtOtherGender.Visible = false;
            lblFullnameWarning.Visible = false;
            lblUsernameWarning.Visible = false;
            lblEmailWarning.Visible = false;
            lblConfirmEmailWarning.Visible = false;
            lblGenderWarning.Visible = false;
            lblOtherGenderWarning.Visible = false;
            lblPasswordWarning.Visible = false;
            lblConfirmPasswordWarning.Visible = false;
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radOther.Checked)
            {

                txtOtherGender.Visible = true;
            }
            else
            {
                txtOtherGender.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (radMale.Checked)
            {
                lblOtherGenderWarning.Visible = false;
                gender = "Male";
            }
            else if (radFemale.Checked)
            {
                lblOtherGenderWarning.Visible = false;
                gender = "Female";
            }
            else if (radOther.Checked)
            {
                if (txtOtherGender.Text == "")
                {
                    lblOtherGenderWarning.Visible = true;
                    MessageBox.Show("You haven't specified your gender yet!", "GENDER");
                }
                else
                {
                    lblOtherGenderWarning.Visible = false;
                    gender = txtOtherGender.Text;
                }
            }
            else
            {
                lblGenderWarning.Visible = true;
            }

            HR_Manager hr = new HR_Manager();
            hr.propFullname = txtFullname.Text;
            hr.propUsername = txtUsername.Text;
            hr.propEmail = txtEmailaddress.Text;
            hr.propPassword = txtPassword.Text;
            hr.propGender = gender;


            if (hr.UserAlreadyExist() == false)
            {
                if (txtFullname.Text != "" && txtUsername.Text != "" && txtEmailaddress.Text != "" && txtConfirmEmail.Text != "" && gender != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
                {
                    if (txtUsername.Text.Length > 4)
                    {
                        if (txtPassword.Text.Length >= 6 && txtConfirmPassword.Text.Length >= 6)
                        {
                            if (ValidEmail(txtEmailaddress.Text) && txtConfirmEmail.Text == txtEmailaddress.Text)
                            {
                                if (PasswordMatch(txtPassword.Text, txtConfirmPassword.Text))
                                {
                                    MessageBox.Show("User successfully added to the system!", "REGISTRATION SUCCESS");
                                    hr.Register();

                                    Dashboard dash = new Dashboard();
                                    dash.Show();
                                    dash.Username = txtUsername.Text;
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Passwords do not match!", "ALERT");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Check your email address", "ALERT");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password needs to be atleast 6 characters long", "ALERT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username cannot be less than 5 characters", "ALERT");
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled!", "ALERT");
                }
            }
            else
            {

                MessageBox.Show($"An account with the username: {txtUsername.Text} already has an account!", "ALERT");
            }

        }

        private void btnAddProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != "" && txtConfirmPassword.Text != txtPassword.Text)
            {
                lblConfirmPasswordWarning.Visible = true;
            }
            else
            {
                lblConfirmPasswordWarning.Visible = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                lblConfirmPasswordWarning.Visible = true;
            }
            else
            {
                lblConfirmPasswordWarning.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblPasswordWarning.Text = "Create password";
                lblPasswordWarning.Visible = true;
            }
            else if (txtPassword.Text.Length < 6)
            {
                lblPasswordWarning.Visible = true;
                lblPasswordWarning.Text = "Password too short";
            }
            else
            {
                lblPasswordWarning.Visible = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblPasswordWarning.Visible = false;
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                lblFullnameWarning.Visible = true;
            }
            else
            {
                lblFullnameWarning.Visible = false;
            }
        }

        private void txtFullname_Leave(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                lblFullnameWarning.Visible = true;
            }
            else
            {
                lblFullnameWarning.Visible = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblUsernameWarning.Text = "Create username";
                lblUsernameWarning.Visible = true;
            }
            else if (txtUsername.Text.Length < 5)
            {
                lblUsernameWarning.Text = "Username too short";
                lblUsernameWarning.Visible = true;
            }
            else
            {
                lblUsernameWarning.Visible = false;
            }
        }
        public bool ValidEmail(string email) //Email field validation
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtEmailaddress_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailaddress.Text == "")
            {
                lblEmailWarning.Text = "Email can't be empty";
                lblEmailWarning.Visible = true;
            }
            else if (!ValidEmail(txtEmailaddress.Text))
            {
                lblEmailWarning.Text = "Include '@' ";
                lblEmailWarning.Visible = true;
            }
            else
            {
                lblEmailWarning.Visible = false;
            }
        }

        private void txtConfirmEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmEmail.Text != txtEmailaddress.Text)
            {
                lblConfirmEmailWarning.Text = "Emails don't match";
                lblConfirmEmailWarning.Visible = true;
            }
            else
            {
                lblConfirmEmailWarning.Visible = false;
            }
        }

        private void txtOtherGender_TextChanged(object sender, EventArgs e)
        {
            if (txtOtherGender.Text == "")
            {
                lblOtherGenderWarning.Visible = true;
            }
            else
            {
                lblOtherGenderWarning.Visible = false;
            }
        }
        public bool PasswordMatch(string pass, string confirm)
        {
            if (confirm == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            //
        }
    }

}
