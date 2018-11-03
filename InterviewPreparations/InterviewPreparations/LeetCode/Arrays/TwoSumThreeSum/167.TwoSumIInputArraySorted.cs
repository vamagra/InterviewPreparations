using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{

    class TwoSumIInputArraySorted
    {
        /// <summary>
        /// Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
        //  The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.Please note that your returned answers(both index1 and index2) are not zero-based.
        //  You may assume that each input would have exactly one solution and you may not use the same element twice.
        //  Input: numbers={ 2, 7, 11, 15}, target=9
        //  Output: index1=1, index2=2
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] resultedIndices = new int[2];

            if (nums.Length < 1)
            {
                return resultedIndices;
            }

            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                if (nums[start] + nums[end] == target)
                {
                    resultedIndices[0] = start + 1;
                    resultedIndices[1] = end + 1;
                    break;
                }
                else if (nums[start] + nums[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return resultedIndices;
        } 

    }
}
