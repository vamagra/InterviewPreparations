    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class CountPrimes
    {
        /// <summary>
        /// Count the number of prime numbers less than a non-negative number, n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public static int ConuntPrimeII(int n)
        {
            if (n < 1)
            {
                return 0;
            }

            if (n == 1)
            {
                return 0;
            }

            int countPrime = 0;

            bool[] IsPrime = new bool[n];
        
            for (int i = 2; i < n; i++)
            {
                if (!IsPrime[i])
                {
                    countPrime++;

                    for (int j = 2; i * j < n; j++)
                    {
                        IsPrime[i * j] = true;
                    }
                }
            }

            return countPrime;
        }
    }
}
