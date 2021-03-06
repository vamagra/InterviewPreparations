﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ContinuousSubArraySum
    {
        /// <summary>
        // Given a list of non-negative numbers and a target integer k, 
        // write a function to check if the array has a continuous subarray of size at least 2 that 
        // sums up to the multiple of k, that is, sums up to n*k where n is also an integer.
        //  Example 1:
        //  Input: [23, 2, 4, 6, 7],  k=6
        //  Output: True
        //  Explanation: Because[2, 4] is a continuous subarray of size 2 and sums up to 6.
        //  Example 2:
        //  Input: [23, 2, 6, 4, 7],  k=6
        //  Output: True
        //  Explanation: Because[23, 2, 6, 4, 7] is an continuous subarray of size 5 and sums up to 42.
        //  Note:
        //  The length of the array won't exceed 10,000.
        //  You may assume the sum of all the numbers is in the range of a signed 32-bit integer.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
       
        public static bool ContinuousSubArraySumWithK(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return false;
            }

            //Corner Case 1
            if (k < 0)
            {
                k = -k;
            }

            //Corner Case2
            //if there are two continueous zero, then return true
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0 && nums[i + 1] == 0 && k == 0)
                    return true;
            }

            //Corner Case 3
            if (k == 0)
            {
                return false;
            }


            int currSum = 0;

            IDictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);

            for (int i = 0; i < nums.Length; i++)
            {
                currSum = currSum + nums[i];

                if (k != 0)
                {
                    currSum = currSum % k;
                }

                //check for the 
                if (dict.ContainsKey(currSum))
                {
                    if (i - dict[currSum] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    dict.Add(currSum, i);
                }
            }

            return false;
        }
    }
}
