using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ShortestUnSortedContinousSubArray
    {
        /// <summary>
        /// Given an integer array, you need to find one continuous subarray that if you only sort this subarray in ascending order, then the whole array will be sorted in ascending order, too.
        //  You need to find the shortest such subarray and output its length.
        //  Example 1:
        //  Input: [2, 6, 4, 8, 10, 9, 15]
        //  Output: 5
        //  Explanation: You need to sort [6, 4, 8, 10, 9] in ascending order to make the whole array sorted in ascending order.
        //  Note:
        //  Then length of the input array is in range[1, 10, 000].
        //  The input array may contain duplicates, so ascending order here means <=.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>

        public static int ShortestUnsortedSubArray(int[] nums)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            if (nums.Length < 1)
            {
                return -1;
            }

            int left = 0;
            int right = nums.Length - 1;

            if (left == right)
            {
                return 0;
            }

            int[] temp = (int[])nums.Clone();
            Array.Sort(nums);

            while (left <= right && nums[left] == temp[left])
            {
                left++;
            }

            while (right > left && nums[right] == temp[right])
            {
                right--;
            }

            #region Single Loop
            //int start = -1;
            //int end = -1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != temp[i])
            //    {
            //        if (start == -1)
            //        {
            //            start = i;
            //        }
            //        end = i;
            //    }
            //}
            #endregion

            return right - left + 1;
        }
        public static int ShortestUnsortedSubArrayNotWorking(int[] nums)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            int leftIndex = -1;
            int rightIndex = -1;

            int left = 0;
            int right = nums.Length - 1;

            if (left == right)
            {
                return 0;
            }

            int descendingOrder = 0;
            int ascendingOrder = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] >= nums[i + 1])
                {
                    descendingOrder++;
                }

                if (nums[i] <= nums[i + 1])
                {
                    ascendingOrder++;
                }

            }

            if (descendingOrder == nums.Length - 1)
            {
                return descendingOrder + 1;
            }

            if (ascendingOrder == nums.Length - 1)
            {
                return 0;
            }

            int minLength = int.MaxValue;

            int prevLeft = 0;
            int prevRight = 0;

            while (left <= right)
            {
                if (nums[left + 1] <= nums[left] && prevLeft != nums[left])
                {
                    leftIndex = left;
                }

                if (nums[right - 1] >= nums[right] && prevRight != nums[right])
                {
                    rightIndex = right;
                }

                if (leftIndex != -1 || rightIndex != -1)
                {
                    minLength = Math.Min(minLength, rightIndex - leftIndex) + 1;
                    leftIndex = -1;
                    rightIndex = -1;
                }

                prevLeft = nums[left];
                prevRight = nums[right];

                left++;
                right--;
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}
