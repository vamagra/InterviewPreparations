using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseStringII
    {
        /// <summary>
        /// Given a string and an integer k, you need to reverse the first k characters for every 2k characters 
        //  counting from the start of the string. 
        //  If there are less than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, 
        //  then reverse the first k characters and left the other as original.
        //  Example:
        //  Input: s = "abcdefg", k = 2
        //  Output: "bacdfeg"
        //  Restrictions:
        //  The string consists of lower English letters only.
        //  Length of the given string and k will in the range[1, 10000]
        //  </summary>
        //  <param name="s"></param>
        //  <param name="k"></param>
        //  <returns></returns>
        public static string ReverseStringKChar(string s, int k)
        {
            if (s.Length < 1)
            {
                return "";
            }

            if (s.Length < k)
            {
                return s;
            }

            int start = 0;
            char[] chArray = s.ToCharArray();

            while (start < s.Length)
            {
                Reverse(chArray, start, k);
                start = start + 2 * k;
            }

            return new string(chArray);
        }

        private static void Reverse(char[] chArray, int start, int k)
        {
            int end = Math.Min(start + k - 1, chArray.Length - 1);

            while (start < end)
            {
                char temp = chArray[start];
                chArray[start] = chArray[end];
                chArray[end] = temp;
                start++;
                end--;
            }
        }

    }
}
