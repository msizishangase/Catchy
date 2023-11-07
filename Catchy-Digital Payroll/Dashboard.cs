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
            NavBar.Start();
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

                    btnMenu.Text = "  CATCHY";
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
                btnMenu.Text = "";
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            NavBar.Start();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Enter(object sender, EventArgs e)
        {
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnMenu_Leave(object sender, EventArgs e)
        {
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        private void btnReports_Enter(object sender, EventArgs e)
        {
            btnReports.FlatAppearance.BorderSize = 1;
            btnReports.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnEmployees_Enter(object sender, EventArgs e)
        {
            btnEmployees.FlatAppearance.BorderSize = 1;
            btnEmployees.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnAboutUs_Enter(object sender, EventArgs e)
        {
            btnAboutUs.FlatAppearance.BorderSize = 1;
            btnAboutUs.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnSettings_Enter(object sender, EventArgs e)
        {
            btnSettings.FlatAppearance.BorderSize = 1;
            btnSettings.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnUserProfile_Enter(object sender, EventArgs e)
        {
            btnUserProfile.FlatAppearance.BorderSize = 1;
            btnUserProfile.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnEmployees_Leave(object sender, EventArgs e)
        {
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        private void btnAboutUs_Leave(object sender, EventArgs e)
        {
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        private void btnReports_Leave(object sender, EventArgs e)
        {
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        private void btnUserProfile_Leave(object sender, EventArgs e)
        {
            btnUserProfile.FlatAppearance.BorderSize = 0;
            btnUserProfile.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnDashboard_Enter(object sender, EventArgs e)
        {
            btnDashboard.FlatAppearance.BorderSize = 1;
            btnDashboard.BackColor = ColorTranslator.FromHtml("18, 65, 80");
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.BackColor = ColorTranslator.FromHtml("9, 75, 108");
        }

        public string Username { get; set; }
    }
}
