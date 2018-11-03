using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class IsSubsequence
    {
        /// <summary>
        //  Given a string s and a string t, check if s is subsequence of t.
        //  You may assume that there is only lower case English letters in both s and t.t is potentially a very long (length ~= 500,000) string, and s is a short string (<=100).
        //  A subsequence of a string is a new string which is formed from the original string by deleting some(can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, "ace" is a subsequence of "abcde" while "aec" is not).
        //Example 1:
        //s = "abc", t = "ahbgdc"
        //Return true.
        //Example 2:
        //s = "axc", t = "ahbgdc"
        //Return false.
        //Follow up:
        //If there are lots of incoming S, say S1, S2, ... , Sk where k >= 1B, and you want to check one by one to see if T has its subsequence.In this scenario, how would you change your code?
        // </summary>
        // <param name="s"></param>
        // <param name="t"></param>
        /// <returns></returns>
        public static bool isSubSequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
            {
                return false;
            }

            int tCounter = 0;

            int tLength = t.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[tCounter])
                {
                    if (tCounter + 1 == tLength)
                    {
                        return true;
                    }

                    tCounter++;
                }
            }

            return false;
        }
    }
}
