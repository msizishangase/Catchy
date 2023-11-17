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
    public partial class Salary : Form
    {
        string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Employee.txt";
        public Salary()
        {
            InitializeComponent();
        }

        private void lnkCalculate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double rate, hours, overtime;
            rate = double.Parse(txtRateOfPay.Text);
            hours = double.Parse(txtHoursWorked.Text);
            overtime = double.Parse(txtOverTimeHours.Text);

            Calculations calculations = new Calculations(rate, hours, overtime);

            lblGrossPay.Text = calculations.GrossPay().ToString("C");
            lblNetPay.Text = calculations.NetPay().ToString("C");
            lblMedicalAid.Text = calculations.MedicalAid().ToString("C");
            lblIncomeTax.Text = calculations.IncomeTax().ToString("C");
            lblUIF.Text = calculations.UIF().ToString("C");
            lblPension.Text = calculations.Pension().ToString("C");
            lblTotalDeductions.Text = calculations.Pension().ToString("C");

            AddNetPay();
        }
        public void AddNetPay()
        {
            StreamReader reader = new StreamReader(file);
            string[] details = new string[13];
            string lineRead = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    details = lineRead.Split('|');
                    if (details[10] == txtEmployeeID.Text)
                    {
                        details[12] = lblNetPay.Text;
                    }
                    lineRead = reader.ReadLine();
                }
            }
        }
    }
}
