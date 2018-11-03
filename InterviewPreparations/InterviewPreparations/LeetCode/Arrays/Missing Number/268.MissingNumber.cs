using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MissingNumber
    {
        /// <summary>
        /// Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
        //  Example 1
        //  Input: [3,0,1]
        //  Output: 2
        //  Example 2
        //  Input: [9,6,4,2,3,5,7,0,1]
        //  Output: 8
        //  Note:
        //  Your algorithm should run in linear runtime complexity.Could you implement it using only constant extra space complexity?
        // </summary>
        // <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumberInArray(int[] nums)
        {
            int n = nums.Length;

            //int sum = n * (n + 1) / 2;

            //for (int i = 0; i < n; i++)
            //{
            //    sum = sum - nums[i];
            //}

            //return sum;

            int sum = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                sum += +i;
                sum -= nums[i - 1];
            }

            return sum;
        }
    }
}
