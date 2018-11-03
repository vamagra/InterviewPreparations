using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class InterleavingString
    {
        /// <summary>
        /// Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.

        //  For example,
        //  Given:
        //  s1 = "aabcc",
        //  s2 = "dbbca",
        //  When s3 = "aadbbcbcac", return true.
        //  When s3 = "aadbbbaccc", return false.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static bool IsInterleaving(string s1, string s2, string s3)
        {
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s3))
            {
                return true;
            }

            if ((string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) && !string.IsNullOrEmpty(s3))
            {
                return false;
            }

            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            bool result1 = false;
            bool result2 = false;

            if (s1.Length > 0 && s1[0] == s3[0])
            {
                result1 = IsInterleaving(s1.Substring(1), s2, s3.Substring(1));
            }

            if (s2.Length > 0 && s2[0] == s3[0])
            {
                result2 = IsInterleaving(s1, s2.Substring(1), s3.Substring(1));
            }

            return result1 || result2;
        }

        public static bool IsInterleavingIterative(string s1, string s2, string s3)
        {
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s3))
            {
                return true;
            }

            if ((string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) && !string.IsNullOrEmpty(s3))
            {
                return false;
            }

            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            int i = 0;
            int j = 0;

            for (int k = 0; k < s3.Length; k++)
            {
                if (i <= s1.Length - 1 && s1[i] == s3[k])
                {
                    i++;
                }

                if (j <= s2.Length - 1 && s2[j] == s3[k])
                {
                    j++;
                }

                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
