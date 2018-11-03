using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SingleNumber
    {
        /// <summary>
        /// Given an array of integers, every element appears twice except for one. Find that single one.
        //  Note : Your algorithm should have a linear runtime complexity.Could you implement it without using extra memory?
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        /// 

        #region Explanation
        // For anyone who didn’t understood why this works here is an explanation. 
        // This XOR operation works because it’s like XORing all the numbers by itself. 
        // So if the array is {2,1,4,5,2,4,1}
        // then it will be like we are performing this operation
        // ((2^2)^(1^1)^(4^4)^(5)) => (0^0^0^5) => 5.
        // Hence picking the odd one out ( 5 in this case).
        #endregion
        public static int FindSingleNumberInArray(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return -1;
            }

            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            return result;
        }
    }
}
