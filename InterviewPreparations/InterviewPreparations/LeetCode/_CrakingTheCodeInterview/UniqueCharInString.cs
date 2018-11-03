using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String.Important
{
    class UniqueCharInString
    {
        /// <summary>
        /// WAP to find if a string has all unique characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        
        // 1st way - using extra space
        // 2nd way - Sort the string and compare with next char
        // 3rd way - use hashset/hastable
        // 4th way - Brute force - O(n2)
        public static bool IsUniqueCharInString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            if (s.Length == 1)
            {
                return true;
            }

            char[] chArray = s.ToCharArray();

            int[] countArray = new int[256];

            for (int i = 0; i < chArray.Length; i++)
            {
                if (countArray[chArray[i]] > 0)
                {
                    return false;
                }

                countArray[chArray[i]]++;
            }

            return true;
        }

        public static bool IsUniqueWithoutUsingSpace(string s)
        {
            if (s == null || s.Length < 1)
            {
                return false;
            }

            char[] chArray = s.ToCharArray();
            Array.Sort(chArray);

            for (int i = 0; i < chArray.Length - 1; i++)
            {
                if (chArray[i] == chArray[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
