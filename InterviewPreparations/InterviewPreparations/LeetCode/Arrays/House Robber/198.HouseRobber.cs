using InterviewQuestions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class HouseRobber
    {
        /// <summary>
        /// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you 
        //  from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
        //  Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int MaximumAmountRobbedFromHouse(int[] nums)
        {
            int maxAmountEvenHouse = 0;
            int maxAmountOddHouse = 0;

            // Idea is quite simple here
            // we need to see if even number house total money is greater than odd house total money
            // iterate thourgh the houses, sum the even house money and update the maxEvenHouse money
            // simultaneously sum the odd house money and update the maxOddHouse money
            // return the max of two amount

            if (nums.Length <= 1)
            {
                return maxAmountEvenHouse;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    maxAmountEvenHouse = maxAmountEvenHouse + nums[i];
                    // this conditon is important to make sure that [2,1,1,2] - output should be 4 not 3
                    maxAmountEvenHouse = UtilityHelper.max(maxAmountEvenHouse, maxAmountOddHouse);
                }
                else
                {
                    maxAmountOddHouse = maxAmountOddHouse + nums[i];
                    maxAmountOddHouse = UtilityHelper.max(maxAmountOddHouse, maxAmountEvenHouse);
                }
            }

            return UtilityHelper.max(maxAmountEvenHouse, maxAmountOddHouse);
        }
    }
}
