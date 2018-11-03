using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class WiggleSort
    {
        /// <summary>
        // Given an unsorted array nums, reorder it in-place such that nums[0] <= nums[1] >= nums[2] <= nums[3]....
        // For example, given nums = [3, 5, 2, 1, 6, 4], one possible answer is [1, 6, 2, 5, 3, 4]. no repeating elements in input
        // </summary>
        // <param name="nums"></param>
        public static void SortWiggle(int[] nums)
        {
            /*
             Let's look into the problem closely. We can see if two consecutive elements are in wiggle sort order
             i.e. A[i-1]<=A[i]>=A[i+1] then it’s neighbors are also in wiggle order. So we could actually check by even and odd positions –
             A[even] <= A[odd],
             A[odd] >= A[even].
             */

            if (nums != null && nums.Length < 1)
            {
                return;
            }

            // array will be in sorted order if 
            // Odd elemnets should be greater than its previous element
            // event elements should be less than its previous elements
            // if any of the condition doesn't full fill we need to swap the curr element
            // from its previous element

            for (int i = 0; i < nums.Length; i++)
            {
                if ((i % 2 == 1 && nums[i] < nums[i - 1]) || (i != 0 && i % 2 == 0 && nums[i] > nums[i - 1]))
                {
                    swap(nums, i, i - 1);
                }
            }
        }

        public static void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
