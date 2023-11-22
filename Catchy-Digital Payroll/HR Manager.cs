using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Catchy_Digital_Payroll
{
    public class HR_Manager
    {
        string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Registration.txt";
        public string active = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Active.txt";
        public string reports = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Reports.txt";

        private string fullNames;
        private string surname;
        private string username;
        private string email;
        private string ID;
        private string title;
        private string phone;
        private string password;
        private string gender;

        public string propFullnames
        {
            get { return fullNames; }
            set
            {
                if (value != "")
                {
                    fullNames = value;
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
        public string propSurname
        {
            get { return surname; }
            set
            {
                if (value != "")
                {
                    surname = value;
                }
            }
        }
        public string propID
        {
            get { return ID; }
            set
            {
                if (value != "")
                {
                    ID = value;
                }
            }
        }
        public string propTitle
        {
            get { return title; }
            set
            {
                if (value != "")
                {
                    title = value;
                }
            }
        }
        public string propPhone
        {
            get { return phone; }
            set
            {
                if (value != "")
                {
                    phone = value;
                }
            }
        }

        public HR_Manager()
        {
            propFullnames = "";
            propUsername = "";
            propEmail = "";
            propPassword = "";
            propGender = "";
            propSurname = "";
            propID = "";
            propTitle = "";
            propPhone = "";
        }

        public HR_Manager(string fullName, string username, string email, string password, string gender, string surname, string id, string title, string phone)
        {
            propFullnames = fullName;
            propUsername = username;
            propEmail = email;
            propPassword = password;
            propGender = gender;
            propSurname = surname;
            propID = id;
            propTitle = title;
            propPhone = phone;
        }
        public void Register()
        {
            StreamWriter writer = new StreamWriter(file, true);

            using (writer)
            {
                writer.WriteLine($"{propFullnames}|{propSurname}|{propUsername}|{propEmail}|{propGender}|{propID}|{propTitle}|{propPhone}|{propPassword}");
            }
            MessageBox.Show("Your details are as follows:\n" +
                $"Name(s): {propFullnames}\n" +
                $"Surname: {propSurname}" +
                $"Username: {propUsername}\n" +
                $"Email: {propEmail}\n" +
                $"Password: {propPassword}", "DETAILS");
        }
        public string CurrentUser() //Determines the current logged in user
        {
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[9];
            string currentUser = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[2] == propUsername && Record[8] == propPassword)
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
            string lineRead;
            string[] Record;
            bool matches = false;

            using (StreamReader reader = new StreamReader(file))
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[2] == propUsername && Record[8] == propPassword)
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
            string[] Record = new string[9];
            string FullName = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[2] == propUsername && Record[8] == propPassword)
                    {
                        FullName = Record[0] + " " + Record[1];
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return FullName;
        }

        public bool UserAlreadyExist() //Returns true if user exists already and false if he/she doesn't
        {
            string lineRead;
            string[] Record;
            bool exist = false;

            using (StreamReader reader = new StreamReader(file))
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record.Length >= 4 && Record[2] == propUsername)
                    {
                        exist = true;
                        break;
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
            string[] Record = new string[9];
            string data = "";

            using (reader)
            {
                lineRead = reader.ReadLine();
                while (lineRead != null)
                {
                    Record = lineRead.Split('|');
                    if (Record[2] == propUsername)
                    {
                        data = $"{Record[0]}|{Record[1]}|{Record[2]}|{Record[3]}|{Record[4]}|{Record[5]}|{Record[6]}|{Record[7]}|{Record[8]}";
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
