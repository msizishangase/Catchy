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
    public partial class New_employee : Form
    {
        public New_employee()
        {
            InitializeComponent();
        }

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {
            btnRemove.FlatAppearance.BorderSize = 1;
        }

        private void btnUpload_MouseHover(object sender, EventArgs e)
        {
            btnUpload.FlatAppearance.BorderSize = 1;
        }
    }
}
