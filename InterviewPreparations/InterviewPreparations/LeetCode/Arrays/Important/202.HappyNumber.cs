using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class HappyNumber
    {
        /// <summary>
        //  Write an algorithm to determine if a number is "happy".
        //  A happy number is a number defined by the following process: Starting with any positive 
        //  integer, replace the number by the sum of the squares of its digits,
        //  and repeat the process until the number equals 1 (where it will stay), 
        //  or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.
        //  Example: 19 is a happy number
        //  1^2 + 9^2 = 82
        //  8^2 + 2^2 = 68
        //  6^2 + 8^2 = 100
        //  1^2 + 0^2 + 0^2 = 1
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static bool IsHappy(int n)
        {
            int slow = n, fast = n;

            do
            {
                slow = calculated(slow);
                fast = calculated(fast);
                fast = calculated(fast);
            }
            while (slow != fast);

            if (slow == 1)
            {
                return true;
            }

            return false;
        }

        public static int calculated(int n)
        {
            int sum = 0;
            int temp;
            while (n >= 1)
            {
                temp = n % 10;
                sum = sum + (temp * temp);
                n = n / 10;
            }

            return sum;
        }
    }
}
