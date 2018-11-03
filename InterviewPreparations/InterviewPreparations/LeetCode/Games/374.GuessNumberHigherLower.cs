using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class GuessNumberHigherLower
    {
        /// <summary>
        /// We are playing the Guess Game. The game is as follows:
        //  I pick a number from 1 to n.You have to guess which number I picked.
        //  Every time you guess wrong, I'll tell you whether the number is higher or lower.
        //  You call a pre-defined API guess(int num) which returns 3 possible results(-1, 1, or 0):
        //  -1 : My number is lower
        //   1 : My number is higher
        //  0 : Congrats! You got it!
        //  Example:
        //  n = 10, I pick 6.

        //Return 6.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GuessNumber(int n)
        {
            int i = 1;
            int j = n;

            while (i < j)
            {
                int mid = i + (j - i) / 2;

                if (guess(mid) == 0)
                {
                    return mid;
                }

                if (guess(mid) == 1)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid;
                }
            }

            return j;
        }

        private static int guess(int n)
        {
            return 1;
        }
    }
}
