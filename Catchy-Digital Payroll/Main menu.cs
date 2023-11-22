using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catchy_Digital_Payroll
{
    public partial class Main_menu : Form
    {
        int month, year;
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheweek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainter.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                dayContainter.Controls.Add(ucdays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainter.Controls.Clear();

            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheweek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainter.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                dayContainter.Controls.Add(ucdays);
            }

            if (lblDate.Text.Contains("December"))
            {
                btnPrevious.Visible = true;
                btnNext.Visible = false;
            }
            else if (lblDate.Text.Contains("January"))
            {
                btnNext.Visible = true;
                btnPrevious.Visible = false;
            }
            else
            {
                btnNext.Visible = true;
                btnPrevious.Visible = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainter.Controls.Clear();

            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheweek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainter.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                dayContainter.Controls.Add(ucdays);
            }

            if (lblDate.Text.Contains("December"))
            {
                btnPrevious.Visible = true;
                btnNext.Visible = false;
            }
            else if (lblDate.Text.Contains("January"))
            {
                btnNext.Visible = true;
                btnPrevious.Visible = false;
            }
            else
            {
                btnNext.Visible = true;
                btnPrevious.Visible = true;
            }
        }

        private void lnkNewEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_employee employee = new New_employee();
            employee.Show();
        }

        private void lnkReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
