using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (phoneNumber.Length == 10 && phoneNumber.StartsWith('0'))
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
            if (input.Contains("@") && input.Contains(".") && input.Length >= 5)
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
        public bool ValidUsername(string username)
        {
            if (username.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidatePassword(string password)
        {
            // Check for minimum length 
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Alert");
                return false;
            }

            // Check for at least one uppercase letter
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.", "Alert");
                return false;
            }

            // Check for at least one lowercase letter
            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.", "Alert");
                return false;
            }

            // Check for at least one digit
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one digit.", "Alert");
                return false;
            }

            // Check for the presence of special characters
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Password must contain at least one special character.", "Alert");
                return false;
            }

            // If all checks pass, the password is considered valid
            return true;
        }
    }
}
