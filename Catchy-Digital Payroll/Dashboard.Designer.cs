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
            profileTest1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)profileTest1).BeginInit();
            SuspendLayout();
            // 
            // profileTest1
            // 
            profileTest1.BorderStyle = BorderStyle.FixedSingle;
            profileTest1.Location = new Point(172, 136);
            profileTest1.Name = "profileTest1";
            profileTest1.Size = new Size(427, 287);
            profileTest1.TabIndex = 0;
            profileTest1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 49);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 465);
            Controls.Add(label1);
            Controls.Add(profileTest1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)profileTest1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profileTest1;
        private Label label1;
    }
}