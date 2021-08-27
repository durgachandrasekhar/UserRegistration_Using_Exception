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

        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, RegexName);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, RegexLastName);
        }

    }
}