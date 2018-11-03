using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace InterviewQuestions.LeetCode
{
    class ValidPhoneNumbersProgram
    {
        public static ArrayList ValidPhoneNumbersInFile(string fileName)
        {
            string line = string.Empty;

            ArrayList result = new ArrayList();
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while (line != sr.ReadLine())
                {
                    if (ValidPhone(line))
                    {
                        result.Add(line);
                    }
                }
            }

            return result;
        }

        private static bool ValidPhone(string phoneNumber)
        {
            string pattern = "^\\d{3}-\\d{3}-\\d{4}";
            Match match = Regex.Match(phoneNumber, pattern);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
