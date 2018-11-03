using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PowerFour
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n < 1)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }

            while (n % 4 == 0)
            {
                n = n / 4;
            }

            return n == 1;
        }
    }
}
