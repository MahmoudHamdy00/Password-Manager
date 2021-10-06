using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    class PasswordManager
    {
        public static string specialChars = "~!@#$%^&*(){}\"\\/:<>?.";

        public static string get_strong_password(int length, bool includeLowercaseCharacters, bool includeUppercaseCharacters, bool includeSymbols, bool includeNumbers)
        {
            int numOfTries = 10;
            string tempPassword = "";
            do
            {
                if (!includeLowercaseCharacters && !includeUppercaseCharacters && !includeSymbols && !includeNumbers) throw new Exception("You have to check one type of letters at least");
                tempPassword = generate_password(length, includeLowercaseCharacters, includeUppercaseCharacters, includeSymbols, includeNumbers);
                if (is_strong_password(tempPassword)) return tempPassword;
                Thread.Sleep(1);
            } while (--numOfTries > 0);
            return tempPassword;
        }
        public static string generate_password(int length = 8, bool includeLowercaseCharacters = true, bool includeUppercaseCharacters = true, bool includeSymbols = true, bool includeNumbers = true)
        {
            string s = "";
            for (int ch = 'A'; ch <= 'Z'; ++ch)
            {
                if (includeLowercaseCharacters)
                    s += (char)(ch + 32);
                if (includeUppercaseCharacters)
                    s += (char)ch;
            }
            if (includeNumbers)
                for (int ch = '0'; ch <= '9'; ++ch)
                    s += (char)ch;

            if (includeSymbols)
                s += specialChars;

            string pass = "";
            Random rnd = new Random();
            while (pass.Length < length)
            {
                pass += s[rnd.Next(s.Length)];
            }
            return pass;
        }
        public static bool is_strong_password(string password)
        {
            Regex expression = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[~!@#$%^&*(){}\"\\/:<>?.]).{8,}$");
            return expression.IsMatch(password);
        }
    }
}
