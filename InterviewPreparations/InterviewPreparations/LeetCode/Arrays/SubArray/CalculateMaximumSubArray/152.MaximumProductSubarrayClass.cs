using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Find the contiguous subarray within an array (containing at least one number) which has the largest product.
    //  For example, given the array[2, 3, -2, 4],
    //  the contiguous subarray[2, 3] has the largest product = 6.
    /// </summary>
    class MaximumProductSubarrayClass
    {
        public static int MaxProductSubArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int frontProduct = 1;
            int backProduct = 1;

            int maxProduct = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                //get the front product
                frontProduct = frontProduct * nums[i];

                //get the back product
                backProduct = backProduct * nums[nums.Length - i - 1];

                //update the max Product with maxProduct  or frontProduct/backProduct which ever is greter.
                maxProduct = Math.Max(maxProduct, Math.Max(frontProduct, backProduct));

                //update the front product
                frontProduct = frontProduct == 0 ? 1 : frontProduct;

                //update the back product
                backProduct = backProduct == 0 ? 1 : backProduct;
            }

            return maxProduct;
        }

        // Time Complexity - O(n)
        // Space Complexity - O(1)
    }
}
