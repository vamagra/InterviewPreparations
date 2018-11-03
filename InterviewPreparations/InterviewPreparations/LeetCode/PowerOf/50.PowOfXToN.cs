using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PowOfXToN
    {
        /// <summary>
        /// Implement pow(x, n).
        //  Example 1:
        //  Input: 2.00000, 10
        //  Output: 1024.00000
        //  Example 2:
        //  Input: 2.10000, 3
        //  Output: 9.26100
        //  </summary>
        //  <param name="x"></param>
        //  <param name="n"></param>
        /// <returns></returns>
        public static double PowerofX(double x, int n)
        {
            double temp = x;

            if (n == 0)
            {
                return 1;
            }

            temp = PowerofX(x, n / 2);

            if (n % 2 == 0)
            {
                return temp * temp;
            }
            else
            {
                if (n < 1)
                {
                    return (temp * temp) / x;
                }
                else
                {
                    return x * temp * temp;
                }
            }
        }
    }
}
