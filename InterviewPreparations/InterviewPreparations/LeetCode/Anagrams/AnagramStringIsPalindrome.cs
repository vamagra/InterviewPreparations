using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String.Important
{
    class AnagramStringIsPalindrome
    {
        /// <summary>
        /// We have given a anagram string and we have to check whether it can be made palindrome o not.
        //  Examples:
        //  Input : geeksforgeeks
        //  Output : No
        //  There is no palindrome anagram of
        //  given string
        //  Input  : geeksgeeks
        //  Output : Yes
        //  There are palindrome anagrams of
        //  given string. For example kgeeseegk
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static bool IsAnagramStringPalindrome(string s)
        {
            // 1) Create a count array of alphabet size which is typically 256.
            // Initialize all values of count array as 0.
            // Traverse the given string and increment count of every character.
            // 2) Traverse the count array and if the count array has more than one odd values, return false.
            // Otherwise return true.

            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            int[] count = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }

            int odd = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i]] % 2 != 0)
                {
                    odd++;
                }

                if (odd > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
