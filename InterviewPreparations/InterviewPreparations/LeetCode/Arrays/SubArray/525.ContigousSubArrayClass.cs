using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ContigousSubArrayClass
    {
        /// <summary>
        /// Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.
        //  Example 1:
        //  Input: [0,1]
        //  Output: 2
        //  Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.
        //  Example 2:
        //  Input: [0,1,0]
        //  Output: 2
        //  Explanation: [0, 1] (or[1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ContiguousArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int zero = 0;
            int one = 0;

            IDictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);


            // in this question we need to count the length of sub array which has equal number of \
            // 0 and 1, what we are doing here is keep counting the one and zero, and store the index of zeroCount - oneCount in dict
            // As zeroCount == oneCount we check zeroCount - oneCount which will be 0 if they are equal and for that we have
            // dict entry with 0 and we get the max length till this index

            int maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zero++;
                }

                if (nums[i] == 1)
                {
                    one++;
                }

                if (dict.ContainsKey(zero - one))
                {
                    maxLength = Math.Max(maxLength, i - dict[zero - one]);
                }
                else
                {
                    dict.Add(zero - one, i);
                }
            }

            return maxLength;
        }
    }
}
