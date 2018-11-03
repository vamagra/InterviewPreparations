using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class TargetSum
    {
        /// <summary>
        /// You are given a list of non-negative integers, a1, a2, ..., an, and a target, S. Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.
        //  Find out how many ways to assign symbols to make sum of integers equal to target S.
        //  Example 1:
        //  Input: nums is [1, 1, 1, 1, 1], S is 3. 
        //  Output: 5
        //  Explanation: 
        //  -1+1+1+1+1 = 3
        //  +1-1+1+1+1 = 3
        //  +1+1-1+1+1 = 3
        //  +1+1+1-1+1 = 3
        //  +1+1+1+1-1 = 3
        //  There are 5 ways to assign symbols to make the sum of nums be target 3.
        //  Note:
        //  The length of the given array is positive and will not exceed 20.
        //  The sum of elements in the given array will not exceed 1000.
        //  Your output answer is guaranteed to be fitted in a 32-bit integer.
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="target"></param>
        //  <returns></returns>

        public static int GetTargetSumWays(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int count = FindWays(nums, target, 0, 0);
            return count;
        }

        private static int FindWays(int[] nums, int targetSum, int sum, int index)
        {
            if (index == nums.Length)
            {
                if (sum == targetSum)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            int plus = FindWays(nums, targetSum, sum + nums[index], index + 1);
            int minus = FindWays(nums, targetSum, sum - nums[index], index + 1);

            return plus + minus;
        }
    }
}
