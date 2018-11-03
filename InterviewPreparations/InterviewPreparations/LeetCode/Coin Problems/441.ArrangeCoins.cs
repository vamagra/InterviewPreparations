using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ArrangeCoins
    {
        /// <summary>
        /// You have a total of n coins that you want to form in a staircase shape, where every k-th row must have exactly k coins.
        //  Given n, find the total number of full staircase rows that can be formed.
        //  n is a non-negative integer and fits within the range of a 32-bit signed integer.
        //  Example 1:
        //  n = 5
        //  The coins can form the following rows:
        //  ¤
        //  ¤ ¤
        //  ¤ ¤
        //  Because the 3rd row is incomplete, we return 2.
        //  Example 2:
        //  n = 8
        //  The coins can form the following rows:
        //  ¤
        //  ¤ ¤
        //  ¤ ¤ ¤
        //  ¤ ¤
        //  Because the 4th row is incomplete, we return 3.
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static int ArrangeCoinsStairCase(int n)
        {
            if (n < 1)
            {
                return 0;
            }

            // Idea is quite simple here
            // we need to run the loop 
            // decerement n in every cycle
            // return i-1 as soon as we n < 0

            int i = 1;

            while (true)
            {
                n = n - i;

                if (n < 0)
                {
                    return i - 1;
                }

                i++;
            }
        }
    }
}
