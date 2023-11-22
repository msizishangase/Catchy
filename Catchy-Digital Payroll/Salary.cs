using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Catchy_Digital_Payroll
{
    public partial class Salary : Form
    {
        string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Salary.txt";
        public Salary()
        {
            InitializeComponent();
        }

        private void lnkCalculate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Validation validation = new Validation();

            if (!validation.IsNumeric(txtEmployeeID.Text) || validation.IsEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Invalid employee ID", "Error");
            }
            else if (!validation.IsNumeric(txtHoursWorked.Text) || validation.IsEmpty(txtHoursWorked.Text))
            {
                MessageBox.Show("Invalid hours entered", "Error");
            }
            else if (!validation.IsNumeric(txtRateOfPay.Text) || validation.IsEmpty(txtRateOfPay.Text))
            {
                MessageBox.Show("Invalid rate of pay", "Error");
            }
            else if (!validation.IsNumeric(txtOverTimeHours.Text) || validation.IsEmpty(txtOverTimeHours.Text))
            {
                MessageBox.Show("Invalid overtime hours", "Error");
            }
            else if (!validation.EmployeeExists(txtEmployeeID.Text))
            {
                MessageBox.Show($"Employee {txtEmployeeID.Text} was not found in the system", "Error");
            }
            else
            {
                double rate, hours, overtime;
                rate = double.Parse(txtRateOfPay.Text);
                hours = double.Parse(txtHoursWorked.Text);
                overtime = double.Parse(txtOverTimeHours.Text);

                Calculations calculations = new Calculations();
                calculations.propRate = rate;
                calculations.propHours = hours;
                calculations.propOvertime = overtime;

                lblGrossPay.Text = calculations.GrossPay().ToString("C");
                lblNetPay.Text = calculations.NetPay().ToString("C");
                lblMedicalAid.Text = calculations.MedicalAid().ToString("C");
                lblIncomeTax.Text = calculations.IncomeTax().ToString("C");
                lblUIF.Text = calculations.UIF().ToString("C");
                lblPension.Text = calculations.Pension().ToString("C");
                lblTotalDeductions.Text = calculations.TotalDeducions().ToString("C");

                HR_Manager hr = new HR_Manager();

                string[] line = hr.GetLastLine(hr.active).Split('|');

                DateTime date = DateTime.Now;

                hr.AddReport("Payslip generated", $"{line[0]} generated a payslip for employee #{txtEmployeeID.Text}", date.ToLocalTime().ToString()  );

                AddNetPay();
            }
        }
        public void AddNetPay()
        {
            string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Employee.txt";
            string tempFile = Path.GetTempFileName();
            string line;
            string[] record;
            bool status = false;

            using (StreamReader sr = new StreamReader(file))
            using (StreamWriter sw = new StreamWriter(tempFile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    record = line.Split('|');
                    if (record.Length >= 16 && record[2] == txtEmployeeID.Text)
                    {
                        record[16] = lblNetPay.Text;
                        status = true;
                    }
                    sw.WriteLine(string.Join("|", record));
                }
            }

            // Replace the original file with the temporary file
            if (status)
            {
                File.Delete(file);
                File.Move(tempFile, file);
            }
            else
            {
                File.Delete(tempFile); // If no changes were made, delete the temporary file
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
