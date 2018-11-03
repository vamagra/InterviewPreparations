using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidPalindromeII
    {
        /// <summary>
        /// Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.
        //  Example 1:
        //  Input: "aba"
        //  Output: True
        //  Example 2:
        //  Input: "abca"
        //  Output: True
        //  Explanation: You could delete the character 'c'.
        //  </summary>
        //  <param name="s"></param>
        /// <returns></returns>
        public static bool ValidPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            int start = -1;
            int end = s.Length;

            while (++start < --end)
            {
                if (s[start] != s[end])
                {
                    return IsPalindrome(s, start, end + 1) || IsPalindrome(s, start - 1, end);
                }
            }

            return true;
        }

        public static bool IsPalindrome(string s, int start, int end)
        {
            while (++start < --end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
