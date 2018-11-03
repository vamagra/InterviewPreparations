using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidPerfectSquareClass
    {
        /// <summary>
        /// Given a positive integer num, write a function which returns True if num is a perfect square else False.
        //  Note: Do not use any built-in library function such as sqrt.
        //  Example 1:
        //  Input: 16
        //  Returns: True
        //  Example 2:
        //  Input: 14
        //  Returns: False
        //  </summary>
        //  <param name="num"></param>
        //  <returns></returns>

        public static bool IsSquare(int n)
        {
            // As every square is 1+3+5+7+9........

            if (n < 1)
            {
                return false;
            }

            int i = 1;

            while (n > 0)
            {
                n = n - i;
                i += 2;
            }

            return n == 0;
        }

        public static bool IsValidPerfectSquare(int num)
        {
            if (num < 1)
            {
                return false;
            }

            long x = num;

            while (x * x > num)
            {
                x = (x + num / x) / 2;
            }

            return x * x == num;
        }
    }
}
