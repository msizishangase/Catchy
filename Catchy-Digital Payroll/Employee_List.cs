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
    public partial class Employee_List : Form
    {
        public Employee_List()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable("data");
        private void Employee_List_Load(object sender, EventArgs e)
        {
            LoadDataFromFile();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Surname", typeof(string));
            data.Columns.Add("Employee ID", typeof(string));
            data.Columns.Add("Email", typeof(string));
            data.Columns.Add("Occupation", typeof(string));
            EmployeeList.DataSource = data;
        }
        private void LoadDataFromFile()
        {
            Employee emp = new Employee();
            // Load data from text file
            if (File.Exists(emp.employeeFile))
            {
                EmployeeList.Rows.Clear(); // Clear existing rows

                string[] lines = File.ReadAllLines(emp.employeeFile);

                foreach (string line in lines)
                {
                    string[] values = line.Split('|');

                    if (values.Length >= 5) // Ensure at least 5 values before adding to DataGridView
                        EmployeeList.Rows.Add(values[0], values[1], values[2], values[3], values[4], values[5]);
                }
            }
        }
    }
}
