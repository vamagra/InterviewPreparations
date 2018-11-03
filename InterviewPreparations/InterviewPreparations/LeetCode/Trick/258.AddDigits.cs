using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class AddDigits
    {
        /// <summary>
        /// Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
        //  For example:
        //  Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.
        //  Follow up:
        //  Could you do it without any loop/recursion in O(1) runtime?
        //  </summary>
        //  <param name="n"></param>
        /// <returns></returns>
        public static int AddDigit(int n)
        {
            int result = 0;

            if (n < 10)
            {
                return n;
            }

            while (n > 0)
            {
                result = result + (n % 10);
                n = n / 10;
            }

            if (result > 10)
            {
                result = AddDigit(result);
            }

            return result;
        }
    }
}
