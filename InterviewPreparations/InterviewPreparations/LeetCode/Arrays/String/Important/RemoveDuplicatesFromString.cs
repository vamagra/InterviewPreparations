using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class RemoveDuplicatesFromString
    {
        public static string RemoveDuplicates(string s)
        {
            if (s.Length < 1)
            {
                return s;
            }

            char[] strArray = s.ToCharArray();

            Array.Sort(strArray);

            int counter = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1])
                {
                    strArray[counter] = s[i];
                    counter++;
                }
            }

            return strArray.ToString();
        }
    }
}
