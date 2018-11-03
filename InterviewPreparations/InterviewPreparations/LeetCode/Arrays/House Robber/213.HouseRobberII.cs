using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class HouseRobberII
    {
        /// <summary>
        /// Note: This is an extension of House Robber.
        //  After robbing those houses on that street, the thief has found himself a new place for his thievery so that he will not get too much attention.
        //  This time, all houses at this place are arranged in a circle.That means the first house is the neighbor of the last one. 
        //  Meanwhile, the security system for these houses remain the same as for those in the previous street.
        //  Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
        // </summary>
        // <param name="nums"></param>
        /// <returns></returns>
        public static int RobHouseInCircle(int[] nums)
        {
            //you just need to get the max of last house and second last house

            if (nums.Length < 1)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            // Basically, there are only three possible cases:

            // (1) rob 0, but leave n - 1 untouched, 
            // (2) leave 0 untouched, rob n-1, 
            // (3) leave both 0 and n-1 untouched.Obviously, 
            // case (3) can be covered by case(1) or case (2) in the simple House Robber problem.
            // Hence, the above solution covers all the possible cases.

            int length = nums.Length;
            // 0 - length-2 (from first home to second last home)
            // 1 - length-1) from secong home to last home)
            return Math.Max(roberHelper(nums, 0, length - 2), roberHelper(nums, 1, length - 1));
        }

        public static int roberHelper(int[] nums, int start, int end)
        {
            int maxEvenHouse = 0;
            int maxOddHouse = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    maxEvenHouse += nums[i];
                    maxEvenHouse = Math.Max(maxEvenHouse, maxOddHouse);
                }
                else
                {
                    maxOddHouse += nums[i];
                    maxOddHouse = Math.Max(maxOddHouse, maxEvenHouse);
                }
            }

            return Math.Max(maxEvenHouse, maxOddHouse);
        }
    }
}
