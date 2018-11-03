using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseInteger
    {
        /// <summary>
        /// Given a 32-bit signed integer, reverse digits of an integer.
        //  Example 1:
        //  Input: 123
        //  Output:  321
        //  Example 2:
        //  Input: -123
        //  Output: -321
        //  Example 3:
        //  Input: 120
        //  Output: 21
        //  Note:
        //  Assume we are dealing with an environment which could only hold integers within the 32-bit signed integer range.
        //  For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            int revNumber = 0;
            int prev_Reverse_Num = 0;

            bool sign = false;

            if (x <= 0)
            {
                sign = true;
                x = x * -1;
            }

            while (x > 0)
            {
                int val = x % 10;
                revNumber = revNumber * 10 + val;

                //to check the overflow
                if ((revNumber - val)/10 != prev_Reverse_Num)
                {
                    return 0;
                }

                prev_Reverse_Num = revNumber;
                x = x / 10;
            }

            return (sign) ? (revNumber * -1) : revNumber;
        }
    }
}
