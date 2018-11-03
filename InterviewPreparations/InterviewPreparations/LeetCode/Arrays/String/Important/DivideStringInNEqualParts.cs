using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class DivideStringInNEqualParts
    {
        /// <summary>
        /// Write a program to print N equal parts of a given string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<string> DivideString(string s, int n)
        {
            List<string> list = new List<string>();
            if (string.IsNullOrEmpty(s) || n < 1)
            {
                return list;
            }

            if (s.Length % n != 0)
            {
                return list;
            }

            int part = s.Length / n;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == part)
                {
                    list.Add(s.Substring(0, i));
                }
            }

            return list;
        }
    }
}
