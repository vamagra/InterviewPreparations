using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class Subsets
    {
        /// <summary>
        /// Given a set of distinct integers, nums, return all possible subsets (the power set).
        //        Note: The solution set must not contain duplicate subsets.
        //        For example,
        //        If nums = [1, 2, 3], a solution is:
        //        [
        //          [3],
        //          [1],
        //          [2],
        //          [1,2,3],
        //          [1,3],
        //          [2,3],
        //          [1,2],
        //          []
        //]
        // </summary>
        // <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> GetSubsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length < 1)
            {
                return result;
            }

            Backtrack(result, new List<int>(), nums, 0);   

            return result;
        }

        private static void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, int counter)
        {
            list.Add(new List<int>(tempList));

            for (int i = counter; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, i + 1); //here i+1 beacuse we can not repeat or use the same number
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
