using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SubArrayProductLessThanKClass
    {
        /// <summary>
        /// Your are given an array of positive integers nums.
        //  Count and print the number of(contiguous) subarrays where the product of all the elements in the subarray is less than k.
        //  Example 1:
        //  Input: nums = [10, 5, 2, 6], k = 100
        //  Output: 8
        //  Explanation: The 8 subarrays that have product less than 100 are: [10], [5], [2], [6], [10, 5], [5, 2], [2, 6], [5, 2, 6].
        //  Note that[10, 5, 2] is not included as the product of 100 is not strictly less than k.
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="k"></param>
        //  <returns></returns>
        public static int numOfSubArrayProduct(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int countSubArray = 0;

            int begin = 0;
            int end = 0;

            int currProduct = 1;

            while (end < nums.Length)
            {
                currProduct = currProduct * nums[end];

                while (begin <= end && currProduct >= k)
                {
                    currProduct = currProduct / nums[begin];
                    begin++;
                }

                countSubArray = countSubArray + (end - begin + 1);
                   
                end++;
            }

            return countSubArray;
        }
        
    }
}
