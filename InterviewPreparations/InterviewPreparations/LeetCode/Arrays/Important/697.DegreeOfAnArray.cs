using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays
{
    class DegreeOfAnArray
    {
        /// <summary>
        /// Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.
        //  Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.
        //  Example 1:
        //  Input: [1, 2, 2, 3, 1]
        //  Output: 2
        //  Explanation: 
        //  The input array has a degree of 2 because both elements 1 and 2 appear twice.
        //  Of the subarrays that have the same degree:
        //  [1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
        //  The shortest length is 2. So return 2.
        //  Example 2:
        //  Input: [1,2,2,3,1,4,2]
        //  Output: 6
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int FindShortestSubArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            IDictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = dict[nums[i]] + 1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            int maxFreq = dict.OrderByDescending(x => x.Value).First().Value;
            //int highestFreq = ht.OrderByDescending(x => x.alue).First().Value;

            List<int> topFrequentElements = new List<int>();

            foreach (int key in dict.Keys)
            {
                if (dict[key] == maxFreq)
                {
                    topFrequentElements.Add(key);
                }
            }

            int minLength = int.MaxValue;

            for (int i = 0; i < topFrequentElements.Count; i++)
            {
                int left = 0;
                int right = nums.Length - 1;

                int m = -1;
                int n = -1;

                while (left <= right)
                {
                    if (nums[left] == topFrequentElements[i])
                    {
                        if (m < 0)
                        {
                            m = left;
                        }

                        if (n > -1)
                        {
                            minLength = Math.Min(minLength, n - m);
                            break;
                        }
                    }

                    if (nums[right] == topFrequentElements[i])
                    {
                        if (n < 0)
                        {
                            n = right;
                        }

                        if (m > -1)
                        {
                            minLength = Math.Min(minLength, n - m);
                            break;
                        }
                    }

                    left++;
                    right--;
                }
            }

            return minLength == int.MaxValue ? 1 : minLength + 1;
        }
    }
}
