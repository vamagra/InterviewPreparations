using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class DetectCapital
    {
        /// <summary>
        /// Given a word, you need to judge whether the usage of capitals in it is right or not.
        //  We define the usage of capitals in a word to be right when one of the following cases holds:
        //  All letters in this word are capitals, like "USA".
        //  All letters in this word are not capitals, like "leetcode".
        //  Only the first letter in this word is capital if it has more than one letter, like "Google".
        //  Otherwise, we define that this word doesn't use capitals in a right way.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static bool CheckCapital(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            int count = 0;
            int firstChar = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 && IsCapital(s[i]))
                {
                    firstChar = 1;
                    count++;
                }
                else if (IsCapital(s[i]))
                {
                    count++;
                }
            }

            // for both capital and lower case
            if (count == s.Length || count == 0)
            {
                return true;
            }

            // for camel case scenario
            if (count == 1 && firstChar == 1)
            {
                return true;
            }

            return false;
        }

        public static bool IsCapital(char ch)
        {
            return ch >= 'A' && ch <= 'Z' ? true : false;
        }
    }
}
