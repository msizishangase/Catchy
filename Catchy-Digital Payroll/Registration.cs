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
                gender = "Male";
            }
            else if (radFemale.Checked)
            {
                gender = "Female";
            }
            else if (radOther.Checked)
            {
                gender = txtOtherGender.Text;
            }

            HR_Manager hr = new HR_Manager();
            hr.propFullname = txtFullname.Text;
            hr.propUsername = txtUsername.Text;
            hr.propEmail = txtEmailaddress.Text;
            hr.propPassword = txtPassword.Text;
            hr.propGender = gender;

            if (hr.UserAlreadyExist() == false)
            {
                hr.Register();

                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
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

            HR_Manager hr = new HR_Manager();
        }
    }

}
