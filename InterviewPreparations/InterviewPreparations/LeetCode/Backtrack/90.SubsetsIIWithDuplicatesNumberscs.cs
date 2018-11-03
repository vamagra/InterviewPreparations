using System.Collections.Generic;
using System;
namespace InterviewQuestions.LeetCode
{
    class SubsetsIIWithDuplicatesNumberscs
    {
        /// <summary>
        //  Given a collection of integers that might contain duplicates, nums, return all 
        //  possible subsets(the power set).
        //  Note: The solution set must not contain duplicate subsets.
        //  For example,
        //  If nums = [1, 2, 2], a solution is:
        //  [
        //      [2],
        //      [1],
        //      [1,2,2],
        //      [2,2],
        //      [1,2],
        //      []
        //  ]
        // </summary>
        // <param name="nums"></param>
        // <returns></returns>
        public static IList<IList<int>> GetSubSetsWithDuplicate(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length < 1)
            {
                return result;
            }

            BackTrackWithDuplicate(result, new List<int>(), nums, 0);

            return result;
        }

        public static void BackTrackWithDuplicate(IList<IList<int>> list, List<int> tempList, int[] nums, int counter)
        {
            list.Add(new List<int>(tempList));

            for (int i = counter; i < nums.Length; i++)
            {
                //skip the duplicate numbers
                if (i > counter && nums[i] == nums[i - 1])
                {
                    continue;
                }

                tempList.Add(nums[i]);
                BackTrackWithDuplicate(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
