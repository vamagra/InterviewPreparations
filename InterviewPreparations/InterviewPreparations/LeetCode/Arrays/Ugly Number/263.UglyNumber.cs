using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class UglyNumber
    {
        /// <summary>
        /// Write a program to check whether a given number is an ugly number.
        //  Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. 
        //  For example, 6, 8 are ugly while 14 is not ugly since it includes another prime factor 7.
        //  Note that 1 is typically treated as an ugly number.
        //  </summary>
        //  <param name="n"></param>
        /// <returns></returns>
        public static bool IsUglyNumber(int n)
        {
            if (n < 1)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }

            for (int i = 2; i <= 5;)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }

                if (n % i == 0)
                {
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }

            return n > 1;
        }
    }
}
