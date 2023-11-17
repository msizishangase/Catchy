using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.WebSockets;

namespace Catchy_Digital_Payroll
{
    internal class Employee
    {
        public string employeeFile = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Employee.txt";
        public string importantEmployeeInfo = @"C:\Users\Msizi\OneDrive\Desktop\C# exercises\Catchy\TextFiles\Employee [displayed].txt";
        //Employee details
        private string name;
        private string surname;
        private string employeeID;
        private string email;
        private string phoneNumber;
        private string IDnumber;
        private string nationality;
        private string race;
        private string homeAddress;
        private string occupation;
        private string gender;

        //Next of kin details
        private string nextName;
        private string nextSurname;
        private string nextRelationship;
        private string nextEmail;
        private string nextPhoneNumber;

        public string propName { get => name; set => name = value; }
        public string propSurname { get => surname; set => surname = value; }
        public string propEmployeeID { get => employeeID; set => employeeID = value; }
        public string propEmail { get => email; set => email = value; }
        public string propPhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string propIDnumber { get => IDnumber; set => IDnumber = value; }
        public string propNationality { get => nationality; set => nationality = value; }
        public string propRace { get => race; set => race = value; }
        public string propHomeAddress { get => homeAddress; set => homeAddress = value; }
        public string propOccupation { get => occupation; set => occupation = value; }
        public string propNextName { get => nextName; set => nextName = value; }
        public string propNextSurname { get => nextSurname; set => nextSurname = value; }
        public string propNextRelationship { get => nextRelationship; set => nextRelationship = value; }
        public string propNextEmail { get => nextEmail; set => nextEmail = value; }
        public string propNextPhoneNumber { get => nextPhoneNumber; set => nextPhoneNumber = value; }
        public string propGender { get => gender; set => gender = value; }

        public Employee()
        {
            propName = "";
            propSurname = "";
            propEmployeeID = "";
            propEmail = "";
            propPhoneNumber = "";
            propIDnumber = "";
            propNationality = "";
            propRace = "";
            propHomeAddress = "";
            propOccupation = "";
            propNextName = "";
            propNextSurname = "";
            propNextRelationship = "";
            propNextEmail = "";
            propNextPhoneNumber = "";
            propGender = "";
        }

        public Employee(string name, string surname, string employeeID, string email, string phoneNumber, string iDnumber, string nationality, string race, string homeAddress, string occupation, string nextName, string nextSurname, string nextRelationship, string nextEmail, string nextPhoneNumber, string gender)
        {
            this.propName = name;
            this.propSurname = surname;
            this.propEmployeeID = employeeID;
            this.propEmail = email;
            this.propPhoneNumber = phoneNumber;
            this.propIDnumber = iDnumber;
            this.propNationality = nationality;
            this.propRace = race;
            this.propHomeAddress = homeAddress;
            this.propOccupation = occupation;
            this.propNextName = nextName;
            this.propNextSurname = nextSurname;
            this.propNextRelationship = nextRelationship;
            this.propNextEmail = nextEmail;
            this.propNextPhoneNumber = nextPhoneNumber;
            this.propGender = gender;
        }
        public void SaveEmployee()
        {
            using (StreamWriter sw = new StreamWriter(employeeFile, true))
            {
                sw.WriteLine($"{propName}|{propSurname}|{propEmployeeID}|{propEmail}|{propPhoneNumber}|{propIDnumber}|" +
                    $"{propNationality}|{propRace}|{propOccupation}|{propHomeAddress}|{propNextName}|{propNextSurname}|" +
                    $"{propNextRelationship}|{propNextEmail}|{propPhoneNumber}|{propGender}");
            }
        }
        public void SaveImportantInfo()
        {
            using (StreamWriter writer = new StreamWriter(importantEmployeeInfo, true))
            {
                writer.WriteLine($"{propName}|{propSurname}|{propEmployeeID}|{propEmail}|{propOccupation}");
            }
        }
    }
}
