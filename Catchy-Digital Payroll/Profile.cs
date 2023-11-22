using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Catchy_Digital_Payroll
{
    public partial class Profile : Form
    {
        public string MyName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }

        string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Registration.txt";
        string filePath = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Active.txt";
        public Profile()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Dashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name
                    string selectedFileName = openFileDialog.FileName;

                    // Display the image in the PictureBox
                    pictureBox1.Image = Image.FromFile(selectedFileName);

                    // Set the image name using the property
                    dash.Picture = selectedFileName;

                }
            }
        }
        

        private void Profile_Load(object sender, EventArgs e)
        {
            string images = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Admin pictures.txt";

            Dashboard dash = new Dashboard();
            Validation validation = new Validation();

            string[] line = GetLastLine(filePath).Split('|');

            int age = 23 - int.Parse(line[5].Substring(0, 2));

            lblName.Text = line[0];
            lblSurname.Text = line[1];
            lblUsername.Text = line[2];
            lblEmail.Text = line[3];
            lblGender.Text = line[4];
            lblAge.Text = age.ToString();
            lblNumber.Text = line[7];
            lblTitle.Text = line[6];

            string reader = "";
            string[] data;

            using (StreamReader sr = new StreamReader(images))
            {
                reader = sr.ReadLine();
                while (reader != null)
                {
                    data = reader.Split('|');
                    if (data[0] == lblUsername.Text)
                    {
                        pictureBox1.ImageLocation = data[1];

                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                        break;
                    }
                    reader = sr.ReadLine();
                }
            }
        }

        // Gets the last line of the file
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
    }
}
