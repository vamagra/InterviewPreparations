using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class UglyNumberII
    {
        /// <summary>
        //  Write a program to find the n-th ugly number.
        //  Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. 
        //  Example:
        //  Input: n = 10
        //  Output: 12
        //  Explanation: 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 is the sequence of the first 10 ugly numbers.
        //  Note:  
        //  1 is typically treated as an ugly number.
        //  n does not exceed 1690.
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static int FindNthPrimeFactor(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            // create an temp array for storing the prime factors

            int[] A = new int[n];

            // initialize the individual index for prime factor
            int index2 = 0;
            int index3 = 0;
            int index5 = 0;

            // initialize prime factor variables
            int factor2 = 2;
            int factor3 = 3;
            int factor5 = 5;

            // run the loop from 1 to N
            for (int i = 1; i <= n; i++)
            {
                // get the min factor value among all of them
                int minFactor = Math.Min(Math.Min(factor2, factor3), factor5);

                // assign factor value in the temp array
                A[i] = minFactor;

                // if minFactor equal to factor 2
                if (factor2 == minFactor)
                {
                    //update the factor value
                    factor2 = 2 * A[++index2];
                }

                if (factor3 == minFactor)
                {
                    factor3 = 3 * A[++index3];
                }

                if (factor5 == minFactor)
                {
                    factor5 = 5 * A[++index5];
                }
            }

            return A[n - 1];
        }
    }
}
