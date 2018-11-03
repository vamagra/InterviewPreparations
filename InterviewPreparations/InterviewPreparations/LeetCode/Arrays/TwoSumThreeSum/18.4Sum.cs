using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.TwoSumThreeSum
{
    class _4Sum
    {
        /// <summary>
        /// Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.
        //  Note:
        //  The solution set must not contain duplicate quadruplets.
        //  Example:
        //  Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.
        //  A solution set is:
        //  [
        //      [-1,  0, 0, 1],
        //      [-2, -1, 1, 2],
        //      [-2,  0, 0, 2]
        //  ]
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static List<List<int>> Caluclate4Sum(int[] nums, int target)
        {
            List<List<int>> resultList = new List<List<int>>();

            if (nums == null || nums.Length < 1)
            {
                return resultList;
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                // handle duplicates
                if (i >= 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    int left = j + 1;
                    int right = nums.Length - 1;

                    while (left <= right)
                    {
                        int currSum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (currSum == target)
                        {
                            List<int> list = new List<int>();
                            list.Add(nums[i]);
                            list.Add(nums[j]);
                            list.Add(nums[left]);
                            list.Add(nums[right]);

                            resultList.Add(list);

                            left++;
                            right--;
                        }
                        else if (currSum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }

                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }

                        while (left < right && nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                }
            }

            return resultList;
        }             
    }
}
