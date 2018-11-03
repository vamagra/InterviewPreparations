using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PlusOne
    {
        /// <summary>
        //  Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
        //  You may assume the integer do not contain any leading zero, except the number 0 itself.
        //  The digits are stored such that the most significant digit is at the head of the list.
        //  </summary>
        //  <param name="nums"></param>
        /// <returns></returns>
        public static int[] PlusOneToArray(int[] nums)
        {
            //idea is quite simple here
            int[] resultedArray = new int[nums.Length + 1];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < 9)
                {
                    nums[i]++;
                    return nums;
                }

                nums[i] = 0;
            }

            resultedArray[0] = 1;

            return resultedArray;
        }
    }
}
