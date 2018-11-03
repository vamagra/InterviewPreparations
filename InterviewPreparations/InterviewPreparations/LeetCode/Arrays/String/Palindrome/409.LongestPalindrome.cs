using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class LongestPalindrome
    {
        /// <summary>
        /// Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.
        //  This is case sensitive, for example "Aa" is not considered a palindrome here.
        //  Note:
        //  Assume the length of given string will not exceed 1,010.
        //  Example:
        //  Input:
        //  "abccccdd"
        //  Output:
        //  7
        //  Explanation:
        //  One longest palindrome that can be built is "dccaccd", whose length is 7.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static int LongestPalindromeMaxLength(string s)
        {
            // Idea is quite simple here
            // Create a list of chars from string
            // Loop through the string and keep adding the char in list
            // if you get the same char in string remove the char from list
            // increase the longest palindrome count
            // if list if empty, it means string length is odd so return count * 2 + 1
            // count * 2 for even

            if (s == null || s.Length < 1)
            {
                return 0;
            }

            List<char> list = new List<char>();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(list.Contains(s[i]))
                {
                    list.Remove(s[i]);
                    count++;
                }
                else
                {
                    list.Add(s[i]);
                }
            }

            // For Odd
            if (list.Count != 0)
            {
                return count * 2 + 1;
            }

            // For even
            return count * 2;
        }
    }
}
