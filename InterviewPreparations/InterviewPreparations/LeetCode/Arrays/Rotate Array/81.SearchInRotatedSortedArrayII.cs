using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SearchInRotatedSortedArrayII
    {
        /// <summary>
        //  Follow up for "Search in Rotated Sorted Array":
        //  What if duplicates are allowed?
        //  Would this affect the run-time complexity? How and why?
        //  Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        //  (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
        //  Write a function to determine if a given target is in the array.
        //  The array may contain duplicates.
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="target"></param>
        //  <returns></returns>
        public static bool IsRotatedSortedArraySearch(int[] nums, int target)
        {
            if (nums.Length < 1)
            {
                return false;
            }

            if (nums.Length == 1)
            {
                return (nums[0] == target);
            }

            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (nums[start] == target || nums[end] == target)
                {
                    return true;
                }

                //check if mid element is equal to target
                if (nums[mid] == target)
                {
                    return true;
                }

                //check if left side sorted
                if (nums[start] < nums[mid])
                {
                    if (target >= nums[start] && target < nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (nums[mid] < nums[end])
                {
                    if (target > nums[mid] && target <= nums[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                else
                {
                    end--;
                }
            }

            return nums[start] == target ? true : false;
        }
    }
}
