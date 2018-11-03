using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ImplementstrStr
    {

        /// <summary>
        /// Implement strStr().

        //        Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

        //        Example 1:

        //Input: haystack = "hello", needle = "ll"
        //        Output: 2
        //Example 2:


        //  Input: haystack = "aaaaa", needle = "bba"
        //  Output: -1
        //  </summary>
        //  <param name="haystack"></param>
        //  <param name="needle"></param>
        //  <returns></returns>
        public static int strStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            if (!string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            int l1 = haystack.Length;
            int l2 = needle.Length;

            for (int i = 0; i < l1 - l2 + 1; i++)
            {
                int count = 0;

                //compare the char
                while (count < l2 && haystack[i + count] == needle[count])
                {
                    count++;
                }

                if (count == l2)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
