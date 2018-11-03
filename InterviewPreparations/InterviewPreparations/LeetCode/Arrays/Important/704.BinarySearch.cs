using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class BinarySearch
    {
        /// <summary>
        /// Given a sorted (in ascending order) integer array nums of n elements and a target value, write a function to search target in nums. If target exists, then return its index, otherwise return -1.
        //  Example 1:
        //  Input: nums = [-1,0,3,5,9,12], target = 9
        //  Output: 4
        //  Explanation: 9 exists in nums and its index is 4
        //  Example 2:
        //  Input: nums = [-1,0,3,5,9,12], target = 2
        //  Output: -1
        //  Explanation: 2 does not exist in nums so return -1
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="target"></param>
        // <returns></returns>
        public static int BinarySearchInArray(int[] nums, int target)
        {
            if (nums == null || nums.Length < 1)
            {
                return -1;
            }

            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
