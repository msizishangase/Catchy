namespace Catchy_Digital_Payroll
{
    partial class Employee_List
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
            EmployeeList = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            lnkDeleteEmployee = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // EmployeeList
            // 
            EmployeeList.AllowUserToAddRows = false;
            EmployeeList.AllowUserToDeleteRows = false;
            EmployeeList.AllowUserToResizeColumns = false;
            EmployeeList.AllowUserToResizeRows = false;
            EmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeList.Location = new Point(12, 52);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowTemplate.Height = 25;
            EmployeeList.Size = new Size(861, 376);
            EmployeeList.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 75, 108);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 3);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(9, 75, 108);
            label1.Location = new Point(294, 8);
            label1.Name = "label1";
            label1.Size = new Size(236, 23);
            label1.TabIndex = 2;
            label1.Text = "Employees";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnkDeleteEmployee
            // 
            lnkDeleteEmployee.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkDeleteEmployee.Image = Properties.Resources.icons8_delete_30;
            lnkDeleteEmployee.ImageAlign = ContentAlignment.MiddleRight;
            lnkDeleteEmployee.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkDeleteEmployee.LinkColor = Color.Red;
            lnkDeleteEmployee.Location = new Point(677, 435);
            lnkDeleteEmployee.Name = "lnkDeleteEmployee";
            lnkDeleteEmployee.Size = new Size(196, 31);
            lnkDeleteEmployee.TabIndex = 4;
            lnkDeleteEmployee.TabStop = true;
            lnkDeleteEmployee.Text = "Delete employee";
            lnkDeleteEmployee.TextAlign = ContentAlignment.MiddleCenter;
            lnkDeleteEmployee.LinkClicked += lnkDeleteEmployee_LinkClicked;
            // 
            // Employee_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 475);
            Controls.Add(lnkDeleteEmployee);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(EmployeeList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee_List";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee_List";
            Load += Employee_List_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EmployeeList;
        private Panel panel1;
        private Label label1;
        private LinkLabel lnkDeleteEmployee;
    }
}