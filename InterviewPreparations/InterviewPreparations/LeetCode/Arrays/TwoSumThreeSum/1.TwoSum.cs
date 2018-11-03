using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class TwoSum
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        //  You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //  Example:
        //  Given nums = [2, 7, 11, 15], target = 9,
        //  Because nums[0] + nums[1] = 2 + 7 = 9,
        //  return [0, 1].
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="target"></param>
        //  <returns></returns>
        //Problem with this solution is, it won't keep the original array indices intact
        public static bool CalculateTwoSumUsingSortingArray(int[] nums, int target)
        {
            bool result = false;

            int left = 0;
            int right = nums.Length - 1;
            QuickSorting.QuickSort(nums, left, right);

            while (left < right)
            {
                if (nums[left] + nums[right] == target)
                {
                    result = true;
                    break;
                }
                else if (nums[left] + nums[right] <= target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }

        public static int[] CalculateTwoSumHashmap(int[] nums, int target)
        {
            int[] result = new int[2];

            Hashtable hashmap = new Hashtable();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (hashmap.Contains(target - nums[i]))
                {
                    result[0] = Convert.ToInt32(hashmap[nums[i]]);
                    result[1] = i;
                    break;
                }
                else
                {
                    if(!hashmap.Contains(nums[i]))
                        hashmap.Add(nums[i], i);
                }
            }

            return result;
        }
    }
}
