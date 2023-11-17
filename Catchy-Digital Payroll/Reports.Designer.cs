namespace Catchy_Digital_Payroll
{
    partial class Reports
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
            dataReports = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 75, 108);
            panel1.Location = new Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 3);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(9, 75, 108);
            label1.Location = new Point(282, 12);
            label1.Name = "label1";
            label1.Size = new Size(273, 23);
            label1.TabIndex = 1;
            label1.Text = "Reports";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataReports
            // 
            dataReports.AllowUserToAddRows = false;
            dataReports.AllowUserToDeleteRows = false;
            dataReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReports.Location = new Point(12, 47);
            dataReports.Name = "dataReports";
            dataReports.RowTemplate.Height = 25;
            dataReports.Size = new Size(861, 390);
            dataReports.TabIndex = 2;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 475);
            Controls.Add(dataReports);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataReports;
    }
}