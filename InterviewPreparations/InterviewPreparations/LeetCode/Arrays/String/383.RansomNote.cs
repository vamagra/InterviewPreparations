using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RansomNote
    {
        /// <summary>
        //  Given an arbitrary ransom note string and another string containing letters from all the magazines, 
        //  write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.
        //  Each letter in the magazine string can only be used once in your ransom note.
        //  Note:
        //  You may assume that both strings contain only lowercase letters.
        //  canConstruct("a", "b") -> false
        //  canConstruct("aa", "ab") -> false
        //  canConstruct("aa", "aab") -> true
        //  </summary>
        //  <param name="ransomNote"></param>
        //  <param name="magazine"></param>
        //  <returns></returns>
        public static bool CanConstruct(string subString, string mainString)
        {
            if (string.IsNullOrEmpty(subString) || string.IsNullOrEmpty(mainString))
            {
                return false;
            }

            int[] countMainString = new int[256];

            for (int i = 0; i < mainString.Length; i++)
            {
                countMainString[mainString[i]]++;
            }

            int totalCount = 0;

            for (int i = 0; i < subString.Length; i++)
            {
                if (countMainString[subString[i]] > 0)
                {
                    totalCount++;
                    countMainString[subString[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return totalCount == subString.Length;
        }
    }
}
