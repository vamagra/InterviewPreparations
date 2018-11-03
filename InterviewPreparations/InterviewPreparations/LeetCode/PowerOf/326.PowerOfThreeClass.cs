using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PowerOfThreeClass
    {
        /// <summary>
        /// Given an integer, write a function to determine if it is a power of three.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }

            while (n % 3 == 0)
            {
                n = n / 3;
            }

            return n == 1;
        }
    }
}
