using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace RegexDemo
{
    public  class Pattern
    {
        public static string REGEX_NAME = "^[A-Z][a-zA-Z]{2,15}";
        public  bool ValidateNamecode(string NAME)
        {
            return Regex.IsMatch(NAME, REGEX_NAME);
        }
    }
}
