using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_Using_Exception
{
    class RegexPatterns
    {
        public string RegexName = "^[A-Z]{1}[a-z]{3,}$";
        public string RegexLastName = "^[A-Z]{1}[a-z]{3,}$";
        public string RegexEmail = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public string RegexPhoneNum = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, RegexName);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, RegexLastName);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, RegexEmail);
        }
        public bool ValidatePhoneNum(string phonenum)
        {
            return Regex.IsMatch(phonenum, RegexPhoneNum);
        }
    }
}