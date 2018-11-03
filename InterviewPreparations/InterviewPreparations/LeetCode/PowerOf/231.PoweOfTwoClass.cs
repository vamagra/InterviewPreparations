using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PoweOfTwoClass
    {
        /// <summary>
        /// Given an integer, write a function to determine if it is a power of two.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(int n)
        {
            bool IsPower = false;

            if (n < 1)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    if (n > 2)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    IsPower = false;
                    break;
                }
            }

            return IsPower;
        }
    }
}
