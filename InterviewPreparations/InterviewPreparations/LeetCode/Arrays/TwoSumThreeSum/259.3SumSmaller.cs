using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class _3SumSmaller
    {
        /// <summary>
        /// Given an array of n integers nums and a target, find the number of index triplets i, j, k with 0 <= i < j < k < n that satisfy the condition nums[i] + nums[j] + nums[k] < target.
        //  For example, given nums = [-2, 0, 1, 3], and target = 2.
        //  Return 2. Because there are two triplets which sums are less than 2:
        //  [-2, 0, 1]
        //  [-2, 0, 3]
        //  Follow up: Could you solve it in O(n2) runtime?
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="target"></param>
        //  <returns></returns>
        public static int Threeumsmaller(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int N = nums.Length;

            Array.Sort(nums);

            int count = 0;

            for (int i = 0; i <= N - 2; i++)
            {
                int left = i + 1;
                int right = N - 1;

                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] < target)
                    {
                        count += right - left;
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return count;
        }
    }
}
