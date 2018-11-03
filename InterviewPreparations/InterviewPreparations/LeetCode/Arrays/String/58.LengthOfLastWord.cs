using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LengthOfLastWord
    {
        /// <summary>
        /// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
        //  If the last word does not exist, return 0.
        //  Note: A word is defined as a character sequence consists of non-space characters only.
        //  Example:
        //  Input: "Hello World"
        //  Output: 5
        //  </summary>
        //  <param name="str"></param>
        /// <returns></returns>
        public static int LengthOfLastWordInString(string str)
        {
            int strResultLength = 0;
            int counter = str.Length - 1;
            bool charBeforeSapce = false;

            if (str.Length < 1)
            {
                return strResultLength;
            }

            while (counter >= 0)
            {
                if (str[counter] == ' ' && !charBeforeSapce)
                {
                    counter--;
                    continue;
                }

                if (str[counter] == ' ' && charBeforeSapce)
                {
                    break;
                }

                strResultLength++;
                counter--;
                charBeforeSapce = true;
            }

            return strResultLength;
        }
    }
}
