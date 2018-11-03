using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class WordPattern
    {
        /// <summary>
        //  Given a pattern and a string str, find if str follows the same pattern.
        //  Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.
        //  Examples:
        //  pattern = "abba", str = "dog cat cat dog" should return true.
        //  pattern = "abba", str = "dog cat cat fish" should return false.
        //  pattern = "aaaa", str = "dog cat cat dog" should return false.
        //  pattern = "abba", str = "dog dog dog dog" should return false.
        //  Notes:
        //  You may assume pattern contains only lowercase letters, and str contains lowercase letters separated by a single space.
        //  </summary>
        //  <param name="words"></param>
        //  <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatchingPattern(string words, string pattern)
        {
            string[] splitWords = words.Split(' ');

            //Length should be same both words and pattern
            if (splitWords.Length != pattern.Length)
            {
                return false;
            }

            Dictionary<char, string> mapDict = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (mapDict.ContainsKey(pattern[i]))
                {
                    if (splitWords[i] != mapDict[pattern[i]])
                    {
                        return false;
                    }
                }
                else
                {
                    if (mapDict.ContainsValue(splitWords[i]))
                    {
                        return false;
                    }

                    mapDict.Add(pattern[i], splitWords[i]); 
                }
            }

            return true;
        }
    }
}
