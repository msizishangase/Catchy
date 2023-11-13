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
            Dashboard dash = new Dashboard();

            //lblName.Text = GetLastLine(filePath);
            string[] line = GetLastLine(filePath).Split('|');
            string[] fullname = line[0].Split(' ');
            string name = fullname[0];
            string surname = fullname[1];

            //{ propFullname}|{ propUsername}|{ propGender}|{ propEmail}|{ propPassword}
            lblName.Text = name;
            lblSurname.Text = surname;
            lblGender.Text = line[2];
            lblEmail.Text = line[3];
        }

        //Gets the last line of the file
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
