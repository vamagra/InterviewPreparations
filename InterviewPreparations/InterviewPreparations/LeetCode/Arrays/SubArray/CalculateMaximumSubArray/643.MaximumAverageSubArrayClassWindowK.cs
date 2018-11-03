using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MaximumAverageSubArrayClass
    {
        /// <summary>
        /// Given an array consisting of n integers, find the contiguous subarray of given length k that has the maximum average value. And you need to output the maximum average value.
        //  Example 1:
        //  Input: [1,12,-5,-6,50,3], k = 4
        //  Output: 12.75
        //  Explanation: Maximum average is (12-5-6+50)/4 = 51/4 = 12.75
        //  Note:
        //  1 <= k <= n <= 30,000.
        //  Elements of the given array will be in the range[-10, 000, 10, 000].
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double MaxAverageSubArray(int[] nums, int k)
        {
            double maxSum = 0;
            double currSum = 0;

            if (nums.Length < 1 && k <= 0 && k > nums.Length)
            {
                return maxSum;
            }

            //get the sum till K elements
            for (int i = 0; i < k; i++)
            {
                currSum = currSum + nums[i];
            }

            //if (nums.Length == k)
            //{
            //    return currSum / 1.0 / k;
            //}
            maxSum = currSum;

            for (int i = k; i < nums.Length; i++)
            {
                //update the curr sum
                currSum = currSum - nums[i - k];

                //update the curr sum for next window
                currSum = currSum + nums[i];

                //update the sum first
                maxSum = currSum > maxSum ? currSum : maxSum;
            }

            return maxSum / 1.0 / k;
        }
    }
}
