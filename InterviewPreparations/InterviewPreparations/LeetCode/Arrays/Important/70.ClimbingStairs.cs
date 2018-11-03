using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ClimbingStairs
    {
        /// <summary>
        /// You are climbing a stair case. It takes n steps to reach to the top.
        //  Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        //  Note: Given n will be a positive integer.
        //  Example 1:

        //  Input: 2
        //  Output:  2
        //  Explanation:  There are two ways to climb to the top.
        //  1. 1 step + 1 step
        //  2. 2 steps
        //  Example 2:
        //  Input: 3
        //  Output:  3
        //  Explanation:  There are three ways to climb to the top.
        //  1. 1 step + 1 step + 1 step
        //  2. 1 step + 2 steps
        //  3. 2 steps + 1 step
        //  </summary>
        //  <param name="n"></param>
        // <returns></returns>
        public static int ClimbStairs(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            int one_step_before = 2;
            int two_step_before = 1;

            int all_way = 0;

            //Fibinocii series
            for (int i = 2; i < n; i++)
            {
                all_way = two_step_before + one_step_before;

                two_step_before = one_step_before;
                one_step_before = all_way;
            }

            return all_way;
        }
    }
}
