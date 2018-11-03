using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MinimumSizeSubarraySum
    {
        /// <summary>
        //  Given an array of n positive integers and a positive integer s, 
        //  find the minimal length of a contiguous subarray of which the sum ≥ s. If there isn't one, return 0 instead.
        //  For example, given the array[2, 3, 1, 2, 4, 3] and s = 7,
        //  the subarray[4, 3] has the minimal length 
        //  under the problem constraint.
        //  </summary>
        public static int MinSizeSubarraySum(int[] nums, int target)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0] == target ? nums.Length : 0;
            }

            int start = 0;
            int end = 0;
            int currSum = 0;
            int minLength = int.MaxValue;

            while (end < nums.Length)
            {
                currSum = currSum + nums[end];

                while (currSum > target)
                {
                    minLength = Math.Min(minLength, (end - start) + 1);
                    currSum = currSum - nums[start];
                    start++;
                }

                end++;
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}
