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
    public partial class New_employee : Form
    {
        public New_employee()
        {
            InitializeComponent();
        }
        Validation validate = new Validation();

        private void btnUpload_MouseHover(object sender, EventArgs e)
        {
            btnUpload.FlatAppearance.BorderSize = 1;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the selected image to the PictureBox
                    picEmployee.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            if (!validate.IsValidName(txtName.Text))
            {
                MessageBox.Show("Invalid name entered", "Registration failed");
            }
            else if (!validate.IsValidName(txtSurname.Text))
            {
                MessageBox.Show("Invalid surname entered", "Registration failed");
            }
            else if (!validate.IsNumeric(txtEmployeeID.Text))
            {
                MessageBox.Show("Invalid employee id entered", "Registration failed");
            }
            else if (!validate.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email entered", "Registration failed");
            }
            else if (!validate.IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Invalid phone number entered", "Registration failed");
            }
            else if (!validate.ValidID(txtID.Text))
            {
                MessageBox.Show("Invalid ID number entered", "Registration failed");
            }
            else if (!validate.IsValidName(cmbNationality.Text))
            {
                MessageBox.Show("Invalid nationality selection", "Registration failed");
            }
            else if (!validate.IsValidName(cmbRace.Text))
            {
                MessageBox.Show("Invalid race selection", "Registration failed");
            }
            else if (!validate.IsValidName(textBox13.Text))
            {
                MessageBox.Show("Invalid address entered", "Registration failed");
            }
            else if (!validate.IsValidName(cmbOccupation.Text))
            {
                MessageBox.Show("Invalid occupation selection", "Registration failed");
            }
            else if (!validate.IsValidName(txtNextName.Text))
            {
                MessageBox.Show("Invalid next of kin name entered", "Registration failed");
            }
            else if (!validate.IsValidName(txtNextSurname.Text))
            {
                MessageBox.Show("Invalid next of kin surname entered", "Registration failed");
            }
            else if (!validate.IsValidName(cmbNextRelationship.Text))
            {
                MessageBox.Show("Invalid next of kin relationship selected", "Registration failed");
            }
            else if (!validate.IsValidPhoneNumber(txtNextPhone.Text))
            {
                MessageBox.Show("Invalid next of kin number entered entered", "Registration failed");
            }
            else if (validate.EmployeeExists(txtEmployeeID.Text))
            {
                MessageBox.Show($"An employee with {txtEmployeeID.Text} ID already exists", "Registration failed");
            }
            else
            {
                string homeAddress = $"{textBox13.Text} {textBox14.Text} {textBox23.Text}";
                
                string gender = validate.Gender(txtID.Text);

                DateTime date = DateTime.Now;

                Employee employee = new Employee(txtName.Text, txtSurname.Text, txtEmployeeID.Text, txtEmail.Text, txtPhone.Text, txtID.Text, cmbNationality.Text, cmbRace.Text, homeAddress, cmbOccupation.Text, txtNextName.Text, txtNextSurname.Text, cmbNextRelationship.Text, txtNextEmail.Text, txtNextPhone.Text, gender);
                HR_Manager hr = new HR_Manager();

                string[] line = GetLastLine(hr.active).Split('|');

                DialogResult result = MessageBox.Show($"Add {txtName.Text} {txtSurname.Text} to the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    hr.AddReport("Employee registration", $"{line[0]} added {txtName.Text} {txtSurname.Text} to the system", date.ToLocalTime().ToString());

                    if (String.IsNullOrEmpty(txtNextEmail.Text))
                    {
                        employee.propNextEmail = "none";
                    }

                    string destinationFilePath = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Employee pictures.txt";

                    // Get the image path from the PictureBox
                    string imagePath = picEmployee.ImageLocation;

                    // Check if the image path is not empty
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(destinationFilePath, true))
                            {
                                writer.WriteLine($"{txtEmployeeID.Text}|{imagePath}");
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

                    this.Close();
                    employee.SaveEmployee();
                    employee.SaveImportantInfo();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_MouseLeave(object sender, EventArgs e)
        {
            btnUpload.FlatAppearance.BorderSize = 0;
        }
        public string GetLastLine(string filePath)
        {
            string lastLine = null;

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        lastLine = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
            return lastLine;
        }
    }
}
