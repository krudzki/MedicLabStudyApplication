using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicLabStudyApplication
{
    class LoginValidator
    {
        // declare properties
        public string Username { get; set; }
        public string Userpassword { get; set; }

        // initialise
        public LoginValidator(string user, string password)
        {
            this.Username = user;
            this.Userpassword = password;
        }

        // validate string
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if(Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // validate integer
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if(Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // clear user inputs
        private void ClearTexts(string user, string password)
        {
            user = String.Empty;
            password = String.Empty;
        }

        // method to check if eligible to be logged in
        internal bool IsLoggedIn(string user, string password)
        {
            // check user name empty
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;
            }

            // check user name is valid type
           else if (StringValidator(user) == true)
            {
                MessageBox.Show("Enter only text here");
                ClearTexts(user, password);
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Enter the password!");
                    return false;
                }

                // check password is valid
                else if (IntegerValidator(password) == true)
                {
                    MessageBox.Show("Enter only integer here");
                    return false;
                }

                // check password is correct
                else if(Userpassword != password)
                {
                    MessageBox.Show("Password is incorrect");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
                                                                       