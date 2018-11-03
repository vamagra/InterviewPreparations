using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SearchForARange
    {
        /// <summary>
        /// Given an array of integers sorted in ascending order, find the starting and ending position of a given target value.
        //  Your algorithm's runtime complexity must be in the order of O(log n).
        //  If the target is not found in the array, return [-1, -1].
        //  For example,
        //  Given[5, 7, 7, 8, 8, 10] and target value 8,
        //  return [3, 4].
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];

            result[0] = -1;
            result[1] = -1;

            if (nums.Length < 1)
            {
                return result;
            }

            result[0] = FindFirst(nums, target);
            result[1] = FindLast(nums, target);
            return result;
        }

        public static int FindFirst(int[] nums, int target)
        {
            int index = -1;

            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] >= target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

                if (nums[mid] == target)
                {
                    index = mid;
                }
            }

            return index;
        }

        public static int FindLast(int[] nums, int target)
        {
            int index = -1;

            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] <= target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

                if (nums[mid] == target)
                {
                    index = mid;
                }
            }

            return index;
        }
    }
}
