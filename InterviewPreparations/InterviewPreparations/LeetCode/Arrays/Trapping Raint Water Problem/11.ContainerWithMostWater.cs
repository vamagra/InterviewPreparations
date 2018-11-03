using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.Utility;
namespace InterviewQuestions.LeetCode
{
    class ContainerWithMostWater
    {
        /// <summary>
        // Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
        // n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
        // Find two lines, which together with x-axis forms a container, such that the container contains the most water.
        //  Note: You may not slant the container and n is at least 2.
        // </summary>
        // <param name="height"></param>
        // <returns></returns>

        #region Solution Final
        public static int MaxWater(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int left = 0;
            int right = nums.Length - 1;

            int totalWater = 0;

            while (left <= right)
            {
                //take the min height from left and right
                int minBarHeight = Math.Min(nums[left], nums[right]);

                totalWater = Math.Max(totalWater, minBarHeight * (right - left));

                if (nums[left] < nums[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return totalWater;
        }
        #endregion


        #region Solution 1
        public static int MaxArea(int[] height)
        {
            int length = height.Length;

            if (length == 0)
            {
                return 0;
            }

            if (length == 1)
            {
                return height[0];
            }

            int[] right = new int[length];
            int[] left = new int[length];

            int water = 0;

            //fill left array first
            left[0] = height[0];
            for (int i = 1; i < length; i++)
            {
                left[i] = UtilityHelper.max(left[i - 1], height[i]);
            }

            //fill right array now
            right[length - 1] = height[length - 1];
            for (int i = length - 2; i >= 0; i--)
            {
                right[i] = UtilityHelper.max(right[i + 1], height[i]);
            }


            //count the total water
            for (int j = 0; j < length - 1; j++)
            {
                water += UtilityHelper.min(left[j], right[j]) - height[j];
            }

            return water;
        }
        #endregion

        #region Solution 2

        public static int MaxArea2(int[] height)
        {

            int X = 0;
            int totalWater = 0;

            int index = max(height, height.Length);
            int counter = 0;


            while (counter < index)
            {
                if (height[counter] > X)
                {
                    X = height[counter];
                }

                if (X != 0)
                {
                    totalWater = totalWater + (X - height[counter]);
                }

                counter++;
            }

            counter = height.Length - 1;

            while (counter > index)
            {
                if (height[counter] > X)
                {
                    X = height[counter];
                }

                if (X != 0)
                {
                    totalWater = totalWater + (X - height[counter]);
                }

                counter--;
            }

            return totalWater;
        }

        public static int max(int[] a, int n)
        {
            int max = 0;
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= max)
                {
                    max = a[i];
                    index = i;
                }
            }

            return index;
        }
        #endregion
    }
}
