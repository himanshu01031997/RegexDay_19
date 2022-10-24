using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace RegexDemo
{
    public class Pattern
    {
        public static string REGEX_Email = "^[A-Za-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public bool ValidateNamecode(string email)
        {
            return Regex.IsMatch(email, REGEX_Email);
        }
    }
}