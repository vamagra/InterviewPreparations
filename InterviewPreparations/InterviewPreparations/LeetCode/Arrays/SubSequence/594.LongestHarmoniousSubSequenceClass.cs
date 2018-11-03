using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class LongestHarmoniousSubSequenceClass
    {
        /// <summary>
        //  We define a harmonious array is an array where the difference between its maximum value and its minimum value is exactly 1.
        //  Now, given an integer array, you need to find the length of its longest harmonious subsequence among all its possible subsequences.
        //  Example 1:
        //  Input: [1,3,2,2,5,2,3,7]
        //  Input [1,2,2,2,3,3,5,7]
        //  Output: 5
        //  Explanation: The longest harmonious subsequence is [3,2,2,2,3].
        //  Note: The length of the input array will not exceed 20,000.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int LongestHSS(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            IDictionary<int, int> dict = new Dictionary<int, int>();
            int maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }

                if (dict.ContainsKey(nums[i] - 1))
                {
                    maxLength = Math.Max(maxLength, dict[nums[i] - 1] + dict[nums[i]]);
                }

                if (dict.ContainsKey(nums[i] + 1))
                {
                    maxLength = Math.Max(maxLength, dict[nums[i] + 1] + dict[nums[i]]);
                }
            }

            return maxLength;
        }

        public static int LongestTwoPointer(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            Array.Sort(nums);

            int maxLength = 0;
            int startIndex = 0;

            int nextStartIndex = 0;

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] - nums[startIndex] > 1)
                {
                    startIndex = nextStartIndex;
                }

                // when difference is exactly one update the maxLength
                if (nums[i] - nums[startIndex] == 1)
                {
                    maxLength = Math.Max(maxLength, (i - startIndex) + 1);
                }
                //when two number are not equal update the startIndex
                if (nums[i] != nums[i - 1])
                {
                    nextStartIndex = i;
                }
            }

            return maxLength;
        }
    }
}
