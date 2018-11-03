using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FindKPairsArray
    {
        /// <summary>
        //  Given an array of integers and an integer k, you need to find the number of unique k-diff pairs in the array. Here a k-diff pair is defined as an integer pair (i, j), where i and j are both numbers in the array and their absolute difference is k.
        //  Example 1:
        //  Input: [3, 1, 4, 1, 5], k = 2
        //  Output: 2
        //  Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        //  Although we have two 1s in the input, we should only return the number of unique pairs.
        //  Example 2:
        //  Input:[1, 2, 3, 4, 5], k = 1
        //  Output: 4
        //  Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and(4, 5).
        //  Example 3:
        //  Input: [1, 3, 1, 5, 4], k = 0
        //  Output: 1
        //  Explanation: There is one 0-diff pair in the array, (1, 1).
        //  Note:
        //  The pairs(i, j) and(j, i) count as the same pair.
        //  The length of the array won't exceed 10,000.
        //  All the integers in the given input belong to the range: [-1e7, 1e7].
        // </summary>
        // <param name="nums"></param>
        // <param name="k"></param>
        // <returns></returns>
        public static int FindPairs(int[] nums, int k)
        {
            // Here are the steps to solve this problem
            // 1. Create a dict and store unique elements in it
            // 2. if the elements are duplicate increase the pairCount - just in case 
            //    if k==0 then count of duplicate number would be answer
            // 3. now run the loop on array again - check if 
            //    nums[i] is in dictionary 
            //4. if yes - check if nums[i]-k is there then increase the pairCount
            //          - check if nums[i]+k is there then increase the pairCount
            //5. remove that entry from dict and return the pairCount after the loop 

            // If k is less than 0, then return 0;
            if (k < 0)
            {
                return 0;
            }

            int pairCount = 0;

            IDictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && pairCount < dict.Count)
                {
                    pairCount++;
                }

                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], nums[i]);
                }
            }

            // Handle the duplicate value with k==0 case
            if (k == 0)
            {
                return pairCount;
            }
            else
            {
                pairCount = 0;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (dict.ContainsKey(nums[i] - k))
                    {
                        pairCount++;
                    }

                    if (dict.ContainsKey(nums[i] + k))
                    {
                        pairCount++;
                    }

                    // remove the element from dict
                    dict.Remove(nums[i]);
                }
            }

            return pairCount;
        }
    }
}
