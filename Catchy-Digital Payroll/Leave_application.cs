using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Catchy_Digital_Payroll
{
    public partial class Leave_application : Form
    {
        public Leave_application()
        {
            InitializeComponent();
        }

        public string leave = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Leave.txt";

        private void lnkSubmit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Validation validate = new Validation();

            DateTime effective = effectiveDate.Value;
            DateTime returning = returnDate.Value;

            TimeSpan difference = returning - effective;

            int diff = difference.Days;

            //MessageBox.Show(diff.ToString());

            string reason = "";

            if (!validate.IsValidName(txtEmployeeName.Text))
            {
                MessageBox.Show("Please enter a valid employee name", "Error");
            }
            else if (!validate.IsValidName(txtSurname.Text))
            {
                MessageBox.Show("Please enter a valid employee surname", "Error");
            }
            else if (!validate.IsNumeric(txtEmployeeID.Text))
            {
                MessageBox.Show("Please enter a valid employee ID", "Error");
            }
            else if (!validate.IsValidName(cmbLeaveType.Text))
            {
                MessageBox.Show("Please select a valid leave type", "Error");
            }
            else if (diff < 0)
            {
                MessageBox.Show("The leave days cannot be negative", "Error");
            }
            else if (!validate.EmployeeExists(txtEmployeeID.Text))
            {
                MessageBox.Show($"Employee {txtEmployeeID.Text} does not exist", "Error");
            }
            else
            {
                if (radAnnual.Checked)
                {
                    reason = radAnnual.Text;
                }
                else if (radSick.Checked)
                {
                    reason = radSick.Text;
                }
                else if (radVacation.Checked)
                {
                    reason = radVacation.Text;
                }
                else if (radPaternity.Checked)
                {
                    reason = radPaternity.Text;
                }
                else if (radMaternity.Checked)
                {
                    reason = radMaternity.Text;
                }
                else if (radFamilyEmergency.Checked)
                {
                    reason = radFamilyEmergency.Text;
                }
                else if (radSchool.Checked)
                {
                    reason = radSchool.Text;
                }

                HR_Manager hr = new HR_Manager();
                string[] line = hr.GetLastLine(hr.active).Split('|');

                DateTime date = DateTime.Now;

                hr.AddReport("Leave application", $"{line[0]} applied leave for {txtEmployeeName.Text} {txtSurname.Text}.", date.ToLocalTime().ToString());

                ApplyForLeave(reason, diff);

                MessageBox.Show("Submitted leave application successfully", "Success");
            }
        }
        public void ApplyForLeave(string reason, int duration)
        {
            using (StreamWriter sw = new StreamWriter(leave, true))
            {
                sw.WriteLine($"{txtEmployeeName.Text}|{txtSurname.Text}|{txtEmployeeID.Text}|{cmbLeaveType.Text}|{reason}|{returnDate.Text}|Duration: {duration}");
            }
        }

        private void Leave_application_Load(object sender, EventArgs e)
        {
            radSick.Checked = true;
            cmbLeaveType.SelectedIndex = 0;
        }
    }
}
