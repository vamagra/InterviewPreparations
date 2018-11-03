using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class JumpGame
    {
        /// <summary>
        /// Given an array of non-negative integers, you are initially positioned at the first index of the array.
        //  Each element in the array represents your maximum jump length at that position.
        //  Determine if you are able to reach the last index.
        //  For example:
        //  A = [2, 3, 1, 1, 4], return true.
        //  A = [3, 2, 1, 0, 4], return false.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool canJump(int[] nums)
        {
            if (nums.Length < 1)
            {
                return false;
            }

            int max = 0;

            // this loop is running till second last element
            for (int i = 0; i <= max && i < nums.Length - 1; i++)
            {
                max = Math.Max(i + nums[i], max);
            }

            return max >= nums.Length - 1;
        }
    }
}
