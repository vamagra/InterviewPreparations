using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LongestSubstringWithAtMostTwoDistinctCharacters
    {
        /// <summary>
        /// Given a string, find the longest substring that contains only two unique characters. For example, given "abcbbbbcccbdddadacb", 
        /// the longest substring that contains 2 unique character is "bcbbbbcccb".
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int LongestSubstringWithMostTwoUniqueChar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            int begin = 0, end = 0;
            int counter = 0, resultLen = 0;

            IDictionary<char, int> map = new Dictionary<char, int>();

            int len = str.Length;

            while (end < str.Length)
            {
                char endCh = str[end];

                if (map.ContainsKey(endCh))
                {
                    map[endCh] = map[endCh] + 1;
                }
                else
                {
                    map[endCh] = 1;
                }

                // new character
                if (map[endCh] == 1)
                {
                    counter++;
                }

                end++;

                while (counter > 2)
                {
                    char beginCh = str[begin];

                    if (map.ContainsKey(beginCh))
                    {
                        map[beginCh] = map[beginCh] - 1;
                    }

                    if (map[beginCh] == 0)
                    {
                        counter--;
                    }

                    begin++;
                }

                resultLen = Math.Max(resultLen, end - begin);
            }

            return resultLen;
        }
    }
}
