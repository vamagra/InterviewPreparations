using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    // Given an array of integers and an integer k, find out whether there are two distinct 
    // indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
    // Example 1:
    // Input: nums = [1,2,3,1], k = 3
    // Output: true
    // Example 2:
    // Input: nums = [1,0,1,1], k = 1
    // Output: true
    // Example 3:
    // Input: nums = [1,2,3,1,2,3], k = 2
    // Output: false
    // </summary>
    class ContainsDuplicateII
    {
        public static bool IsContainsDuplicateII(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return false;
            }

            bool isDuplicate = false;
            IDictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    isDuplicate = true;

                    if (i - dict[nums[i]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            if (isDuplicate && nums.Length < k)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
