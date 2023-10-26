﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Catchy_Digital_Payroll
{
    internal class HR_Manager
    {
        private string fullName;
        private string username;
        private string email;
        private string password;
        private string gender;
        private string profilePic;

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
                    email= value;
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
        public string propProfilePic
        {
            get { return profilePic; }
            set
            {
                if (value != "")
                {
                    profilePic = value;
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
            propProfilePic = "";
        }
        
        public HR_Manager(string fullName, string username, string email, string password, string gender, string profilePic)
        {
            propFullname = fullName;
            propUsername = username;
            propEmail = email;
            propPassword = password;
            propGender = gender;
            propProfilePic = "icons8-user-100.png";
        }
        public void Register()
        {
            string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Registration.txt";
            StreamWriter writer = new StreamWriter(file, true);

            using (writer)
            {
                writer.WriteLine($"{propFullname}|{propUsername}|{propGender}|{propEmail}|{propPassword}|{propProfilePic}");
            }
        }
        public bool LogIn()
        {
            string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Registration.txt";
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
                        //propProfilePic = Record[5];
                        matches = true;
                    }
                    else
                    {
                        matches = false;
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return matches;
        }

        public bool UserAlreadyExist()
        {
            string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Registration.txt";
            StreamReader reader = new StreamReader(file);
            string lineRead = "";
            string[] Record = new string[5];
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
                    }
                    else
                    {
                        return exist;
                    }
                    lineRead = reader.ReadLine();
                }
            }
            return exist;
        }
        public string CurrentUser()
        {
            string file = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Current User.txt";
            StreamWriter writer = new StreamWriter(file, true);
            

            using (writer)
            {
                writer.WriteLine($"{propUsername}|{propProfilePic}");
            }
            return propProfilePic;
        }
    }
}
