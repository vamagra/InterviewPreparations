using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ReverseStringLeaveSpecialCharacters
    {
        /// <summary>
        /// Given a string, that contains special character together with alphabets (‘a’ to ‘z’ and ‘A’ to ‘Z’), reverse the string in a way that special characters are not affected
        //  a.Input:   str = "a,b$c", Output : "c,b$a"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return s;
            }

            int start = 0;
            int end = s.Length;

            char[] chArray = s.ToCharArray();

            while (start < end)
            {
                if (!IsChar(chArray[start]))
                {
                    start++;
                }
                else if (!IsChar(chArray[end]))
                {
                    end--;
                }
                else
                {
                    char temp = chArray[start];
                    chArray[start] = chArray[end];
                    chArray[end] = temp;
                    start++;
                    end--;
                }
            }

            return new string(chArray);
        }

        private static bool IsChar(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
        }
    }
}
