using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class TrappingRainWaterClass
    {
        /// <summary>
        /// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
        //  For example,
        //  Given[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1], return 6.
        //  The above elevation map is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]. In this case, 6 units of rain water (blue section) are being trapped. 
        //  Thanks Marcos for contributing this image!
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int TrappingWater(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int left = 0;
            int right = nums.Length-1;

            int leftMax = 0;
            int rightMax = 0;

            int totalWater = 0;

            while (left <= right)
            {
                //get the max bar from the left
                leftMax = Math.Max(leftMax, nums[left]);

                //get the max bar from the right
                rightMax = Math.Max(rightMax, nums[right]);

                if (leftMax < rightMax)
                {  
                    // if right bar is bigger then get the maxwater from left tower
                    totalWater += leftMax - nums[left];
                    left++; 
                }
                else
                {
                    // if left bar is bigger then get the maxwater from right tower
                    totalWater += rightMax - nums[right];
                    right--;
                }
            }

            return totalWater;
        }
    }
}
