using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Catchy_Digital_Payroll
{
    public class HR_Manager
    {
        string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Registration.txt";
        public string active = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Active.txt";
        public string reports = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Reports.txt";

        private string fullName;
        private string username;
        private string email;
        private string password;
        private string gender;

        public string propFullname
        {
            get { return fullName; }
            set
            {
                if (value != "")
                {
                    fullName = value;
                }
            }
        }
        public string propUsername
        {
            get { return username; }
            set
            {
                if (value != "")
                {
                    username = value;
                }
            }
        }
        public string propEmail
        {
            get { return email; }
            set
            {
                if (value != "")
                {
                    email = value;
                }
            }
        }
        public string propPassword
        {
            get { return password; }
            set
            {
                if (value != "")
                {
                    password = value;
                }
            }
        }
        public string propGender
        {
            get { return gender; }
            set
            {
                if (value != "")
                {
                    gender = value;
                }
            }
        }

        public HR_Manager()
        {
            propFullname = "";
            propUsername = "";
            propEmail = "";
            propPassword = "";
            propGender = "";
        }

        public HR_Manager(string fullName, string username, string email, string password, string gender)
        {
            propFullname = fullName;
            propUsername = username;
            propEmail = email;
            propPassword = password;
            propGender = gender;

        }
        public void Register()
        {
            StreamWriter writer = new StreamWriter(file, true);

            using (writer)
            {
                writer.WriteLine($"{propFullname}|{propUsername}|{propGender}|{propEmail}|{propPassword}");
            }
            MessageBox.Show("Your details are as follows:\n" +
                $"Full name: {propFullname}\n" +
                $"Username: {propUsername}\n" +
                $"Email: {propEmail}\n" +
                $"Password: {propPassword}", "DETAILS");
        }
        public string CurrentUser() //Determines the current logged in user
        {
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[6];
            string currentUser = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[1] == propUsername && Record[4] == propPassword)
                    {
                        currentUser = propUsername;
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return currentUser;
        }
        public bool LogIn() //Returns true if username matches the password and false if it does not
        {
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[6];
            bool matches = false;

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[1] == propUsername && Record[4] == propPassword)
                    {
                        matches = true;
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return matches;
        }
        public string GetFullName()
        {
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[6];
            string FullName = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[1] == propUsername && Record[4] == propPassword)
                    {
                        FullName = Record[0];
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return FullName;
        }

        public bool UserAlreadyExist() //Returns true if user exists already and false if he/she doesn't
        {
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[6];
            bool exist = false;

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[1] == propUsername)
                    {
                        exist = true;
                        break;
                    }
                    else
                    {
                        exist = false;
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return exist;
        }
        public string Display()
        {
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[6];
            string data = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[1] == propUsername)
                    {
                        data = $"{Record[0]}|{Record[1]}|{Record[2]}|{Record[3]}";
                        break;
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return data;
        }
        public void Active()
        {
            using (StreamWriter sw = new StreamWriter(active, true))
            {
                sw.WriteLine(Display());
            }
        }
        public void AddReport(string reportName, string description, string date)
        {
            using (StreamWriter sw = new StreamWriter(reports, true))
            {
                sw.WriteLine($"{reportName}|{description}|{date}");
            }
        }
    }
}
