using InterviewQuestions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MaximumSubarray
    {
        /// <summary>
        /// Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
        //  For example, given the array[-2, 1, -3, 4, -1, 2, 1, -5, 4],
        //  the contiguous subarray[4, -1, 2, 1] has the largest sum = 6.
        //  </summary>
        //  <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubarray(int[] nums)
        {
            int maximumSum = 0;
            int currentSum = 0;

            if (nums[0] < 0)
            {
                maximumSum = nums[0];
                currentSum = nums[0];
            }

            if (nums.Length < 1)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum = currentSum + nums[i];

                currentSum = UtilityHelper.max(nums[i], currentSum);

                maximumSum = currentSum > maximumSum ? currentSum : maximumSum;
            }

            return maximumSum;
        }
    }
}
