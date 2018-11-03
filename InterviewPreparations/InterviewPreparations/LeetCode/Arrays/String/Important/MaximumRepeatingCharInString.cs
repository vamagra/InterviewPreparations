using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String.Important
{
    class MaximumRepeatingCharInString
    {
        /// <summary>
        /// In the given string find the maximum occurring character
        //  Maximum occurring character: character which is coming more number of times. (Case sensitivity is present, “D” and “d” are not the same.)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char GetMaximumRepeatingCharInString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 'N';
            }

            if (s.Length == 1)
            {
                return 'N';
            }

            char[] chArray = s.ToCharArray();
            int[] countArray = new int[256];

            for (int i = 0; i < chArray.Length; i++)
            {
                countArray[chArray[i]]++;
            }

            int maxCount = 0;
            char ch = char.MinValue;

            for (int i = 0; i < chArray.Length; i++)
            {
                if (countArray[chArray[i]] > 0)
                {
                    if (countArray[chArray[i]] > maxCount)
                    {
                        maxCount = countArray[chArray[i]];
                        ch = chArray[i];
                    }
                }
            }

            return ch;
        }
    }
}
