using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class NoOfMatchingSequence
    {
        /// <summary>
        /// Given string S and a dictionary of words words, find the number of words[i] that is a subsequence of S.
        //  Example :
        //  Input: 
        //  S = "abcde"
        //  words = ["a", "bb", "acd", "ace"]
        //  Output: 3
        //  Explanation: There are three words in words that are a subsequence of S: "a", "acd", "ace".
        //  Note:
        //  All words in words and S will only consists of lowercase letters.
        //  The length of S will be in the range of[1, 50000].
        //  The length of words will be in the range of[1, 5000].
        //  The length of words[i] will be in the range of[1, 50].
        //  </summary>
        //  <returns></returns>
        public static int NoMatchingSubSequence(string S, string[] words)
        {
            if (S == null || words == null)
            {
                return -1;
            }

            if (S.Length == 0 || words.Length == 0)
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (IsSubsequence(S, words[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length < t.Length)
            {
                return false;
            }

            if (string.IsNullOrEmpty(t))
            {
                return true;
            }

            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
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
