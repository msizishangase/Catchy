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
        private void Employee_List_Load(object sender, EventArgs e)
        {
            if (EmployeeList.ColumnCount == 0)
            {
                EmployeeList.Columns.Add("Name", "Name");
                EmployeeList.Columns.Add("Surname", "Surname");
                EmployeeList.Columns.Add("Employee ID", "Employee id");
                EmployeeList.Columns.Add("Email", "Email");
                EmployeeList.Columns.Add("Occupation", "Occupation");

                foreach (DataGridViewColumn column in EmployeeList.Columns)
                {
                    column.HeaderCell.Style.Font = new Font(EmployeeList.Font, FontStyle.Bold);
                    column.HeaderCell.Style.BackColor = Color.LightGray;
                }
            }

            LoadDataFromFile();
        }
        private void LoadDataFromFile()
        {
            Employee emp = new Employee();
            // Load EmployeeList from text file
            if (File.Exists(emp.importantEmployeeInfo))
            {
                EmployeeList.Rows.Clear(); // Clear existing rows

                string[] lines = File.ReadAllLines(emp.importantEmployeeInfo);

                foreach (string line in lines)
                {
                    string[] values = line.Split('|');

                    if (values.Length >= 4) // Ensure at least 4 values before adding to DataGridView
                        EmployeeList.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                }
            }
        }

        private void lnkDeleteEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Delete selected row from DataGridView
            if (EmployeeList.SelectedRows.Count > 0)
            {
                string employeeName = EmployeeList.SelectedRows[0].Cells[0].Value.ToString();
                string employeeSurname = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();

                // Ask for confirmation before deleting
                if (MessageBox.Show($"Are you sure you want to delete the employee '{employeeName} {employeeSurname}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EmployeeList.Rows.RemoveAt(EmployeeList.SelectedRows[0].Index);

                    HR_Manager hr = new HR_Manager();

                    DateTime date = DateTime.Now;

                    string[] line = GetLastLine(hr.active).Split('|');

                    hr.AddReport("Employee deletion", $"{line[0]} deleted {employeeName} {employeeSurname} from the system", date.ToLocalTime().ToString());

                    SaveDataToFile();
                }
            }
            else
            {
                MessageBox.Show("Select the employee you want to delete", "Invalid action");
            }
        }
        public void SaveDataToFile()
        {
            Employee emp = new Employee();

            // Save data to text file
            List<string> lines = new List<string>();

            foreach (DataGridViewRow row in EmployeeList.Rows)
            {
                string line = $"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}|{row.Cells[3].Value}|{row.Cells[4].Value}";
                lines.Add(line);
            }

            File.WriteAllLines(emp.importantEmployeeInfo, lines);
        }
        public string GetLastLine(string filePath)
        {
            string lastLine = null;

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        lastLine = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
            return lastLine;
        }

        //private void btnAddEmployee_Click(object sender, EventArgs e)
        //{
        //    //Dashboard dashboard = new Dashboard();
        //    //dashboard.openChildForm(new New_employee(), dashboard.PanelDisplay);

        //    New_employee employee = new New_employee();
        //    employee.Show();
        //}
        
    }
}
