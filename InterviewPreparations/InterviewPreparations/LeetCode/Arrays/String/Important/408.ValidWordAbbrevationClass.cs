using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ValidWordAbbrevationClass
    {
        /// <summary>
        /// Given a non-empty string s and an abbreviation abbr, return whether the string matches with the given abbreviation.
        //  A string such as "word" contains only the following valid abbreviations:
        //  ["word", "1ord", "w1rd", "wo1d", "wor1", "2rd", "w2d", "wo2", "1o1d", "1or1", "w1r1", "1o2", "2r1", "3d", "w3", "4"]
        //  Notice that only the above abbreviations are valid abbreviations of the string "word". Any other string is not a valid abbreviation of "word".
        //  Note:
        //  Assume s contains only lowercase letters and abbr contains only lowercase letters and digits.
        //  Example 1:
        //  Given s = "internationalization", abbr = "i12iz4n":
        //  Return true.
        //  Example 2:
        //  Given s = "apple", abbr = "a2e":
        //  Return false.
        //  </summary>
        //  <param name="s"></param>
        //  <param name="abbr"></param>
        //  <returns></returns>
        public static bool IsValidWordAbbr(string s, string abbr)
        {
            if (s == null || s.Length < 1)
            {
                return false;
            }

            int i = 0;
            int j = 0;

            while (j < abbr.Length)
            {
                if (IsDigit(abbr[j]))
                {
                    int number = 0;

                    while (j < abbr.Length && IsDigit(abbr[j]))
                    {
                        number = number * 10 + abbr[j] - '0';
                        j++;
                    }

                    i = i + number;
                }
                else if (s[i] == abbr[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsDigit(char ch)
        {
            return (ch >= '0' && ch <= '9');
        }
    }
}
