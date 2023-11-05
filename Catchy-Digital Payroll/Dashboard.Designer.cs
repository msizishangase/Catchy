namespace Catchy_Digital_Payroll
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NavigationBar = new Panel();
            btnReports = new Button();
            btnUserProfile = new Button();
            btnSettings = new Button();
            btnAboutUs = new Button();
            btnEmployees = new Button();
            btnDashboard = new Button();
            NavBar = new System.Windows.Forms.Timer(components);
            NavigationBar.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationBar
            // 
            NavigationBar.BackColor = Color.FromArgb(9, 75, 108);
            NavigationBar.Controls.Add(btnReports);
            NavigationBar.Controls.Add(btnUserProfile);
            NavigationBar.Controls.Add(btnSettings);
            NavigationBar.Controls.Add(btnAboutUs);
            NavigationBar.Controls.Add(btnEmployees);
            NavigationBar.Controls.Add(btnDashboard);
            NavigationBar.Dock = DockStyle.Left;
            NavigationBar.Location = new Point(0, 0);
            NavigationBar.MaximumSize = new Size(174, 565);
            NavigationBar.MinimumSize = new Size(51, 565);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.Padding = new Padding(5);
            NavigationBar.Size = new Size(174, 565);
            NavigationBar.TabIndex = 2;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(9, 75, 108);
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.icons8_graph_report_30__1_;
            btnReports.ImageAlign = ContentAlignment.TopLeft;
            btnReports.Location = new Point(5, 185);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(164, 45);
            btnReports.TabIndex = 3;
            btnReports.Text = "  Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnUserProfile
            // 
            btnUserProfile.BackColor = Color.FromArgb(9, 75, 108);
            btnUserProfile.Dock = DockStyle.Bottom;
            btnUserProfile.FlatAppearance.BorderSize = 0;
            btnUserProfile.FlatStyle = FlatStyle.Flat;
            btnUserProfile.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserProfile.ForeColor = Color.White;
            btnUserProfile.Image = Properties.Resources.icons8_user_30__1_;
            btnUserProfile.ImageAlign = ContentAlignment.TopLeft;
            btnUserProfile.Location = new Point(5, 515);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(164, 45);
            btnUserProfile.TabIndex = 3;
            btnUserProfile.Text = "  User\r\n";
            btnUserProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnUserProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserProfile.UseVisualStyleBackColor = false;
            btnUserProfile.Click += btnUserProfile_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(9, 75, 108);
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.icons8_settings_30__3_;
            btnSettings.ImageAlign = ContentAlignment.TopLeft;
            btnSettings.Location = new Point(5, 140);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(164, 45);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.BackColor = Color.FromArgb(9, 75, 108);
            btnAboutUs.Dock = DockStyle.Top;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAboutUs.ForeColor = Color.White;
            btnAboutUs.Image = Properties.Resources.icons8_about_us_30__1_;
            btnAboutUs.ImageAlign = ContentAlignment.TopLeft;
            btnAboutUs.Location = new Point(5, 95);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(164, 45);
            btnAboutUs.TabIndex = 3;
            btnAboutUs.Text = "  About Us";
            btnAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAboutUs.UseVisualStyleBackColor = false;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(9, 75, 108);
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Image = Properties.Resources.icons8_employees_30__1_;
            btnEmployees.ImageAlign = ContentAlignment.TopLeft;
            btnEmployees.Location = new Point(5, 50);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(164, 45);
            btnEmployees.TabIndex = 3;
            btnEmployees.Text = "  Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(9, 75, 108);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.icons8_home_30__1_;
            btnDashboard.ImageAlign = ContentAlignment.TopLeft;
            btnDashboard.Location = new Point(5, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(164, 45);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // NavBar
            // 
            NavBar.Interval = 10;
            NavBar.Tick += NavBar_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(983, 565);
            Controls.Add(NavigationBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            NavigationBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel NavigationBar;
        private Button btnSettings;
        private Button btnEmployees;
        private Button btnDashboard;
        private Button btnReports;
        private Button btnUserProfile;
        private Button btnAboutUs;
        private System.Windows.Forms.Timer NavBar;
    }
}