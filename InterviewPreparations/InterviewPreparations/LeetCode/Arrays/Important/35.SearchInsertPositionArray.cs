using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SearchInsertPositionArray
    {
        /// <summary>
        /// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        
        //  You may assume no duplicates in the array.
        //  Example 1:
        //  Input: [1,3,5,6], 5
        //  Output: 2
        //  Example 2:

        //  Input: [1,3,5,6], 2
        //  Output: 1
        //  Example 3:

        //  Input: [1,3,5,6], 7
        //  Output: 4
        //  Example 1:

        //  Input: [1,3,5,6], 0
        //  Output: 0
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                //if target is less than first item
                if (target < nums[left])
                {
                    return left;
                }

                //if target is greater than last item
                if (target > nums[right])
                {
                    return right + 1;
                }

                int mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
