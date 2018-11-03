using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SubArraySumEqualK
    {
        /// <summary>
        /// Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.
        //  Example 1:
        //  Input:nums = [1,1,1], k = 2
        //  Output: 2
        //  Note:
        //  The length of the array is in range[1, 20, 000].
        //  The range of numbers in the array is [-1000, 1000]
        //  and the range of the integer k is [-1e7, 1e7].
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="k"></param>
        /// <returns></returns>
        
        public static int TotalSubArraySumEqualsKhashMap(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            IDictionary<int, int> mapDict = new Dictionary<int, int>();

            int count = 0;
            mapDict.Add(0, 1);

            int currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currSum = currSum + nums[i];

                if (mapDict.ContainsKey(currSum - k))
                {
                    count += mapDict[currSum - k];
                }

                if (!mapDict.ContainsKey(currSum))
                {
                    mapDict.Add(currSum, 1);
                }
                else
                {
                    mapDict[currSum]++;
                }
            }

            return count;
        }

        public static int TotalSubArraySumEqualsK(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            int totalSubArray = 0;
            int currSum = 0;
            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currSum = currSum + nums[i];

                while (currSum >= k)
                {
                    currSum = currSum - nums[start];
                    start++;
                    totalSubArray++;
                }
            }

            return totalSubArray;
        }


    }
}
