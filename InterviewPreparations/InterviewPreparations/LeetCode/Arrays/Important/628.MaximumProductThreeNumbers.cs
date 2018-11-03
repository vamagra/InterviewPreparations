using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MaximumProductThreeNumbers
    {
        /// <summary>
        //  Given an integer array, find three numbers whose product is maximum and output the maximum product.
        //  Example 1:
        //  Input: [1,2,3]
        //  Output: 6
        //  Example 2:
        //  Input: [1,2,3,4]
        //  Output: 24
        //  Note:
        //  The length of the given array will be in range[3, 104] and all elements are in the range [-1000, 1000].
        //  Multiplication of any three numbers in the input won't exceed the range of 32-bit signed integer.
        public static int MaxProductThreeNum(int[] nums)
        {
            if (nums.Length < 3)
            {
                return -1;
            }

            // there are three base cases that we need to consider
            // 1. Get the three max and two min number
            // 2. Calculate (Math.max(nums[n-1]*nums[n-2]*nums[n-3], nums[0]*nums[1]*nums[n-1))  

            int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;
            int min1 = int.MaxValue, min2 = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                // update the max three numbers
                if (nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] > max3)
                {
                    max3 = nums[i];
                }

                // update the min two numbers
                if (nums[i] < min1)
                {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (nums[i] < min2)
                {
                    min2 = nums[i];
                }
            }

            return (Math.Max(max1 * max2 * max3, max1 * min1 * min2));
        }
    }
}
