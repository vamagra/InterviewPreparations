using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class IsomorphicStrings
    {
        /// <summary>
        /// Given two strings s and t, determine if they are isomorphic.
        //  Two strings are isomorphic if the characters in s can be replaced to get t.
        //  All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character but a character may map to itself.
        //  For example,
        //  Given "egg", "add", return true.
        //  Given "foo", "bar", return false.
        //  Given "paper", "title", return true.
        //  Note:
        //  You may assume both s and t have the same length.
        //  </summary>
        //  <param name="s"></param>
        //  <param name="t"></param>
        //  <returns></returns>
        public static bool IsIsomorphic(string s, string t)
        {

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return false;
            }

            if (s.Length != t.Length)
            {
                return false;
            }

            char[] mapST = new char[256];
            char[] mapTS = new char[256];

            mapST = Enumerable.Repeat('0', 256).ToArray();
            mapTS = Enumerable.Repeat('0', 256).ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (mapST[s[i]] == '0' && mapTS[t[i]] == '0')
                {
                    mapST[s[i]] = t[i];
                    mapTS[t[i]] = s[i];
                }
                else
                {
                    if (mapST[s[i]] != t[i] || mapTS[t[i]] != s[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
