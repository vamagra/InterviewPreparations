using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class _3SumClosest
    {
        /// <summary>
        // Given an array S of n integers, find three integers in S such that the 
        // sum is closest to a given number, target. Return the sum of the three integers. 
        // You may assume that each input would have exactly one solution.
        // For example, given array S = { -1 2 1 - 4 }, and target = 1.
        // The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
        // </summary>
        // <param name="nums"></param>
        // <param name="target"></param>
        // <returns></returns>
        public static int ThreesumClosest(int[] nums, int target)
        {
            int result = 0;
            if (nums.Length < 1)
            {
                return result;
            }

            Array.Sort(nums);

            int minDiff = int.MaxValue;
            int closestSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int currSum = nums[i] + nums[left] + nums[right];

                    if (currSum < target)
                    {
                        left++;
                    }
                    else if (currSum > target)
                    {
                        right--;
                    }
                    else
                    {
                        return currSum;
                    }

                    int currDiff = Math.Abs(currSum - target);

                    if (minDiff > currDiff)
                    {
                        minDiff = currDiff;
                        closestSum = currSum;
                    }
                }
            }

            return closestSum;

        }
    }
}
