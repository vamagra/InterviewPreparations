using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class Sqrt_x_
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

        public static int Sqrt(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }

            int left = 0;
            int right = x;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (x / mid == mid)
                {
                    return mid;
                }
                else if (x / mid < mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }
        public static int MySqrt(int x)
        {
            long r = x;

            while (r * r > x)
            {
                r = (r + x / r) / 2;
            }

            return Convert.ToInt32(r);
        }
    }
}
