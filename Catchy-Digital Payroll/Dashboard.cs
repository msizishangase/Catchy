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
    public partial class Dashboard : Form
    {
        bool sideBarExpand;
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btnUserProfile.Text = "  Logged in as" + "\n" + $"  {Username}";
        }

        private void NavBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                NavigationBar.Width += 10;
                if (NavigationBar.Width == NavigationBar.MaximumSize.Width)
                {
                    sideBarExpand = false;
                    NavBar.Stop();

                    btnDashboard.Text = "  Dashboard";
                    btnEmployees.Text = "  Employees";
                    btnAboutUs.Text = "  About Us";
                    btnReports.Text = "  Reports";
                    btnSettings.Text = "  Settings";
                    btnUserProfile.Text = "  Logged in as" + "\n" + $"  {Username}";
                }
            }
            else
            {
                btnEmployees.Text = "";
                btnDashboard.Text = "";
                btnAboutUs.Text = "";
                btnReports.Text = "";
                btnSettings.Text = "";
                btnUserProfile.Text = "";

                NavigationBar.Width -= 10;
                if (NavigationBar.Width == NavigationBar.MinimumSize.Width)
                {
                    sideBarExpand = true;
                    NavBar.Stop();
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        public string Username { get; set; }
    }
}
