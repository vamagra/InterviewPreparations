using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MoveZeroes
    {
        /// <summary>
        /// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        //  For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be[1, 3, 12, 0, 0].
        //  Note:
        //  You must do this in-place without making a copy of the array.
        //  Minimize the total number of operations.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] MoveAllZerosInEnd(int[] nums)
        {
            if (nums.Length < 1)
            {
                return null;
            }

            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[counter++] = nums[i];
                }
            }

            for (int i = counter; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;

            //Ind Solutions O(n)

            //int j = 0;
            //for (int i = 0; i < nums.length; i++)
            //{
            //    if (nums[i] != 0)
            //    {
            //        int temp = nums[j];
            //        nums[j] = nums[i];
            //        nums[i] = temp;
            //        j++;
            //    }
            //}
        }
    }
}
