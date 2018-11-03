using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MoveZeroRemoveDuplicates
    {
        /// <summary>
        /// Given an array nums, which is sorted (besides 0 in between numbers), write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements and maintaining only one copy of each non-zero element.
        //  For example, given nums = [0, 1, 1, 0, 3, 3, 0, 3, 4, 5, 0, 5, 5, 12], after calling your function, nums should be[1, 3, 4, 5, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0].
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] MoveZero(int[] nums)
        {
            if (nums.Length < 1)
            {
                return null;
            }

            int counter = 0;
            int prevNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && prevNumber != nums[i])
                {
                    prevNumber = nums[i];
                    nums[counter++] = nums[i];
                }
            }

            for (int i = counter; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
