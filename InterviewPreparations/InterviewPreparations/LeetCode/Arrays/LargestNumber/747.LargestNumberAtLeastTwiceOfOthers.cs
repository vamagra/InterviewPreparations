using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LargestNumberAtLeastTwiceOfOthers
    {
        /// <summary>
        /// In a given integer array nums, there is always exactly one largest element.
        //  Find whether the largest element in the array is at least twice as much as every other number in the array.
        //  If it is, return the index of the largest element, otherwise return -1.
        //  Example 1:
        //  Input: nums = [3, 6, 1, 0]
        //  Output: 1
        //  Explanation: 6 is the largest integer, and for every other number in the array x,
        //  6 is more than twice as big as x.The index of value 6 is 1, so we return 1.
        //  Example 2:
        //  Input: nums = [1, 2, 3, 4]
        //  Output: -1
        //  Explanation: 4 isn't at least as big as twice the value of 3, so we return -1.
        //  Note:
        //  nums will have a length in the range [1, 50].
        //  Every nums[i] will be an integer in the range [0, 99].
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int LarestNumberTwiceOtherIndex(int[] nums)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            // To solve this idea is quite simple
            // get the max and second max and store the index.
            // check if second max * 2 < max
            //  return index else -1

            int max = int.MinValue;
            int index = -1;

            int secondMax = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    secondMax = max;
                    max = nums[i];
                    index = i;
                }
                else if (nums[i] > secondMax)
                {
                    secondMax = nums[i];
                }
            }

            return max >= secondMax * 2 ? index : -1;
        }
    }
}
