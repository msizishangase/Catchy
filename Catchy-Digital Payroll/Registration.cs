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

        Validation validate = new Validation();

        private void Registration_Load(object sender, EventArgs e)
        {
            txtOtherGender.Visible = false;
            lblFullnameWarning.Visible = false;
            lblUsernameWarning.Visible = false;
            lblEmailWarning.Visible = false;
            lblConfirmEmailWarning.Visible = false;
            lblGenderWarning.Visible = false;
            lblOtherWarning.Visible = false;
            lblPasswordWarning.Visible = false;
            lblConfirmPasswordWarning.Visible = false;
            radMale.Checked = true;
            cmbTitle.SelectedIndex = 0;
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radOther.Checked)
            {
                lblOtherWarning.Visible = true;
                txtOtherGender.Visible = true;
            }
            else
            {
                lblOtherWarning.Visible = false;
                txtOtherGender.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Validation val = new Validation();
            //if (val.IsEmpty(txtUsername.Text) || !val.IsEmpty(txtUsername))
            //{

            //}
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void SaveImagePathToFile(PictureBox pictureBox, string description, string destinationFilePath)
        {
            try
            {
                // Get the image path from the PictureBox
                string imagePath = pictureBox.ImageLocation;

                // Check if the image path is not empty
                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Create a formatted string with description and image path
                    string dataToWrite = $"{description} | {imagePath}";

                    // Write the formatted string to the destination file
                    File.WriteAllText(destinationFilePath, dataToWrite);

                    MessageBox.Show($"Description and image path saved to {destinationFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No image loaded in the PictureBox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (radMale.Checked)
            {
                lblOtherWarning.Visible = false;
                gender = "Male";
            }
            else if (radFemale.Checked)
            {
                lblOtherWarning.Visible = false;
                gender = "Female";
            }
            else if (radOther.Checked)
            {
                if (txtOtherGender.Text == "")
                {
                    lblOtherWarning.Visible = true;
                    MessageBox.Show("You haven't specified your gender yet!", "GENDER");
                }
                else
                {
                    lblOtherWarning.Visible = false;
                    gender = txtOtherGender.Text;
                }
            }
            else
            {
                lblGenderWarning.Visible = true;
            }

            HR_Manager hr = new HR_Manager();
            //hr.propUsername = txtUsername.Text;
            //hr.propPassword = txtPassword.Text;

            if (!hr.UserAlreadyExist())
            {
                if (!validate.IsValidName(txtFullname.Text))
                {
                    MessageBox.Show("Invalid name", "Registration failed");
                }
                else if (!validate.IsValidName(txtSurname.Text))
                {
                    MessageBox.Show("Invalid surname", "Registration failed");
                }
                else if (!validate.ValidUsername(txtUsername.Text))
                {
                    MessageBox.Show("Invalid username", "Registration failed");
                }
                else if (!validate.IsValidEmail(txtEmailaddress.Text))
                {
                    MessageBox.Show("Invalid email", "Registration failed");
                }
                else if (txtConfirmEmail.Text != txtEmailaddress.Text)
                {
                    MessageBox.Show("Emails do not match", "Registration failed");
                }
                else if (txtOtherGender.Visible)
                {
                    if (!validate.IsValidName(txtOtherGender.Text))
                    {
                        MessageBox.Show("Invalid gender entered", "Registration failed");
                    }
                }
                else if (!validate.ValidID(txtID.Text))
                {
                    MessageBox.Show("Invalid ID number", "Registration failed");
                }
                else if (!validate.IsValidName(cmbTitle.Text))
                {
                    MessageBox.Show("Invalid title selection", "Registration failed");
                }
                else if (!validate.IsValidPhoneNumber(txtPhone.Text))
                {
                    MessageBox.Show("Invalid phone number", "Registration failed");
                }
                else if (!validate.ValidatePassword(txtPassword.Text))
                {
                    MessageBox.Show("Invalid password [must contain atleast 8 characters, one upper case, one lower case, and atleast one special character]", "Registration failed");
                }
                else if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("Passwords do not match", "Registration failed");
                }
                else
                {
                    DateTime date = DateTime.Now;

                    hr.propFullnames = txtFullname.Text;
                    hr.propSurname = txtSurname.Text;
                    hr.propUsername = txtUsername.Text;
                    hr.propEmail = txtEmailaddress.Text;
                    hr.propPassword = txtPassword.Text;
                    hr.propID = txtID.Text;
                    hr.propPhone = txtPhone.Text;
                    hr.propTitle = cmbTitle.Text;
                    hr.propGender = gender;

                    hr.AddReport("HR registration", $"{txtFullname.Text} {txtSurname.Text} joined as a HR manager", date.ToLocalTime().ToString());
                    MessageBox.Show("Account registered successfully", "Success");
                    hr.Register();

                    string destinationFilePath = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Admin pictures.txt";

                    // Get the image path from the PictureBox
                    string imagePath = pictureBox1.ImageLocation;

                    // Check if the image path is not empty
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(destinationFilePath, true))
                            {
                                writer.WriteLine($"{txtUsername.Text}|{imagePath}");
                            }

                            MessageBox.Show($"Image path saved to {destinationFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No image loaded in the PictureBox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show($"{txtUsername.Text} has an account already, do you want to log in?", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Ensure that you use a different username!", "Registration");
                }
            }
        }

        private void btnAddProfilePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the selected image to the PictureBox
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                }
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
            if (validate.IsEmpty(txtPassword.Text))
            {
                lblPasswordWarning.Text = "Create password";
                lblPasswordWarning.Visible = true;
            }
            else if (txtPassword.Text.Length < 8)
            {
                lblPasswordWarning.Text = "Password is too short";
                lblPasswordWarning.Visible = true;
            }
            else
            {
                lblPasswordWarning.Visible = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!validate.ValidatePassword(txtPassword.Text))
            {
                lblPasswordWarning.Visible = true;
                lblPasswordWarning.Text = "Invalid password";
            }
            else
            {
                lblPasswordWarning.Visible = false;
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (validate.IsValidName(txtFullname.Text))
            {
                if (char.IsUpper(txtFullname.Text[0]))
                {
                    lblFullnameWarning.Visible = false;
                }
                else
                {
                    lblFullnameWarning.Text = "Must start with upper case";
                    lblFullnameWarning.Visible = true;
                }
            }
            else
            {
                lblFullnameWarning.Text = "Invalid name";
                lblFullnameWarning.Visible = true;
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

        private void txtEmailaddress_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailaddress.Text == "")
            {
                lblEmailWarning.Text = "Email can't be empty";
                lblEmailWarning.Visible = true;
            }
            else if (!validate.IsValidEmail(txtEmailaddress.Text))
            {
                lblEmailWarning.Text = "Include '@', '.' ";
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
                lblOtherWarning.Visible = true;
            }
            else
            {
                lblOtherWarning.Visible = false;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            //
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!validate.IsValidName(txtSurname.Text))
            {
                lblSurnameWarning.Text = "Invalid surname";
                lblSurnameWarning.Visible = true;
            }
            else
            {
                lblSurnameWarning.Visible = false;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!validate.ValidID(txtID.Text))
            {
                lblIdWarning.Text = "Invalid ID";
                lblIdWarning.Visible = true;
            }
            else
            {
                lblIdWarning.Visible = false;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!validate.IsValidPhoneNumber(txtPhone.Text))
            {
                lblPhoneNumberWarning.Text = "Invalid phone number";
                lblPhoneNumberWarning.Visible = true;
            }
            else
            {
                lblPhoneNumberWarning.Visible = false;
            }
        }
    }

}
