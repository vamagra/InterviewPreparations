﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RemoveDuplicatesfromSortedArray
    {
        /// <summary>
        /// Given a sorted array, remove the duplicates in-place such that each element appear only once and return the new length.
        //  Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        //  Example:
        //  Given nums = [1, 1, 2],
        //  Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
        //  It doesn't matter what you leave beyond the new length.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            int counter = 0;

            if (nums.Length < 1)
            {
                return 0;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[counter++] = nums[i];
                }
            }

            nums[counter++] = nums[nums.Length - 1];
             
            return counter;
        }
    }
}
