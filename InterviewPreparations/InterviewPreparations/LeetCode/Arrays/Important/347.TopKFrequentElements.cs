using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Given a non-empty array of integers, return the k most frequent elements.
    //  For example,
    //  Given[1, 1, 1, 2, 2, 3] and k = 2, return [1,2].
    //  Note: 
    //  You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
    //  Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
    /// </summary>
    class TopKFrequentElements
    {
        public static IList<int> TopKFreqElements(int[] nums, int k)
        {
            IList<int> result = new List<int>();

            
            // Lets Say Input is  {1,6,2,1,6,1} K=2
            //          Output is {1,6}

            // Idea here is to use Bucket Sort 
            // Create a dictionary to store the freq of elements

            //To store the frequency we need hashmap or hashtable
            IDictionary<int, int> freqDict = new Dictionary<int, int>();

            
            // This will store the frequency of individual numbers in Dictionary
            for (int i = 0; i < nums.Length; i++)
            {
                if (freqDict.ContainsKey(nums[i]))
                {
                    freqDict[nums[i]] = freqDict[nums[i]] + 1;
                }
                else
                {
                    freqDict.Add(nums[i], 1);
                }
            }

            // After Step1 -

            // freq = 
            // {
             // 1:3,
             // 6:2,
             // 2:1
            // }

            // we need bucket to store the freq on the index of bucket and it will be list of integer array
            // bucket index will the frequency of elements in the array


            List<int>[] buckets = new List<int>[nums.Length + 1];

            // iterate through the freq hash map to populate the bucket
            // here we just need to get the freq (which is value of dict) from hashmap and add the key on the freq in bucket

            foreach (int element in freqDict.Keys)
            {
                int freq = freqDict[element];

                if (buckets[freq] == null)
                {
                    buckets[freq] = new List<int>();
                }

                // Add the num of elements on the freq index
                buckets[freq].Add(element);
            }

            // After Step2
            // Buckets will be like this

            // buckets { 0 , 1, 2, 3, 4, ,5 , 6 , 7 ,8 ,9 ,10, 11, 12 } 
            //               2    1,6

            // beacuse bucket index will be as a freq of elements, we need to 
            // traverse the bucket from end to start to get the most frequent elements
            for (int pos = buckets.Length - 1; pos >= 0; pos--)
            {
                if (buckets[pos] != null)
                {
                    for (int i = 0; i < buckets[pos].Count && result.Count < k; i++)
                    {
                        result.Add(buckets[pos][i]);
                    }
                }
            }

            return result;
        }
    }
}
