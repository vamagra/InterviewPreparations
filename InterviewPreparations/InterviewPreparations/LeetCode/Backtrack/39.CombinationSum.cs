using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class CombinationSum
    {
        /// <summary>
        /// Given a set of candidate numbers (C) (without duplicates) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
        //  The same repeated number may be chosen from C unlimited number of times.
        // Note:
        // All numbers(including target) will be positive integers.
        // The solution set must not contain duplicate combinations.
        //For example, given candidate set [2, 3, 6, 7] and target 7,
        //A solution set is: 
        //[
        //  [7],
        // [2, 2, 3]
        //]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> GetCombinationSumArray(int[] candidates, int target)
        {
            // sorting is important here
            Array.Sort(candidates);
            IList<IList<int>> res = new List<IList<int>>();
            CombinationSumRecursion(candidates, target, new List<int>(), res, 0);
            return res;
        }

        public static void CombinationSumRecursion(int[] candidates, int target, List<int> combination, IList<IList<int>> res, int index)
        {
            if (target == 0)
            {
                res.Add(new List<int>(combination));
            }

            for (int i = index; i < candidates.Count() && target >= candidates[i]; i++)
            {
                combination.Add(candidates[i]);
                CombinationSumRecursion(candidates, target - candidates[i], combination, res, i);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
