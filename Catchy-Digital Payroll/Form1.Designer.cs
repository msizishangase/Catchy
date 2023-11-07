namespace Catchy_Digital_Payroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnExit = new Button();
            btnForgotPassword = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            lnkSignUp = new LinkLabel();
            lblPasswordWarning = new Label();
            lblUsernameWarning = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnForgotPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lnkSignUp);
            panel1.Controls.Add(lblPasswordWarning);
            panel1.Controls.Add(lblUsernameWarning);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(356, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 443);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Image = Properties.Resources.icons8_exit_30;
            btnExit.Location = new Point(336, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 48);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = SystemColors.Control;
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnForgotPassword.ForeColor = Color.FromArgb(9, 75, 108);
            btnForgotPassword.Location = new Point(222, 257);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(188, 43);
            btnForgotPassword.TabIndex = 3;
            btnForgotPassword.Text = "Forgot password?";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(9, 75, 108);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(13, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 43);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(12, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 41);
            panel3.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(48, 11);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(349, 20);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.icons8_password_100__1_;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(14, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 41);
            panel2.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(48, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "catchypayroll@gmail.com";
            txtUsername.Size = new Size(349, 20);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.icons8_user_90__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkSignUp.Location = new Point(349, 9);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(65, 19);
            lnkSignUp.TabIndex = 1;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // lblPasswordWarning
            // 
            lblPasswordWarning.AutoSize = true;
            lblPasswordWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordWarning.ForeColor = Color.Red;
            lblPasswordWarning.Location = new Point(197, 174);
            lblPasswordWarning.Name = "lblPasswordWarning";
            lblPasswordWarning.Padding = new Padding(2, 0, 0, 0);
            lblPasswordWarning.Size = new Size(211, 16);
            lblPasswordWarning.TabIndex = 0;
            lblPasswordWarning.Text = "Password field cannot be empty";
            // 
            // lblUsernameWarning
            // 
            lblUsernameWarning.AutoSize = true;
            lblUsernameWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameWarning.ForeColor = Color.Red;
            lblUsernameWarning.Location = new Point(199, 111);
            lblUsernameWarning.Name = "lblUsernameWarning";
            lblUsernameWarning.Padding = new Padding(2, 0, 0, 0);
            lblUsernameWarning.Size = new Size(213, 16);
            lblUsernameWarning.TabIndex = 0;
            lblUsernameWarning.Text = "Username field cannot be empty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 84);
            label3.Name = "label3";
            label3.Padding = new Padding(2, 0, 0, 0);
            label3.Size = new Size(118, 16);
            label3.TabIndex = 0;
            label3.Text = "Login to continue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(266, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 0;
            label2.Text = "New user?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 65);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 0;
            label1.Text = "Welcome back!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(9, 75, 108);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(29, 29);
            label4.TabIndex = 1;
            label4.Text = "E";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 17);
            label5.Name = "label5";
            label5.Size = new Size(255, 20);
            label5.TabIndex = 2;
            label5.Text = "lectrical Coal Technologies";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(9, 75, 108);
            panel4.Location = new Point(12, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 3);
            panel4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 46);
            label6.Name = "label6";
            label6.Padding = new Padding(2, 0, 0, 0);
            label6.Size = new Size(298, 76);
            label6.TabIndex = 0;
            label6.Text = "Empower your business with CATCHY:\r\nThe ultimate payroll system for\r\nStream-lined Efficiency,\r\nAccuracy, and Peace of mind!";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "CatchyPay Version 2.0 - Exciting New Features!", "", "We're thrilled to introduce CatchyPay Version 2.0, packed with powerful enhancements to make managing payroll even easier and more efficient for you and your team. Here's what's new:", "", "1. Employee Self-Service Portal", "", "Empower your employees with a new self-service portal! They can now access their pay stubs, tax documents, and update personal information directly through CatchyPay, reducing administrative workload.", "2. Enhanced Reporting", "", "We've revamped our reporting capabilities! Generate detailed payroll reports, customize them to suit your needs, and export data effortlessly.", "3. Automated Tax Calculations", "", "Say goodbye to manual tax calculations! CatchyPay now automates tax calculations based on the latest tax laws and regulations, reducing errors and saving you time.", "4. Seamless Integration with Accounting Software", "", "We've improved our integration options. CatchyPay seamlessly connects with popular accounting software like QuickBooks and Xero, streamlining your financial processes.", "5. Employee Onboarding Module", "", "Simplify the onboarding process with our new module. Easily add new hires, collect necessary documentation, and set up payroll accounts in a few clicks.", "6. Enhanced Security", "", "We take your data security seriously. CatchyPay 2.0 includes advanced security features to safeguard your sensitive payroll information.", "7. User-Friendly Interface", "", "Our redesigned user interface is more intuitive than ever. Enjoy a smoother, more pleasant payroll management experience.", "8. Improved Customer Support", "", "We've expanded our customer support team to provide you with faster, more responsive assistance. We're here to help you every step of the way.", "9. Bug Fixes and Performance Improvements", "", "We've addressed various bugs and made performance enhancements to ensure CatchyPay runs smoothly.", resources.GetString("listBox1.Items"), "", "Thank you for choosing CatchyPay!" });
            listBox1.Location = new Point(12, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 289);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 443);
            Controls.Add(listBox1);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel lnkSignUp;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Button btnForgotPassword;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private ListBox listBox1;
        private Button btnExit;
        private Label lblPasswordWarning;
        private Label lblUsernameWarning;
    }
}