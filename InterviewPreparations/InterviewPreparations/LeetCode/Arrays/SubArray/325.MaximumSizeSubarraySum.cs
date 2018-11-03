using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Given an array nums and a target value k, find the maximum length of a subarray that sums to k. If there isn't one, return 0 instead.
    //  Example 1:
    //  Given nums = [1, -1, 5, -2, 3], k = 3,
    //  return 4. (because the subarray[1, -1, 5, -2] sums to 3 and is the longest)
    //  Example 2:
    //  Given nums = [-2, -1, 2, 1], k = 1,
    //  return 2. (because the subarray[-1, 2] sums to 1 and is the longest)
    /// </summary>                                               
    class MaximumSizeSubarraySum
    {
        public static int MaxSizeSubarraySum(int[] nums, int targetSum)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int counter = 0;
            int currSum = 0;
            int maxLength = int.MinValue;

            IDictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);

            while (counter < nums.Length)
            {
                currSum = currSum + nums[counter];

                // store every curr sum index in dictionnary
                if (!dict.ContainsKey(currSum))
                {
                    dict.Add(currSum, counter);
                }

                if (dict.ContainsKey(currSum - targetSum))
                {
                    maxLength = Math.Max(maxLength, counter - dict[currSum - targetSum]);
                }

                counter++;
            }

            return maxLength == int.MinValue ? 0 : maxLength;
        }
    }
}
