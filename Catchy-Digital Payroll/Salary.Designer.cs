namespace Catchy_Digital_Payroll
{
    partial class Salary
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
            lblTime = new Label();
            label1 = new Label();
            txtHoursWorked = new TextBox();
            txtRateOfPay = new TextBox();
            label2 = new Label();
            txtOverTimeHours = new TextBox();
            label3 = new Label();
            txtEmployeeID = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            lblGrossPay = new Label();
            lblNetPay = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lnkCalculate = new LinkLabel();
            panel3 = new Panel();
            lblUIF = new Label();
            lblMedicalAid = new Label();
            lblTotalDeductions = new Label();
            lblPension = new Label();
            lblIncomeTax = new Label();
            label18 = new Label();
            label15 = new Label();
            label11 = new Label();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 75, 108);
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 3);
            panel1.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(9, 75, 108);
            lblTime.Location = new Point(331, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(155, 19);
            lblTime.TabIndex = 6;
            lblTime.Text = "Salary calculation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(9, 75, 108);
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 8;
            label1.Text = "Hours worked";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoursWorked.Location = new Point(12, 120);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(256, 26);
            txtHoursWorked.TabIndex = 7;
            // 
            // txtRateOfPay
            // 
            txtRateOfPay.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRateOfPay.Location = new Point(12, 173);
            txtRateOfPay.Name = "txtRateOfPay";
            txtRateOfPay.Size = new Size(256, 26);
            txtRateOfPay.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(9, 75, 108);
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 8;
            label2.Text = "Rate of pay";
            // 
            // txtOverTimeHours
            // 
            txtOverTimeHours.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverTimeHours.Location = new Point(12, 224);
            txtOverTimeHours.Name = "txtOverTimeHours";
            txtOverTimeHours.Size = new Size(256, 26);
            txtOverTimeHours.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(9, 75, 108);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(228, 19);
            label3.TabIndex = 8;
            label3.Text = "Overtime hours [if applicable]";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeID.Location = new Point(12, 71);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(256, 26);
            txtEmployeeID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(9, 75, 108);
            label4.Location = new Point(12, 49);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 8;
            label4.Text = "Employee ID";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblGrossPay);
            panel2.Controls.Add(lblNetPay);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 97);
            panel2.TabIndex = 9;
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrossPay.ForeColor = Color.FromArgb(9, 75, 108);
            lblGrossPay.Location = new Point(135, 29);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(59, 19);
            lblGrossPay.TabIndex = 8;
            lblGrossPay.Text = "R 0.00";
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNetPay.ForeColor = Color.FromArgb(9, 75, 108);
            lblNetPay.Location = new Point(135, 63);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(59, 19);
            lblNetPay.TabIndex = 8;
            lblNetPay.Text = "R 0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(9, 75, 108);
            label7.Location = new Point(11, 63);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 8;
            label7.Text = "Net pay:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(9, 75, 108);
            label6.Location = new Point(11, 29);
            label6.Name = "label6";
            label6.Size = new Size(102, 19);
            label6.TabIndex = 8;
            label6.Text = "Gross pay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(9, 75, 108);
            label5.Location = new Point(55, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 8;
            label5.Text = "Gross/Net pay";
            // 
            // lnkCalculate
            // 
            lnkCalculate.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkCalculate.Image = Properties.Resources.icons8_arrow_20__2_;
            lnkCalculate.ImageAlign = ContentAlignment.MiddleRight;
            lnkCalculate.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCalculate.LinkColor = Color.FromArgb(9, 75, 108);
            lnkCalculate.Location = new Point(38, 265);
            lnkCalculate.Name = "lnkCalculate";
            lnkCalculate.Size = new Size(180, 23);
            lnkCalculate.TabIndex = 10;
            lnkCalculate.TabStop = true;
            lnkCalculate.Text = "Calculate salary";
            lnkCalculate.TextAlign = ContentAlignment.MiddleCenter;
            lnkCalculate.LinkClicked += lnkCalculate_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblUIF);
            panel3.Controls.Add(lblMedicalAid);
            panel3.Controls.Add(lblTotalDeductions);
            panel3.Controls.Add(lblPension);
            panel3.Controls.Add(lblIncomeTax);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(331, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 344);
            panel3.TabIndex = 9;
            // 
            // lblUIF
            // 
            lblUIF.AutoSize = true;
            lblUIF.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUIF.ForeColor = Color.FromArgb(9, 75, 108);
            lblUIF.Location = new Point(197, 126);
            lblUIF.Name = "lblUIF";
            lblUIF.Size = new Size(59, 19);
            lblUIF.TabIndex = 8;
            lblUIF.Text = "R 0.00";
            // 
            // lblMedicalAid
            // 
            lblMedicalAid.AutoSize = true;
            lblMedicalAid.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedicalAid.ForeColor = Color.FromArgb(9, 75, 108);
            lblMedicalAid.Location = new Point(197, 29);
            lblMedicalAid.Name = "lblMedicalAid";
            lblMedicalAid.Size = new Size(59, 19);
            lblMedicalAid.TabIndex = 8;
            lblMedicalAid.Text = "R 0.00";
            // 
            // lblTotalDeductions
            // 
            lblTotalDeductions.AutoSize = true;
            lblTotalDeductions.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDeductions.ForeColor = Color.FromArgb(9, 75, 108);
            lblTotalDeductions.Location = new Point(197, 213);
            lblTotalDeductions.Name = "lblTotalDeductions";
            lblTotalDeductions.Size = new Size(59, 19);
            lblTotalDeductions.TabIndex = 8;
            lblTotalDeductions.Text = "R 0.00";
            // 
            // lblPension
            // 
            lblPension.AutoSize = true;
            lblPension.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPension.ForeColor = Color.FromArgb(9, 75, 108);
            lblPension.Location = new Point(197, 171);
            lblPension.Name = "lblPension";
            lblPension.Size = new Size(59, 19);
            lblPension.TabIndex = 8;
            lblPension.Text = "R 0.00";
            // 
            // lblIncomeTax
            // 
            lblIncomeTax.AutoSize = true;
            lblIncomeTax.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncomeTax.ForeColor = Color.FromArgb(9, 75, 108);
            lblIncomeTax.Location = new Point(197, 77);
            lblIncomeTax.Name = "lblIncomeTax";
            lblIncomeTax.Size = new Size(59, 19);
            lblIncomeTax.TabIndex = 8;
            lblIncomeTax.Text = "R 0.00";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(9, 75, 108);
            label18.Location = new Point(11, 213);
            label18.Name = "label18";
            label18.Size = new Size(155, 19);
            label18.TabIndex = 8;
            label18.Text = "Total deductions:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(9, 75, 108);
            label15.Location = new Point(11, 171);
            label15.Name = "label15";
            label15.Size = new Size(81, 19);
            label15.TabIndex = 8;
            label15.Text = "Pension:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(9, 75, 108);
            label11.Location = new Point(11, 77);
            label11.Name = "label11";
            label11.Size = new Size(112, 19);
            label11.TabIndex = 8;
            label11.Text = "Income tax:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(9, 75, 108);
            label14.Location = new Point(11, 126);
            label14.Name = "label14";
            label14.Size = new Size(45, 19);
            label14.TabIndex = 8;
            label14.Text = "UIF:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(9, 75, 108);
            label12.Location = new Point(11, 29);
            label12.Name = "label12";
            label12.Size = new Size(108, 19);
            label12.TabIndex = 8;
            label12.Text = "Medical aid:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(9, 75, 108);
            label13.Location = new Point(93, -1);
            label13.Name = "label13";
            label13.Size = new Size(110, 20);
            label13.TabIndex = 8;
            label13.Text = "Deductions";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 475);
            Controls.Add(lnkCalculate);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(txtOverTimeHours);
            Controls.Add(label2);
            Controls.Add(txtRateOfPay);
            Controls.Add(label4);
            Controls.Add(txtEmployeeID);
            Controls.Add(label1);
            Controls.Add(txtHoursWorked);
            Controls.Add(lblTime);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            Text = "Salary";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTime;
        private Label label1;
        private TextBox txtHoursWorked;
        private TextBox txtRateOfPay;
        private Label label2;
        private TextBox txtOverTimeHours;
        private Label label3;
        private TextBox txtEmployeeID;
        private Label label4;
        private Panel panel2;
        private Label lblGrossPay;
        private Label lblNetPay;
        private Label label7;
        private Label label6;
        private Label label5;
        private LinkLabel lnkCalculate;
        private Panel panel3;
        private Label lblMedicalAid;
        private Label lblIncomeTax;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblUIF;
        private Label lblTotalDeductions;
        private Label lblPension;
        private Label label18;
        private Label label15;
        private Label label14;
    }
}