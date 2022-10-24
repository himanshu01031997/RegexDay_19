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
        public static string REGEX_PASSWORD = "^[a-zA-Z0-9]{8}$";
        public bool ValidateMobilePass(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
