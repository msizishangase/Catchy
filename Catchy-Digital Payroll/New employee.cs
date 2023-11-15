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

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {
            btnRemove.FlatAppearance.BorderSize = 1;
        }

        private void btnUpload_MouseHover(object sender, EventArgs e)
        {
            btnUpload.FlatAppearance.BorderSize = 1;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string homeAddress = $"{textBox13.Text} {textBox14.Text} {textBox23.Text}";
            string gender = "";

            Employee employee = new Employee(txtName.Text, txtSurname.Text, txtEmployeeID.Text, txtEmail.Text, txtPhone.Text, txtID.Text, cmbNationality.Text, cmbRace.Text, homeAddress, cmbOccupation.Text, txtNextName.Text, txtNextSurname.Text, cmbNextRelationship.Text, txtNextEmail.Text, txtNextPhone.Text);

            if (validate.IsEmpty(txtName.Text) || !validate.IsValidName(txtName.Text))
            {
                MessageBox.Show("Invalid name entered", "Registration failed");
            }
            else if (validate.IsEmpty(txtSurname.Text) || !validate.IsValidName(txtSurname.Text))
            {
                MessageBox.Show("Invalid surname entered", "Registration failed");
            }
            else if (validate.IsEmpty(txtEmployeeID.Text) || !validate.IsNumeric(txtEmployeeID.Text))
            {
                MessageBox.Show("Invalid employee id entered", "Registration failed");
            }
            else if (validate.IsEmpty(txtEmail.Text) || !validate.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email entered", "Registration failed");
            }
            else if (!validate.IsValidPhoneNumber(txtPhone.Text) || validate.IsEmpty(txtPhone.Text))
            {
                MessageBox.Show("Invalid phone number entered", "Registration failed");
            }
            else if (!validate.ValidID(txtID.Text) || validate.IsEmpty(txtID.Text))
            {
                MessageBox.Show("Invalid ID number entered", "Registration failed");
            }
            else if (validate.IsEmpty(cmbNationality.Text) || validate.IsValidName(cmbNationality.Text))
            {
                MessageBox.Show("Invalid nationality selection", "Registration failed");
            }
            else if (validate.IsEmpty(cmbRace.Text) || validate.IsValidName(cmbRace.Text))
            {
                MessageBox.Show("Invalid race selection", "Registration failed");
            }
            else if (validate.IsEmpty(textBox13.Text) || validate.IsValidName(textBox13.Text))
            {
                MessageBox.Show("Invalid address entered", "Registration failed");
            }
            else if (validate.IsEmpty(cmbOccupation.Text) || validate.IsValidName(cmbOccupation.Text))
            {
                MessageBox.Show("Invalid occupation selection", "Registration failed");
            }
            else if (validate.IsEmpty(txtNextName.Text) || validate.IsValidName(txtNextName.Text))
            {
                MessageBox.Show("Invalid next of kin name entered", "Registration failed");
            }
            else if (validate.IsEmpty(txtNextSurname.Text) || validate.IsValidName(txtNextSurname.Text))
            {
                MessageBox.Show("Invalid next of kin surname entered", "Registration failed");
            }
            else if (validate.IsEmpty(txtNextEmail.Text) || validate.IsValidEmail(txtNextEmail.Text))
            {
                MessageBox.Show("Invalid next of kin email entered", "Registration failed");
            }
            else if (validate.IsEmpty(cmbNextRelationship.Text) || validate.IsValidName(cmbNextRelationship.Text))
            {
                MessageBox.Show("Invalid next of kin relationship selected", "Registration failed");
            }
            else if (validate.IsEmpty(txtNextPhone.Text) || validate.IsValidPhoneNumber(txtNextPhone.Text))
            {
                MessageBox.Show("Invalid next of kin number entered entered", "Registration failed");
            }
            else
            {
                gender = validate.Gender(txtID.Text);

                if (MessageBox.Show($"Add {txtName.Text} {txtSurname.Text} to the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Hide();
                    employee.Add();
                }
            }
        }
    }
}
