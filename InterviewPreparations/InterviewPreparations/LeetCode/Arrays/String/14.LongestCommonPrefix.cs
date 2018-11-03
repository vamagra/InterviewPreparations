using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LongestCommonPrefix
    {
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// Longest common prefix for a pair of strings S1 and S2 is the longest string S which is the prefix of both S1 and S2.
        //  As an example, longest common prefix of "abcdefgh" and "abcefgh" is "abc".
        //  Given the array of strings, you need to find the longest S which is the prefix of ALL the strings in the array.
        //  Example:
        //  Given the array as:
        //  [
        //  "abcdefgh",
        //  "aefghijk",
        //  "abcefgh"
        // ]
        // </summary>
        // <param name="str"></param>
        /// <returns></returns>
        public static string LongestCommonPrefixString(string[] str)
        {
            string result = str[0];

            for (int i = 1; i < str.Length; i++)
            {
                result = LongestCommonPrefixUtil(result, str[i]);
            }

            return result;
        }

        public static string LongestCommonPrefixUtil(string str1, string str2)
        {
            StringBuilder result = new StringBuilder();

            int len1 = str1.Length;
            int len2 = str2.Length;

            for (int i = 0, j = 0; i <= len1 - 1 && j <= len2 - 1; i++, j++)
            {
                if (str1[i] != str2[j])
                {
                    break;
                }

                result.Append(str1[i]);
            }

            return result.ToString();
        }
    }
}
