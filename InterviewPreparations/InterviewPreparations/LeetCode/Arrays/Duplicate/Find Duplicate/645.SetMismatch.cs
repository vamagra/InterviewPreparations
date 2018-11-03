using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SetMismatch
    {
        /// <summary>
        /// The set S originally contains numbers from 1 to n. But unfortunately, due to the data error, one of the numbers in the set got duplicated to another number in the set, which results in repetition of one number and loss of another number.
        //  Given an array nums representing the data status of this set after the error. 
        //  Your task is to firstly find the number occurs twice and then find the number that is missing.
        //  Return them in the form of an array.
        //  Example 1:
        //  Input: nums = [1, 2, 2, 4]
        //  Output: [2,3]
        //  Note:
        //  The given array size will in the range [2, 10000].
        //  The given array's numbers won't have any order.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int[] FindValuesSetMismatch(int[] nums)
        {
            int[] result = new int[2];

            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            // find the duplicate number
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if (nums[index] < 0)
                {
                    result[0] = Math.Abs(nums[i]);
                }

                nums[index] = -nums[index];
            }

            // find the missing number
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result[1] = i + 1;
                }
            }

            return result;
        }
    }
}
