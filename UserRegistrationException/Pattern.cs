using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_Using_Exception
{
    public class Pattern
    {
        public string RegexName = "^[A-Z]{1}[a-z]{3,}$";

        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, RegexName);
        }
    }
}