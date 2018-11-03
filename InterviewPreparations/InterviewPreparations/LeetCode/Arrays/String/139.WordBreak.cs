using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class WordBreak
    {
        /// <summary>
        // Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be 
        // segmented into a space-separated sequence of one or more dictionary words. You may assume the dictionary does not contain duplicate words. 
        // For example, given
        // s = "leetcode",
        // dict = ["leet", "code"].
        // Return true because "leetcode" can be segmented as "leet code".
        // </summary>
        // <param name="s"></param>
        // <param name="dict"></param>
        // <returns></returns>
        public static bool IsWordBreakPossible(string s, IList<string> dict)
        {
            if (string.IsNullOrEmpty(s) || dict.Count == 0)
            {
                return false;
            }

            if (string.IsNullOrEmpty(s) && dict.Count == 0)
            {
                return false;
            }

            bool[] visited = new bool[s.Length + 1];

            visited[0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int startIndex = j;
                    int endIndex = i;

                    if (visited[j] && dict.Contains(s.Substring(startIndex, endIndex - startIndex)))
                    {
                        visited[i] = true;
                        break;
                    }
                }
            }

            return visited[s.Length];
        }
    }
}
