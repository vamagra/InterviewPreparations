using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class IncreasingSubsequence
    {
        /// <summary>
        /// Given an integer array, your task is to find all the different possible increasing subsequences of the given array, 
        //  and the length of an increasing subsequence should be at least 2 .
        //  Example:
        //  Input:  [4, 6, 7, 7]
        //  Output: [[4, 6], [4, 7], [4, 6, 7], [4, 6, 7, 7], [6, 7], [6, 7, 7], [7,7], [4,7,7]]
        //  Note:
        //  The length of the given array will not exceed 15.
        //  The range of integer in the given array is [-100,100].
        //  The given array may contain duplicates, and two equal integers should also be considered as a special case of increasing sequence.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static IList<IList<int>> FindSubSequence(int[] nums)
        {
            IList<IList<int>> resultedList = new List<IList<int>>();

            Backtrack(resultedList, new List<int>(), nums, 0);

            return resultedList;
        }

        private static void Backtrack(IList<IList<int>> resultedList, List<int> list, int[] nums, int start)
        {
            if (list.Count >= 2)
            {
                resultedList.Add(new List<int>(list));
            }

            for (int i = start; i < nums.Length; i++)
            {
                // skip the duplicate numbers
                if (i > start && nums[i] == nums[i - 1])
                {
                    continue;
                }

                list.Add(nums[i]);
                Backtrack(resultedList, list, nums, i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
