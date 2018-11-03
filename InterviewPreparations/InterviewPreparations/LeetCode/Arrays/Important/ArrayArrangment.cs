using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ArrayArrangment
    {
        /// <summary>
        /// Arrange the elements in a way so postive elements should come at the end of array
        /// 7 4 -5 -7 8 -5 10 2 -10 14
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] PositiveElementsAtEndsInArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return nums;
            }

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // store the current element in the key
                int key = nums[i];

                //if this is positive number, dont do anything
                if (key > 0)
                {
                    continue;
                }

                //if it is negative number, we need to shift the negative number now
                j = i - 1;

                while (j >= 0 && nums[j] > 0)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = key;
            }

            return nums;
        }

        /// <summary>
        /// Arrange the elements in a way so positive elements should come at the end of array
        /// 7 4 -5 -7 8 -5 10 2 -10 14
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] NegativeElementsAtEndsInArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return nums;
            }

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];

                if (key < 0)
                {
                    continue;
                }

                j = i - 1;

                while (j >= 0 && nums[j] < 0)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = key;
            }

            return nums;
        }
    }
}
