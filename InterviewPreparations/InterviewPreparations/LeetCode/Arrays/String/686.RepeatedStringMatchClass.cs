using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RepeatedStringMatchClass
    {
        /// <summary>
        /// Given two strings A and B, find the minimum number of times A has to be repeated such that B is a substring of it. 
        //  If no such solution, return -1.
        //  For example, with A = "abcd" and B = "cdabcdab".
        //  Return 3, because by repeating A three times(“abcdabcdabcd”), B is a substring of it; 
        //  and B is not a substring of A repeated two times("abcdabcd").
        //  Note:
        //  The length of A and B will be between 1 and 10000.
        //  </summary>
        //  <param name="A"></param>
        //  <param name="B"></param>
        /// <returns>https://discuss.leetcode.com/topic/105671/accepted-c-solution-inspired-by-other-solutions</returns>
        public static int CountOfRepeatedString(string A, string B)
        {
            StringBuilder sbResult = new StringBuilder();
            sbResult.Append(A);

            // get the count of length that how many times we need to append the A in StringBuilder
            int lengthCount = (B.Length / A.Length);

            // Append the string in StringBuilder till lengthCount so A will be greater length than B string 
            int counter = 1;
            while (counter < lengthCount)
            {
                sbResult.Append(A);
                counter++;
            }

            // this is counter store, How many times we have added the string in StringBuilder
            int repCount = counter;

            // Check if the B string is not subString of StringBuilder string
            while (sbResult.ToString().IndexOf(B) < 0)
            {
                sbResult.Append(A);

                if (sbResult.Length > B.Length && sbResult.ToString().IndexOf(B) < 0)
                {
                    return -1;
                }

                repCount++;
            }

            return repCount;
        }

        public static bool IsSubstring(string mainString, string subString)
        {
            if (subString.Length > mainString.Length)
            {
                return false;
            }

            int subStrCounter = 0;

            for (int i = 0; i < mainString.Length; i++)
            {
                if (subStrCounter < subString.Length && subString[subStrCounter] == mainString[i])
                {
                    subStrCounter++;
                }
                else
                {
                    subStrCounter = 0;
                }
            }

            return subStrCounter == subString.Length;
        }
    }
}
