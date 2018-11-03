using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MaximumSubarrayWithWindowK
    {
        /// <summary>
        /// Find maximum(or minimum) sum of a subarray of size k
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaximumSubarrayWithSlidingWindow(int[] nums, int k)
        {
            int maxArraySum = 0;
            int currSum = 0;

            if (nums.Length < 1 || k < 1 || k > nums.Length)
            {
                return maxArraySum;
            }

            //get the sum of first k elements in array
            for (int i = 0; i < k; i++)
            {
                currSum = currSum + nums[i];
            }

            maxArraySum = currSum;

            //now use the sliding window and update the window elements as well
            for (int i = k; i < nums.Length; i++)
            {
                //update the window by removing first element from the window
                currSum = currSum - nums[i - k];

                //include the new element in the window
                currSum = currSum + nums[i];

                //update the max from window
                maxArraySum = Math.Max(currSum, maxArraySum);
            }

            return currSum > maxArraySum ? currSum : maxArraySum;
        }

    }
}
