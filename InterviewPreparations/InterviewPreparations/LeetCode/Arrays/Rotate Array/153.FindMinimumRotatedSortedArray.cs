using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FindMinimumRotatedSortedArray
    {
        /// <summary>
        /// Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        //(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
        //Find the minimum element.
        //You may assume no duplicate exists in the array.
        // </summary>
        // <param name="nums"></param>
        /// <returns></returns>
        public static int FindMinRotatedArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                // no rotation of array exists, minumum would be first element
                if (nums[end] > nums[start])
                {
                    return nums[start];
                }

                int mid = (start + end) / 2;

                // if mid element is bigger than start then first half is sorted, 
                // rotation will be in the second half
                if (nums[mid] >= nums[start])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return nums[start];
        }
    }
}
