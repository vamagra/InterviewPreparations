using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MaxConsecutiveOnes
    {
        /// <summary>
        /// Given a binary array, find the maximum number of consecutive 1s in this array.
        //  Example 1:
        //  Input: [1,1,0,1,1,1]
        //  Output: 3
        //  Explanation: The first two digits or the last three digits are consecutive 1s.
        //  The maximum number of consecutive 1s is 3.
        //  Note:
        //  The input array will only contain 0 and 1.
        //  The length of input array is a positive integer and will not exceed 10,000
        // </summary>
        // <param name="nums"></param>
        /// <returns></returns>
        public static int MaxCountConsecutiveOnes(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int currCount = 0;
            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currCount++;
                    maxCount = currCount > maxCount ? currCount : maxCount;
                }
                else
                {
                    currCount = 0;
                }
            }

            return maxCount;
        }
    }
}
