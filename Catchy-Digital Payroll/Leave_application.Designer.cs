namespace Catchy_Digital_Payroll
{
    partial class Leave_application
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtEmployeeName = new TextBox();
            cmbDepartment = new ComboBox();
            groupBox1 = new GroupBox();
            radAnnual = new RadioButton();
            radPaternity = new RadioButton();
            radMaternity = new RadioButton();
            radSchool = new RadioButton();
            radVacation = new RadioButton();
            radFamilyEmergency = new RadioButton();
            radSick = new RadioButton();
            label3 = new Label();
            txtSurpervisorName = new TextBox();
            label4 = new Label();
            lnkSubmit = new LinkLabel();
            label5 = new Label();
            returnDate = new DateTimePicker();
            label6 = new Label();
            effecticeDate = new DateTimePicker();
            label7 = new Label();
            cmbLeaveType = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 75, 108);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 3);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(9, 75, 108);
            label1.Location = new Point(270, 4);
            label1.Name = "label1";
            label1.Size = new Size(281, 23);
            label1.TabIndex = 1;
            label1.Text = "Leave application";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 52);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 2;
            label2.Text = "Employee name";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeName.Location = new Point(30, 74);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(298, 26);
            txtEmployeeName.TabIndex = 3;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(30, 176);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(298, 27);
            cmbDepartment.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radAnnual);
            groupBox1.Controls.Add(radPaternity);
            groupBox1.Controls.Add(radMaternity);
            groupBox1.Controls.Add(radSchool);
            groupBox1.Controls.Add(radVacation);
            groupBox1.Controls.Add(radFamilyEmergency);
            groupBox1.Controls.Add(radSick);
            groupBox1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 222);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reason for leave";
            // 
            // radAnnual
            // 
            radAnnual.AutoSize = true;
            radAnnual.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radAnnual.Location = new Point(4, 193);
            radAnnual.Name = "radAnnual";
            radAnnual.Size = new Size(120, 23);
            radAnnual.TabIndex = 6;
            radAnnual.TabStop = true;
            radAnnual.Text = "Annual leave";
            radAnnual.UseVisualStyleBackColor = true;
            // 
            // radPaternity
            // 
            radPaternity.AutoSize = true;
            radPaternity.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radPaternity.Location = new Point(5, 167);
            radPaternity.Name = "radPaternity";
            radPaternity.Size = new Size(93, 23);
            radPaternity.TabIndex = 6;
            radPaternity.TabStop = true;
            radPaternity.Text = "Paternity";
            radPaternity.UseVisualStyleBackColor = true;
            // 
            // radMaternity
            // 
            radMaternity.AutoSize = true;
            radMaternity.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radMaternity.Location = new Point(5, 141);
            radMaternity.Name = "radMaternity";
            radMaternity.Size = new Size(97, 23);
            radMaternity.TabIndex = 6;
            radMaternity.TabStop = true;
            radMaternity.Text = "Maternity";
            radMaternity.UseVisualStyleBackColor = true;
            // 
            // radSchool
            // 
            radSchool.AutoSize = true;
            radSchool.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radSchool.Location = new Point(5, 112);
            radSchool.Name = "radSchool";
            radSchool.Size = new Size(121, 23);
            radSchool.TabIndex = 6;
            radSchool.TabStop = true;
            radSchool.Text = "School leave";
            radSchool.UseVisualStyleBackColor = true;
            // 
            // radVacation
            // 
            radVacation.AutoSize = true;
            radVacation.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radVacation.Location = new Point(6, 83);
            radVacation.Name = "radVacation";
            radVacation.Size = new Size(91, 23);
            radVacation.TabIndex = 6;
            radVacation.TabStop = true;
            radVacation.Text = "Vacation";
            radVacation.UseVisualStyleBackColor = true;
            // 
            // radFamilyEmergency
            // 
            radFamilyEmergency.AutoSize = true;
            radFamilyEmergency.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radFamilyEmergency.Location = new Point(6, 54);
            radFamilyEmergency.Name = "radFamilyEmergency";
            radFamilyEmergency.Size = new Size(163, 23);
            radFamilyEmergency.TabIndex = 6;
            radFamilyEmergency.TabStop = true;
            radFamilyEmergency.Text = "Family emergency";
            radFamilyEmergency.UseVisualStyleBackColor = true;
            // 
            // radSick
            // 
            radSick.AutoSize = true;
            radSick.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radSick.Location = new Point(6, 25);
            radSick.Name = "radSick";
            radSick.Size = new Size(106, 23);
            radSick.TabIndex = 6;
            radSick.TabStop = true;
            radSick.Text = "Sick Leave";
            radSick.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 103);
            label3.Name = "label3";
            label3.Size = new Size(141, 19);
            label3.TabIndex = 2;
            label3.Text = "Surpervisor name";
            // 
            // txtSurpervisorName
            // 
            txtSurpervisorName.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurpervisorName.Location = new Point(30, 125);
            txtSurpervisorName.Name = "txtSurpervisorName";
            txtSurpervisorName.Size = new Size(298, 26);
            txtSurpervisorName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 154);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // lnkSubmit
            // 
            lnkSubmit.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkSubmit.Image = Properties.Resources.icons8_arrow_20__2_;
            lnkSubmit.ImageAlign = ContentAlignment.MiddleRight;
            lnkSubmit.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkSubmit.LinkColor = Color.FromArgb(9, 75, 108);
            lnkSubmit.Location = new Point(567, 422);
            lnkSubmit.Name = "lnkSubmit";
            lnkSubmit.Size = new Size(127, 23);
            lnkSubmit.TabIndex = 6;
            lnkSubmit.TabStop = true;
            lnkSubmit.Text = "Submit";
            lnkSubmit.TextAlign = ContentAlignment.MiddleCenter;
            lnkSubmit.LinkClicked += lnkSubmit_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(392, 154);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 2;
            label5.Text = "Return date";
            // 
            // returnDate
            // 
            returnDate.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            returnDate.Location = new Point(392, 176);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(298, 26);
            returnDate.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(392, 103);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 2;
            label6.Text = "Effective date";
            // 
            // effecticeDate
            // 
            effecticeDate.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            effecticeDate.Location = new Point(392, 125);
            effecticeDate.Name = "effecticeDate";
            effecticeDate.Size = new Size(298, 26);
            effecticeDate.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(392, 52);
            label7.Name = "label7";
            label7.Size = new Size(98, 19);
            label7.TabIndex = 2;
            label7.Text = "Department";
            // 
            // cmbLeaveType
            // 
            cmbLeaveType.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLeaveType.FormattingEnabled = true;
            cmbLeaveType.Items.AddRange(new object[] { "Paid", "UnPaid" });
            cmbLeaveType.Location = new Point(392, 74);
            cmbLeaveType.Name = "cmbLeaveType";
            cmbLeaveType.Size = new Size(298, 27);
            cmbLeaveType.TabIndex = 4;
            // 
            // Leave_application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 475);
            Controls.Add(effecticeDate);
            Controls.Add(returnDate);
            Controls.Add(lnkSubmit);
            Controls.Add(groupBox1);
            Controls.Add(cmbLeaveType);
            Controls.Add(cmbDepartment);
            Controls.Add(txtSurpervisorName);
            Controls.Add(txtEmployeeName);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Leave_application";
            Text = "Leave_application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtEmployeeName;
        private ComboBox cmbDepartment;
        private GroupBox groupBox1;
        private RadioButton radSick;
        private Label label3;
        private TextBox txtSurpervisorName;
        private RadioButton radMaternity;
        private RadioButton radSchool;
        private RadioButton radVacation;
        private RadioButton radFamilyEmergency;
        private Label label4;
        private RadioButton radAnnual;
        private RadioButton radPaternity;
        private LinkLabel lnkSubmit;
        private Label label5;
        private DateTimePicker returnDate;
        private Label label6;
        private DateTimePicker effecticeDate;
        private Label label7;
        private ComboBox cmbLeaveType;
    }
}