using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FirstUniqueCharacterInString
    {
        /// <summary>
        /// Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
        //  Examples:
        //  s = "leetcode"
        //  return 0.
        //  s = "loveleetcode",
        //  return 2.
        //  Note: You may assume the string contain only lowercase letters.
        // </summary>
        // <param name="s"></param>
        /// <returns></returns>
        public static int FirstUniqueCharString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            IDictionary<char, int> dictMapping = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (dictMapping.Count == 0 || !dictMapping.ContainsKey(ch))
                {
                    dictMapping.Add(ch, 1);
                }
                else
                {
                    dictMapping[ch] = dictMapping[ch] + 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (dictMapping.ContainsKey(ch) && dictMapping[ch] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
