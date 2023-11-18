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
    public partial class Leave_application : Form
    {
        string leave = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Leave.txt";
        public Leave_application()
        {
            InitializeComponent();
        }

        private void lnkSubmit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string reason = "";
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

            using (StreamWriter sw = new StreamWriter(leave, true))
            {
                sw.WriteLine($"{txtEmployeeName.Text}|{txtSurpervisorName.Text}|{returnDate.Text}|{reason}");
            }
        }
    }
}
