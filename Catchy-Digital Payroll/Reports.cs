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
        DataTable data = new DataTable("data");
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            data.Columns.Add("Report name", typeof(string));
            data.Columns.Add("Description", typeof(string));
            dataReports.DataSource = data;
        }
    }
}
