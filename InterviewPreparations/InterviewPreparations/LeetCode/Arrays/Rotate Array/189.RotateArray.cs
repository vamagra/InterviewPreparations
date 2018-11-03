using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RotateArray
    {
        /// <summary>
        // Rotate an array of n elements to the right by k steps.
        // For example, with n = 7 and k = 3, the array[1, 2, 3, 4, 5, 6, 7] is rotated to[5, 6, 7, 1, 2, 3, 4].
        // Note:
        // Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
        // [show hint]
        // Hint:
        // Could you do it in-place with O(1) extra space?
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="k"></param>
        //  <returns></returns>

        public static int[] ArrayRotationReverseLogic(int[] nums, int k)
        {
            if (nums.Length <= 1)
            {
                return null;
            }

            // step each time to move
            int step = k % nums.Length;

            ReverseArray(nums, 0, nums.Length - 1);
            ReverseArray(nums, 0, step - 1);
            ReverseArray(nums, step, nums.Length - 1);

            return nums;
        }

        private static void ReverseArray(int[] nums, int start, int end)
        {
            int temp;
            for (int i = start; i < end; i++)
            {
                temp = nums[i];
                nums[i] = nums[end];
                nums[end] = temp;
                end--;
            }
        }

        public static int[] ArrayRotation(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return null;
            }

            if (nums.Length < k)
            {
                return nums;
            }

            for (int i = 0; i < k; i++)
            {
                int temp = nums[i];

                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }

                nums[nums.Length - 1] = temp;
            }

            return nums;
        }

    }
}
