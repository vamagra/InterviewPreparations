using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class RotateFunction
    {
        /// <summary>
        /// Given an array of integers A and let n to be its length.
        //  Assume Bk to be an array obtained by rotating the array A k positions clock-wise, we define a "rotation function" F on A as follow:
        //  F(k) = 0 * Bk[0] + 1 * Bk[1] + ... + (n-1) * Bk[n - 1].
        //  Calculate the maximum value of F(0), F(1), ..., F(n-1).
        //  Note:
        //  n is guaranteed to be less than 105.
        //  Example:
        //  A = [4, 3, 2, 6]
        //  F(0) = (0 * 4) + (1 * 3) + (2 * 2) + (3 * 6) = 0 + 3 + 4 + 18 = 25
        //  F(1) = (0 * 6) + (1 * 4) + (2 * 3) + (3 * 2) = 0 + 4 + 6 + 6 = 16
        //  F(2) = (0 * 2) + (1 * 6) + (2 * 4) + (3 * 3) = 0 + 6 + 8 + 9 = 23
        //  F(3) = (0 * 3) + (1 * 2) + (2 * 6) + (3 * 4) = 0 + 2 + 12 + 12 = 26
        //  So the maximum value of F(0), F(1), F(2), F(3) is F(3) = 26.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int RotateFunctionMaxValue(int[] nums)
        {
            int maximum = int.MinValue;
            if (nums == null || nums.Length == 1)
            {
                return maximum;
            }

            int sum = 0;
            int F = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                F = i * nums[i];
                sum = sum + nums[i];
            }

            maximum = F;

            for (int i = nums.Length - 1; i >= 0; i++)
            {
                F = F + sum - nums.Length * nums[i];
                maximum = Math.Max(F, maximum);
            }

            return maximum;
        }
    }
}
