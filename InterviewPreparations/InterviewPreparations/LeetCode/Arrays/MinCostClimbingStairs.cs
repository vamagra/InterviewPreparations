using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MinCostClimbingStairs
    {
        /// <summary>
        /// On a staircase, the i-th step has some non-negative cost cost[i] assigned (0 indexed).
        //  Once you pay the cost, you can either climb one or two steps.You need to find minimum cost to reach the top of the floor, and you can either start from the step with index 0, or the step with index 1.
        //  Example 1:
        //  Input: cost = [10, 15, 20]
        //  Output: 15
        //  Explanation: Cheapest is start on cost[1], pay that cost and go to the top.
        //  Example 2:
        //  Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
        //  Output: 6
        //  Explanation: Cheapest is start on cost[0], and only step on 1s, skipping cost[3].
        //  Note:
        //  cost will have a length in the range [2, 1000].
        //  Every cost[i] will be an integer in the range [0, 999].
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int MinCost(int[] nums)
        {
            if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[1] : nums[0];
            }

            int prevCost = 0;
            int prevPrevCost = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                int cost = Math.Min(prevCost + nums[i - 1], prevPrevCost + nums[i - 2]);

                prevPrevCost = prevCost;
                prevCost = cost; 
            }

            return prevCost;


            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    if (step + 1 >= nums.Length)
            //    {
            //        if (step + 1 == nums.Length)
            //        {
            //            minCost += nums[nums.Length - 1];
            //        }

            //        break;
            //    }

            //    int currStepCost = Math.Min(nums[i], nums[i + 1]);

            //    if (step + 1 < nums.Length && step + 2 < nums.Length)
            //    {
            //        step1Cost = nums[i] + nums[step + 1];
            //        step2Cost = nums[i] + nums[step + 2];
            //    }
            //    else
            //    {
            //        break;
            //    }


            //    if (step1Cost < step2Cost)
            //    {
            //        step = step + 1;
            //    }
            //    else
            //    {
            //        step = step + 2;
            //    }

            //    minCost += currStepCost;
            //}
        }
    }
}
