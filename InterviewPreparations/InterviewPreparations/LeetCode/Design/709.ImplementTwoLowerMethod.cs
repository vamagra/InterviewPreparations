using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ImplementTwoLowerMethod
    {
        /// <summary>
        /// Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.
        //  Example 1:
        //  Input: "Hello"
        //  Output: "hello"
        //  Example 2:
        //  Input: "here"
        //  Output: "here"
        //  Example 3:
        //  Input: "LOVELY"
        //  Output: "lovely"
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string ToLower(string s)
        {
            if (s == null || s.Length < 1)
            {
                return s;
            }

            char[] chArray = s.ToCharArray();

            for (int i = 0; i < chArray.Length; i++)
            {
                if (chArray[i] >= 'A' && chArray[i] <= 'Z')
                {
                    chArray[i] = (char)(chArray[i] + 32);
                }
            }

            return new string(chArray);
        }
    }
}
