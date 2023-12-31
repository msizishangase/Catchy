﻿namespace Catchy_Digital_Payroll
{
    partial class Registration
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
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            txtFullname = new TextBox();
            label1 = new Label();
            txtEmailaddress = new TextBox();
            label2 = new Label();
            txtConfirmEmail = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtConfirmPassword = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnAddProfilePicture = new Button();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            radOther = new RadioButton();
            txtOtherGender = new TextBox();
            btnRegister = new Button();
            txtUsername = new TextBox();
            label9 = new Label();
            btnExit = new Button();
            btnBack = new Button();
            lblFullnameWarning = new Label();
            lblUsernameWarning = new Label();
            lblEmailWarning = new Label();
            lblConfirmEmailWarning = new Label();
            lblGenderWarning = new Label();
            lblPasswordWarning = new Label();
            lblConfirmPasswordWarning = new Label();
            lblOtherWarning = new Label();
            txtSurname = new TextBox();
            label10 = new Label();
            txtID = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtPhone = new TextBox();
            label13 = new Label();
            lblSurnameWarning = new Label();
            lblIdWarning = new Label();
            lblTitleWarning = new Label();
            lblPhoneNumberWarning = new Label();
            cmbTitle = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 9);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 4;
            label5.Text = "registration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(9, 75, 108);
            label4.Location = new Point(12, 1);
            label4.Name = "label4";
            label4.Size = new Size(31, 29);
            label4.TabIndex = 3;
            label4.Text = "R";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(9, 75, 108);
            panel4.Location = new Point(12, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(950, 3);
            panel4.TabIndex = 5;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(19, 79);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(286, 27);
            txtFullname.TabIndex = 6;
            txtFullname.TextChanged += txtFullname_TextChanged;
            txtFullname.Leave += txtFullname_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 7;
            label1.Text = "Name(s)";
            // 
            // txtEmailaddress
            // 
            txtEmailaddress.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailaddress.Location = new Point(19, 207);
            txtEmailaddress.Name = "txtEmailaddress";
            txtEmailaddress.Size = new Size(286, 27);
            txtEmailaddress.TabIndex = 6;
            txtEmailaddress.TextChanged += txtEmailaddress_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 185);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 7;
            label2.Text = "Email address";
            // 
            // txtConfirmEmail
            // 
            txtConfirmEmail.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmEmail.Location = new Point(19, 272);
            txtConfirmEmail.Name = "txtConfirmEmail";
            txtConfirmEmail.Size = new Size(286, 27);
            txtConfirmEmail.TabIndex = 6;
            txtConfirmEmail.TextChanged += txtConfirmEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 250);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 7;
            label3.Text = "Confirm email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 313);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 7;
            label6.Text = "Gender";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(650, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(650, 54);
            label7.Name = "label7";
            label7.Size = new Size(89, 19);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(650, 139);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(314, 27);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            txtConfirmPassword.Leave += txtConfirmPassword_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(650, 117);
            label8.Name = "label8";
            label8.Size = new Size(161, 19);
            label8.TabIndex = 7;
            label8.Text = "Confirm password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_100;
            pictureBox1.Location = new Point(20, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddProfilePicture);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(650, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 187);
            panel1.TabIndex = 9;
            // 
            // btnAddProfilePicture
            // 
            btnAddProfilePicture.FlatAppearance.BorderColor = Color.FromArgb(9, 75, 108);
            btnAddProfilePicture.FlatStyle = FlatStyle.Flat;
            btnAddProfilePicture.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProfilePicture.ForeColor = Color.Black;
            btnAddProfilePicture.Location = new Point(19, 143);
            btnAddProfilePicture.Name = "btnAddProfilePicture";
            btnAddProfilePicture.Size = new Size(279, 28);
            btnAddProfilePicture.TabIndex = 10;
            btnAddProfilePicture.Text = "Add profile pic (Optional)";
            btnAddProfilePicture.UseVisualStyleBackColor = true;
            btnAddProfilePicture.Click += btnAddProfilePicture_Click;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radMale.Location = new Point(26, 343);
            radMale.Name = "radMale";
            radMale.Size = new Size(65, 23);
            radMale.TabIndex = 10;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radFemale.Location = new Point(115, 343);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(87, 23);
            radFemale.TabIndex = 10;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            radOther.AutoSize = true;
            radOther.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radOther.Location = new Point(218, 343);
            radOther.Name = "radOther";
            radOther.Size = new Size(74, 23);
            radOther.TabIndex = 10;
            radOther.TabStop = true;
            radOther.Text = "Other";
            radOther.UseVisualStyleBackColor = true;
            radOther.CheckedChanged += radOther_CheckedChanged;
            // 
            // txtOtherGender
            // 
            txtOtherGender.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtherGender.Location = new Point(331, 339);
            txtOtherGender.Name = "txtOtherGender";
            txtOtherGender.Size = new Size(286, 27);
            txtOtherGender.TabIndex = 6;
            txtOtherGender.TextChanged += txtOtherGender_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(9, 75, 108);
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(650, 406);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(314, 37);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(19, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(286, 27);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(19, 120);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 7;
            label9.Text = "Username";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Image = Properties.Resources.icons8_exit_30;
            btnExit.Location = new Point(873, 448);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 37);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(9, 75, 108);
            btnBack.Image = Properties.Resources.icons8_back_30;
            btnBack.Location = new Point(12, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 37);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFullnameWarning
            // 
            lblFullnameWarning.AutoSize = true;
            lblFullnameWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullnameWarning.ForeColor = Color.Red;
            lblFullnameWarning.Location = new Point(115, 59);
            lblFullnameWarning.Name = "lblFullnameWarning";
            lblFullnameWarning.Padding = new Padding(2, 0, 0, 0);
            lblFullnameWarning.Size = new Size(114, 16);
            lblFullnameWarning.TabIndex = 14;
            lblFullnameWarning.Text = "Enter your name";
            // 
            // lblUsernameWarning
            // 
            lblUsernameWarning.AutoSize = true;
            lblUsernameWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameWarning.ForeColor = Color.Red;
            lblUsernameWarning.Location = new Point(169, 122);
            lblUsernameWarning.Name = "lblUsernameWarning";
            lblUsernameWarning.Padding = new Padding(2, 0, 0, 0);
            lblUsernameWarning.Size = new Size(119, 16);
            lblUsernameWarning.TabIndex = 14;
            lblUsernameWarning.Text = "Create username";
            // 
            // lblEmailWarning
            // 
            lblEmailWarning.AutoSize = true;
            lblEmailWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailWarning.ForeColor = Color.Red;
            lblEmailWarning.Location = new Point(169, 188);
            lblEmailWarning.Name = "lblEmailWarning";
            lblEmailWarning.Padding = new Padding(2, 0, 0, 0);
            lblEmailWarning.Size = new Size(112, 16);
            lblEmailWarning.TabIndex = 14;
            lblEmailWarning.Text = "Enter your email";
            // 
            // lblConfirmEmailWarning
            // 
            lblConfirmEmailWarning.AutoSize = true;
            lblConfirmEmailWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmEmailWarning.ForeColor = Color.Red;
            lblConfirmEmailWarning.Location = new Point(169, 250);
            lblConfirmEmailWarning.Name = "lblConfirmEmailWarning";
            lblConfirmEmailWarning.Padding = new Padding(2, 0, 0, 0);
            lblConfirmEmailWarning.Size = new Size(94, 16);
            lblConfirmEmailWarning.TabIndex = 14;
            lblConfirmEmailWarning.Text = "Confirm email";
            // 
            // lblGenderWarning
            // 
            lblGenderWarning.AutoSize = true;
            lblGenderWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderWarning.ForeColor = Color.Red;
            lblGenderWarning.Location = new Point(169, 316);
            lblGenderWarning.Name = "lblGenderWarning";
            lblGenderWarning.Padding = new Padding(2, 0, 0, 0);
            lblGenderWarning.Size = new Size(128, 16);
            lblGenderWarning.TabIndex = 14;
            lblGenderWarning.Text = "Select your gender";
            // 
            // lblPasswordWarning
            // 
            lblPasswordWarning.AutoSize = true;
            lblPasswordWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordWarning.ForeColor = Color.Red;
            lblPasswordWarning.Location = new Point(808, 60);
            lblPasswordWarning.Name = "lblPasswordWarning";
            lblPasswordWarning.Padding = new Padding(2, 0, 0, 0);
            lblPasswordWarning.Size = new Size(141, 16);
            lblPasswordWarning.TabIndex = 14;
            lblPasswordWarning.Text = "Enter your password";
            // 
            // lblConfirmPasswordWarning
            // 
            lblConfirmPasswordWarning.AutoSize = true;
            lblConfirmPasswordWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPasswordWarning.ForeColor = Color.Red;
            lblConfirmPasswordWarning.Location = new Point(808, 119);
            lblConfirmPasswordWarning.Name = "lblConfirmPasswordWarning";
            lblConfirmPasswordWarning.Padding = new Padding(2, 0, 0, 0);
            lblConfirmPasswordWarning.Size = new Size(156, 16);
            lblConfirmPasswordWarning.TabIndex = 14;
            lblConfirmPasswordWarning.Text = "Passwords don't match";
            // 
            // lblOtherWarning
            // 
            lblOtherWarning.AutoSize = true;
            lblOtherWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOtherWarning.ForeColor = Color.Red;
            lblOtherWarning.Location = new Point(477, 320);
            lblOtherWarning.Name = "lblOtherWarning";
            lblOtherWarning.Padding = new Padding(2, 0, 0, 0);
            lblOtherWarning.Size = new Size(134, 16);
            lblOtherWarning.TabIndex = 14;
            lblOtherWarning.Text = "Specify your gender";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.Location = new Point(327, 76);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(286, 27);
            txtSurname.TabIndex = 6;
            txtSurname.TextChanged += txtSurname_TextChanged;
            txtSurname.Leave += txtFullname_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(327, 54);
            label10.Name = "label10";
            label10.Size = new Size(83, 19);
            label10.TabIndex = 7;
            label10.Text = "Surname";
            // 
            // txtID
            // 
            txtID.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(327, 139);
            txtID.Name = "txtID";
            txtID.Size = new Size(286, 27);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            txtID.Leave += txtUsername_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(327, 117);
            label11.Name = "label11";
            label11.Size = new Size(96, 19);
            label11.TabIndex = 7;
            label11.Text = "ID number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(327, 182);
            label12.Name = "label12";
            label12.Size = new Size(44, 19);
            label12.TabIndex = 7;
            label12.Text = "Title";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(327, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(286, 27);
            txtPhone.TabIndex = 6;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(327, 247);
            label13.Name = "label13";
            label13.Size = new Size(129, 19);
            label13.TabIndex = 7;
            label13.Text = "Phone number";
            // 
            // lblSurnameWarning
            // 
            lblSurnameWarning.AutoSize = true;
            lblSurnameWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurnameWarning.ForeColor = Color.Red;
            lblSurnameWarning.Location = new Point(477, 54);
            lblSurnameWarning.Name = "lblSurnameWarning";
            lblSurnameWarning.Padding = new Padding(2, 0, 0, 0);
            lblSurnameWarning.Size = new Size(136, 16);
            lblSurnameWarning.TabIndex = 14;
            lblSurnameWarning.Text = "Enter your full name";
            lblSurnameWarning.Visible = false;
            // 
            // lblIdWarning
            // 
            lblIdWarning.AutoSize = true;
            lblIdWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdWarning.ForeColor = Color.Red;
            lblIdWarning.Location = new Point(477, 119);
            lblIdWarning.Name = "lblIdWarning";
            lblIdWarning.Padding = new Padding(2, 0, 0, 0);
            lblIdWarning.Size = new Size(119, 16);
            lblIdWarning.TabIndex = 14;
            lblIdWarning.Text = "Create username";
            lblIdWarning.Visible = false;
            // 
            // lblTitleWarning
            // 
            lblTitleWarning.AutoSize = true;
            lblTitleWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleWarning.ForeColor = Color.Red;
            lblTitleWarning.Location = new Point(477, 185);
            lblTitleWarning.Name = "lblTitleWarning";
            lblTitleWarning.Padding = new Padding(2, 0, 0, 0);
            lblTitleWarning.Size = new Size(112, 16);
            lblTitleWarning.TabIndex = 14;
            lblTitleWarning.Text = "Enter your email";
            lblTitleWarning.Visible = false;
            // 
            // lblPhoneNumberWarning
            // 
            lblPhoneNumberWarning.AutoSize = true;
            lblPhoneNumberWarning.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumberWarning.ForeColor = Color.Red;
            lblPhoneNumberWarning.Location = new Point(477, 247);
            lblPhoneNumberWarning.Name = "lblPhoneNumberWarning";
            lblPhoneNumberWarning.Padding = new Padding(2, 0, 0, 0);
            lblPhoneNumberWarning.Size = new Size(94, 16);
            lblPhoneNumberWarning.TabIndex = 14;
            lblPhoneNumberWarning.Text = "Confirm email";
            lblPhoneNumberWarning.Visible = false;
            // 
            // cmbTitle
            // 
            cmbTitle.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Items.AddRange(new object[] { "MR", "MISS", "MRS" });
            cmbTitle.Location = new Point(331, 206);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(282, 28);
            cmbTitle.TabIndex = 15;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 493);
            Controls.Add(cmbTitle);
            Controls.Add(lblConfirmPasswordWarning);
            Controls.Add(lblPasswordWarning);
            Controls.Add(lblOtherWarning);
            Controls.Add(lblGenderWarning);
            Controls.Add(lblPhoneNumberWarning);
            Controls.Add(lblConfirmEmailWarning);
            Controls.Add(lblTitleWarning);
            Controls.Add(lblEmailWarning);
            Controls.Add(lblIdWarning);
            Controls.Add(lblUsernameWarning);
            Controls.Add(lblSurnameWarning);
            Controls.Add(lblFullnameWarning);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(radOther);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label7);
            Controls.Add(txtOtherGender);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(txtConfirmEmail);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(txtEmailaddress);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(txtID);
            Controls.Add(txtUsername);
            Controls.Add(label10);
            Controls.Add(txtSurname);
            Controls.Add(label1);
            Controls.Add(txtFullname);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Panel panel4;
        private TextBox txtFullname;
        private Label label1;
        private TextBox txtEmailaddress;
        private Label label2;
        private TextBox txtConfirmEmail;
        private Label label3;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtConfirmPassword;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnAddProfilePicture;
        private RadioButton radMale;
        private RadioButton radFemale;
        private RadioButton radOther;
        private TextBox txtOtherGender;
        private Button btnRegister;
        private TextBox txtUsername;
        private Label label9;
        private Button btnExit;
        private Button btnBack;
        private Label lblFullnameWarning;
        private Label lblUsernameWarning;
        private Label lblEmailWarning;
        private Label lblConfirmEmailWarning;
        private Label lblGenderWarning;
        private Label lblPasswordWarning;
        private Label lblConfirmPasswordWarning;
        private Label lblOtherWarning;
        private TextBox txtSurname;
        private Label label10;
        private TextBox txtID;
        private Label label11;
        private Label label12;
        private TextBox txtPhone;
        private Label label13;
        private Label lblSurnameWarning;
        private Label lblIdWarning;
        private Label lblTitleWarning;
        private Label lblPhoneNumberWarning;
        private ComboBox cmbTitle;
    }
}