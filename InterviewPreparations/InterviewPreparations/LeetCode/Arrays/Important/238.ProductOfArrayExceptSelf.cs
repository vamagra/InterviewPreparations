using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ProductOfArrayExceptSelf
    {
        /// <summary>
        /// Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
        //  Solve it without division and in O(n).
        //  For example, given[1, 2, 3, 4], return [24,12,8,6].
        //  Follow up:
        //  Could you solve it with constant space complexity? (Note: The output array does not count as extra space for the purpose of space complexity analysis.)
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>

        #region Explnation
        // The idea is simply.The product basically is calculated using the numbers before the current number and the 
        // numbers after the current number.Thus, we can scan the array twice. First, we calcuate the running product of the part before the current number. Second, we calculate the running product of the part after the current number through scanning from end of the array.
        // Given numbers[2, 3, 4, 5], regarding the third number 4, the product of array except 4 is 2*3*5 which consists of two parts: left 2*3 and right 5. The product is left* right.We can get lefts and rights:
        // Numbers:     2    3    4     5
        // Lefts:            2  2*3 2*3*4
        // Rights:  3*4*5  4*5    5      
        // Let’s fill the empty with 1:
        // Numbers:     2    3    4     5
        // Lefts:       1    2  2*3 2*3*4
        // Rights:  3*4*5  4*5    5     1
        // We can calculate lefts and rights in 2 loops.The time complexity is O(n).

        #endregion
        public static int[] ProductArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return nums;
            }

            int[] resultedArray = new int[nums.Length];
            int left = 1;
            int right = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                //assign the current left
                resultedArray[i] = left;
            
                //update the current left
                left = left * nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                resultedArray[i] = resultedArray[i] * right;
                right = right * nums[i];
            }

            return resultedArray;
        }
    }
}
