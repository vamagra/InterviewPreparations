using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.SubSequence
{
    class LongestContinousIncreasingSubSequence
    {
        /// <summary>
        // Given an unsorted array of integers, find the length of longest continuous increasing subsequence (subarray).
        // Example 1:
        // Input: [1,3,5,4,7]
        // Output: 3
        // Explanation: The longest continuous increasing subsequence is [1,3,5], its length is 3. 
        // Even though[1, 3, 5, 7] is also an increasing subsequence, it's not a continuous one where 5 and 7 are separated by 4. 
        // Example 2:
        // Input: [2,2,2,2,2]
        // Output: 1
        // Explanation: The longest continuous increasing subsequence is [2], its length is 1. 
        // Note: Length of the array will not exceed 10,000.
        // </summary>
        // <param name="nums"></param>
        // <returns></returns>
        public static int LongestContiIncreasingSubSequence(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int maxLength = int.MinValue;
            int counter = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    counter++;
                    maxLength = Math.Max(maxLength, counter);
                }
                else
                {
                    counter = 1;
                }
            }

            return maxLength;
        }
    }
}
