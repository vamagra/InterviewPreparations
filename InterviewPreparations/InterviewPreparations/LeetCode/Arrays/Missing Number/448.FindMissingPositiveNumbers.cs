using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FindMissingPositiveNumbers
    {
        /// <summary>
        // Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
        // Find all the elements of[1, n] inclusive that do not appear in this array.
        // Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
        // Example:
        // Input:
        // [4,3,2,7,8,2,3,1]
        // Output:
        // [5,6]
        // </summary>
        // <param name="nums"></param>
        // <returns></returns>
        public static IList<int> FindMissingNumbersFromList(int[] nums)
        {
            #region Solution Explained
            // Brilliant idea!Because the elements in the Array are from 1 to n, so subtracting 1 will be 0 to n-1 which are 
            //  the index of the array.
            // Take input[4.3.2.7.8.2.3.1] as an example, 
            // by subtracting 1 it becomes[3.2.1.6.7.1.2.0] which is an array of index.
            // For the first iteration
            // when i = 0, it marks the nums[3] as negative, the array become[4.3.2.-7.8.2.3.1].
            // when i = 1, it marks the nums[2] as negative, the array become[4.3.-2.-7.8.2.3.1].
            // when i = 2, it marks the nums[1] as negative, the array become[4.-3.-2.-7.8.2.3.1].
            // when i = 3, it marks the nums[6] as negative, the array become[4.-3.-2.-7.8.2.-3.1].
            // when i = 4, it marks the nums[6] as negative, the array become[4.-3.-2.-7.8.2.-3.-1].
            // when i = 5, it marks the nums[6] as negative, the array become[4.-3.-2.-7.8.2.-3.-1].
            // when i = 6, it marks the nums[0] as negative, the array become[-4.-3.-2.-7.8.2.-3.-1].
            // For the second iteration
            // find nums[4] = 8 and nums[5] = 2 which > 0;
            // which means 4 and 5 are not in the index array[3.2.1.6.7.1.2.0].
            // by adding 1, 5 and 6 are not in the input[4.3.2.7.8.2.3.1]
            // return[5.6]
            #endregion

            IList<int> list = new List<int>();

            if (nums.Length < 1)
            {
                return list;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                // if the particular index value is in the array they will get negative, 
                // else they will left positive
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    list.Add(i + 1);
                }
            }

            return list;
        }
    }
}
