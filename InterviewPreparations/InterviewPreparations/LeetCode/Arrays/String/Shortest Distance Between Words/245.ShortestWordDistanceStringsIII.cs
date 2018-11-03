using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ShortestWordDistanceStringsIII
    {
        /// <summary>
        /// This is a follow-up problem of Shortest Word Distance. The only difference is now word1 could be the same as word2.
        //  Given a list of words and two words word1 and word2, return the shortest distance between these two words in the list.
        //  word1 and word2 may be the same and they represent two individual words in the list.
        //  For example,
        //  Assume that words = ["practice", "makes", "perfect", "coding", "makes"].
        //  Given word1 = “makes”, word2 = “coding”, return 1.
        //  Given word1 = "makes", word2 = "makes", return 3.
        //  </summary>
        //  <param name="words"></param>
        //  <param name="word1"></param>
        //  <param name="word2"></param>
        //  <returns></returns>
        public static int ShortesDistance(string[] words, string word1, string word2)
        {
            if (words == null || words.Length < 1 || word1 == null || word2 == null)
            {
                return -1;
            }

            int m = -1;
            int n = -1;

            int minDistance = int.MaxValue;

            bool isSame = false;
            if (word1.Equals(word2))
            {
                isSame = true;
            }

            int prev = -1;

            for (int i = 0; i < words.Length; i++)
            {
                // when both input words are same
                if (isSame)
                {
                    // check if both the words are equal or not
                    if (words[i].Equals(word1))
                    {
                        // if this is the second match, prev wmust be set to > -1
                        if (prev != -1)
                        {
                            minDistance = Math.Min(minDistance, i - prev);
                        }

                        // set the index of word when you find it first time
                        prev = i;
                    }
                }
                else
                {
                    // when input words are not same
                    if (string.Equals(word1, words[i]))
                    {
                        m = i;

                        if (n > -1)
                        {
                            minDistance = Math.Min(minDistance, m - n);
                        }
                    }
                    else
                    {
                        n = i;

                        if (m > -1)
                        {
                            minDistance = Math.Min(minDistance, n - m);
                        }
                    }
                }
            }

            return minDistance;
        }
    }
}
