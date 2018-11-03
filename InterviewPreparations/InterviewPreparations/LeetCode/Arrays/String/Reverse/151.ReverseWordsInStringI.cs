using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ReverseWordsInStringI
    {
        /// <summary>
        /// Given an input string, reverse the string word by word.
        //  Example:  
        //  Input: "the sky is blue",
        //  Output: "blue is sky the".
        //  Note:
        //  A word is defined as a sequence of non-space characters.
        //  Input string may contain leading or trailing spaces.However, your reversed string should not contain leading or trailing spaces.
        //  You need to reduce multiple spaces between two words to a single space in the reversed string.
        //  Follow up: For C programmers, try to solve it in-place in O(1) space.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string ReverseWords(string s)
        {
            if (s == null || s.Length == 0)
            {
                return "";
            }

            string[] array = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (!array[i].Equals(""))
                {
                    sb.Append(array[i] + " ");
                }
            }

            return sb.Length == 0 ? "" : sb.ToString().Substring(0, sb.ToString().Length - 1);
        }
    }
}
