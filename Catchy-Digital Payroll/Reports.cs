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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            if (dataReports.ColumnCount == 0)
            {
                dataReports.Columns.Add("Report name", "Report name");
                dataReports.Columns.Add("Description", "Decription");
                dataReports.Columns.Add("Date", "Date");

                foreach (DataGridViewColumn column in dataReports.Columns)
                {
                    column.HeaderCell.Style.Font = new Font(dataReports.Font, FontStyle.Bold);
                    column.HeaderCell.Style.BackColor = Color.LightGray;
                }
            }
            LoadDataFromFile();
        }
        private void LoadDataFromFile()
        {
            HR_Manager hr = new HR_Manager();

            if (File.Exists(hr.reports))
            {
                dataReports.Rows.Clear(); // Clear existing rows

                string[] lines = File.ReadAllLines(hr.reports);

                foreach (string line in lines)
                {
                    string[] values = line.Split('|');

                    if (values.Length >= 2) // Ensure at least 2 values before adding to DataGridView
                        dataReports.Rows.Add(values[0], values[1], values[2]);
                }
            }
        }
    }
}
