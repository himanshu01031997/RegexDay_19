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
        public static string REGEX_MOBILENO = "^(91)[' ']?[7-9]{1}[0-9]{9}$";
        public bool ValidateMobilecode(string mobile)
        {
            return Regex.IsMatch(mobile, REGEX_MOBILENO);
        }
    }
}
