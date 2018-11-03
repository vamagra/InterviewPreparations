using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidAnagram_CTCI
    {
        /// <summary>
        /// Given two strings s and t, write a function to determine if t is an anagram of s.
        //  For example,
        //  s = "anagram", t = "nagaram", return true.
        //  s = "rat", t = "car", return false.
        //  Note:
        //  You may assume the string contains only lowercase alphabets.
        //  Follow up:
        //  What if the inputs contain unicode characters? How would you adapt your solution to such case?
        //  </summary>
        //  <param name="s"></param>
        //  <param name="t"></param>
        //  <returns></returns>
        // 
        public static bool IsValidAnagramStrings(string s, string t)
        {
            // Length of two anagrams should be same
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] countArray = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                countArray[s[i]]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if(countArray[t[i]] > 0)
                {
                    countArray[t[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        // Time Complexity - O(n)
        // Space Complexity - O(n)
    }
}
