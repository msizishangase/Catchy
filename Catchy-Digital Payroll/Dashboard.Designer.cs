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
            btnMenu = new Button();
            NavBar = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblUser = new Label();
            lblTime = new Label();
            Time = new System.Windows.Forms.Timer(components);
            panelDisplay = new Panel();
            panel2 = new Panel();
            linkLogout = new LinkLabel();
            NavigationBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            NavigationBar.Controls.Add(btnMenu);
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
            btnReports.Location = new Point(5, 230);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(164, 45);
            btnReports.TabIndex = 3;
            btnReports.Text = "  Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            btnReports.Enter += btnReports_Enter;
            btnReports.Leave += btnReports_Leave;
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
            btnUserProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnUserProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserProfile.UseVisualStyleBackColor = false;
            btnUserProfile.Click += btnUserProfile_Click;
            btnUserProfile.Enter += btnUserProfile_Enter;
            btnUserProfile.Leave += btnUserProfile_Leave;
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
            btnSettings.Location = new Point(5, 185);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(164, 45);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Enter += btnSettings_Enter;
            btnSettings.Leave += btnSettings_Leave;
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
            btnAboutUs.Location = new Point(5, 140);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(164, 45);
            btnAboutUs.TabIndex = 3;
            btnAboutUs.Text = "  About Us";
            btnAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAboutUs.UseVisualStyleBackColor = false;
            btnAboutUs.Click += btnAboutUs_Click;
            btnAboutUs.Enter += btnAboutUs_Enter;
            btnAboutUs.Leave += btnAboutUs_Leave;
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
            btnEmployees.Location = new Point(5, 95);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(164, 45);
            btnEmployees.TabIndex = 3;
            btnEmployees.Text = "  Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            btnEmployees.Enter += btnEmployees_Enter;
            btnEmployees.Leave += btnEmployees_Leave;
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
            btnDashboard.Location = new Point(5, 50);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(164, 45);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Enter += btnDashboard_Enter;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(9, 75, 108);
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources.icons8_menu_30;
            btnMenu.ImageAlign = ContentAlignment.TopLeft;
            btnMenu.Location = new Point(5, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(164, 45);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "  CATCHY";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            btnMenu.Enter += btnMenu_Enter;
            btnMenu.Leave += btnMenu_Leave;
            // 
            // NavBar
            // 
            NavBar.Interval = 10;
            NavBar.Tick += NavBar_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblTime);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(174, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 28);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.icons8_user_100;
            pictureBox1.Location = new Point(598, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(9, 75, 108);
            lblUser.Location = new Point(634, 5);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(264, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "{NAME} {SURNAME} [ADMIN]";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(9, 75, 108);
            lblTime.Location = new Point(6, 5);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(61, 19);
            lblTime.TabIndex = 0;
            lblTime.Text = "14:00";
            // 
            // Time
            // 
            Time.Tick += Time_Tick;
            // 
            // panelDisplay
            // 
            panelDisplay.Dock = DockStyle.Top;
            panelDisplay.Location = new Point(174, 28);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(901, 514);
            panelDisplay.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(9, 75, 108);
            panel2.Controls.Add(linkLogout);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(174, 538);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 26);
            panel2.TabIndex = 0;
            // 
            // linkLogout
            // 
            linkLogout.Anchor = AnchorStyles.Right;
            linkLogout.AutoSize = true;
            linkLogout.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLogout.ForeColor = Color.White;
            linkLogout.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLogout.LinkColor = Color.White;
            linkLogout.Location = new Point(832, 3);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(66, 19);
            linkLogout.TabIndex = 0;
            linkLogout.TabStop = true;
            linkLogout.Text = "Log out";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 564);
            Controls.Add(panel2);
            Controls.Add(panelDisplay);
            Controls.Add(panel1);
            Controls.Add(NavigationBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            NavigationBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel NavigationBar;
        private Button btnSettings;
        private Button btnEmployees;
        private Button btnMenu;
        private Button btnReports;
        private Button btnUserProfile;
        private Button btnAboutUs;
        private System.Windows.Forms.Timer NavBar;
        private Button btnDashboard;
        private Panel panel1;
        private Label lblTime;
        private System.Windows.Forms.Timer Time;
        private PictureBox pictureBox1;
        private Label lblUser;
        private Panel panelDisplay;
        private Panel panel2;
        private LinkLabel linkLogout;
    }
}