using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    //  This is a follow up of Shortest Word Distance. The only difference is now you are given the list of 
    //  words and your method will be called repeatedly many times with different parameters. How would you optimize it?
    //  Design a class which receives a list of words in the constructor, and implements a method that 
    //  takes two words word1 and word2 and return the shortest distance between these two words in the list.
    //  For example,
    //  Assume that words = ["practice", "makes", "perfect", "coding", "makes"].
    //  Given word1 = “coding”, word2 = “practice”, return 3.
    //  Given word1 = "makes", word2 = "coding", return 1.
    //  </summary>
    class ShortestWordDistanceStringsII
    {
        // The key idea is to store the indexes of each word using a hash map.Then the function shortest() 
        // is just to find the minimum difference between two sorted lists

        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
        ShortestWordDistanceStringsII(string[] words)
        {
            // Store the index of words in mapping dictionary
            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    // adding index to existing word list, in case of duplicate word 
                    dict[words[i]].Add(i);
                }
                else
                {
                    List<int> list = new List<int>();
                    list.Add(i);
                    dict.Add(words[i], list);
                }
            }
        }

        public int ShortestDistance(string word1, string word2)
        {
            List<int> list1Index = dict[word1];
            List<int> list2Index = dict[word2];

            int m = list1Index.Count;
            int n = list2Index.Count;

            int i = 0;
            int j = 0;
            int minDistance = int.MaxValue;

            while (i < m && j < n)
            {
                minDistance = Math.Min(minDistance, Math.Abs(list1Index[i] - list2Index[j]));

                if (list1Index[i] < list2Index[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return minDistance;
        }
    }
}
