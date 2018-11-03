using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ShortestWordDistanceStrings
    {
        /// <summary>
        /// Given a list of words and two words word1 and word2, return the shortest distance between these two words in the list.
        //  For example,
        //  Assume that words = ["practice", "makes", "perfect", "coding", "makes"].
        //  Given word1 = “coding”, word2 = “practice”, return 3.
        //  Given word1 = "makes", word2 = "coding", return 1.
        //  </summary>
        //  <param name="strs"></param>
        //  <returns></returns>
        public static int GetShortestWordDistance(string[] words, string word1, string word2)
        {
            if (words == null || words.Length < 1)
            {
                return -1;
            }

            int minDistance = int.MaxValue;
            
            // assign -1 because we need to store index in these variables
            int m = -1;
            int n = -1;

            int i = 0;
            foreach (string word in words)
            {
                if (string.Equals(word, word1))
                {
                    m = i;

                    if (n > -1)
                    {
                        minDistance = Math.Min(minDistance, m - n);
                    }
                }
                else if (string.Equals(word,word2))
                {
                    n = i;

                    if (m > -1)
                    {
                        minDistance = Math.Min(minDistance, n - m);
                    }
                }

                i++;
            }

            return minDistance;
        }
    }
}
