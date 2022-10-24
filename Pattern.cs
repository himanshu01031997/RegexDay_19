using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace RegexDemo { 
//{[a-z][A-Z]{1,7}
public class Pattern
    {
        public static string REGEX_PASSWORD = "^[A-Z][a-z]{7}$";
        public bool ValidateMobilePass(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
