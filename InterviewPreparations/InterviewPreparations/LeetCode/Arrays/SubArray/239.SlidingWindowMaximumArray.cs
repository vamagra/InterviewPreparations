using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterviewQuestions.LeetCode
{
    class SlidingWindowMaximumArray
    {
        /// <summary>
        // Given an array nums, there is a sliding window of size k which is moving from the 
        // very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.
        //  For example,
        //  Given nums = [1,3,-1,-3,5,3,6,7], and k = 3.
        //Window position Max
        //---------------               -----
        // [1  3  -1] -3  5  3  6  7       3
        // 1 [3  -1  -3] 5  3  6  7       3
        // 1  3 [-1  -3  5] 3  6  7       5
        // 1  3  -1 [-3  5  3] 6  7       5
        // 1  3  -1  -3 [5  3  6] 7       6
        // 1  3  -1  -3  5 [3  6  7]      7
        //Therefore, return the max sliding window as [3,3,5,5,6,7].
        //Note: 
        //You may assume k is always valid, ie: 1 ≤ k ≤ input array's size for non-empty array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] SlidingWindowMaxiuminArray(int[] nums, int k)
        {
            if (nums.Length < 1 || k < 1 || k == 1 || nums.Length < k)
            {
                return nums;
            }

            int[] maxArray = new int[nums.Length - k + 1];

            int slidingWindowBeginCounter = 0;
            int slidingWindowEndCounter = 0;
            int maxNumber = 0;

            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                //update the begin and end counter of sliding window
                slidingWindowBeginCounter = i;

                slidingWindowEndCounter = slidingWindowBeginCounter + k;

                maxNumber = 0;

                while (slidingWindowBeginCounter < slidingWindowEndCounter)
                {
                    maxNumber = Math.Max(maxNumber, nums[slidingWindowBeginCounter]);
                    slidingWindowBeginCounter++;
                }

                //update the max number from sliding window
                maxArray[i] = maxNumber;
            }

            return maxArray;
        }
    }
}
