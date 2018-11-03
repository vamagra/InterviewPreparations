using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    //  Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
    //  (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
    //  You are given a target value to search.If found in the array return its index, otherwise return -1.
    //  You may assume no duplicate exists in the array.
    /// </summary>
    class SearchInRotatedSortedArray
    {
        public static int IsRotatedSortedArraySearch(int[] nums, int target)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            int len = nums.Length;

            int start = 0;
            int end = len - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                //check if target is equal to mid then return mid
                if (nums[mid] == target)
                {
                    return mid;
                }

                // make sure target is first of the array before mid,
                // if array mid is greater than array low its mean array is sorted till mid
                if (nums[start] <= nums[mid])
                {
                    //check if target lies is between low and mid
                    if (target >= nums[start] && target < nums[mid])
                    {
                        //set high as first part before mid
                        end = mid - 1;
                    }
                    else
                    {
                        //check the target in second part of the array after mid
                        start = mid + 1;
                    }
                }
                else 
                {
                    if (target >= nums[mid] && target <= nums[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return nums[start] == target ? start : -1;
        }
    }
}
