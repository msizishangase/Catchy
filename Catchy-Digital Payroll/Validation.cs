using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catchy_Digital_Payroll
{
    internal class Validation
    {
        public bool IsEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (!IsNumeric(phoneNumber))
            {
                return false;
            }

            // Check if the numeric string has exactly 10 digits
            if (phoneNumber.Length == 10)
            {
                return true;
            }

            return false;
        }
        public bool IsNumeric(string input)
        {
            // Check if all the characters are in a numeric form
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsValidName(string input)
        {
            //check if all characters are in alphabetical form
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsValidEmail(string input)
        {
            if (input.Contains("@") && input.Contains("."))
            {
                return true;
            }
            return false;
        }
        public bool ValidID(string input)
        {
            if (IsNumeric(input))
            {
                if (input.Length == 13)
                {
                    return true;
                }
            }
            return false;
        }
        public string Gender(string ID)
        {
            double check = double.Parse(ID.Substring(6, 4));
            if (check < 5000)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }
    }
}
