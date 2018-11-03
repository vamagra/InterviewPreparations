using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class NumberOfBinaryOnes
    {
        /// <summary>
        /// Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).
        //  For example, the 32-bit integer ’11' has binary representation 00000000000000000000000000001011, so the function should return 3.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Count1sInBinary(uint n)
        {
            //  say n is 5
            //  count = 0
            //  5 = 101
            //  n - 1 is 4
            //  4 = 100
            //  101 & 100 = 100
            //  count = 1;
            //  n = 100
            //  3 = 11
            //  100 & 11 = 0
            //  count = 2

            int count = 0;

            while (n != 0)
            {
                count++;
                n = n & (n - 1);
            }

            return count;
        }
    }
}
