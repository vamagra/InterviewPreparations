using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class CombinationSumIIWithDuplicates
    {
        /// <summary>
        /// Given a set of candidate numbers (C) (with duplicates) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> CombinationSumIIDuplicateNumber(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> res = new List<IList<int>>();
            CombinationSumBackTrackDuplicate(candidates, target, new List<int>(), res, 0);
            return res;
        }

        public static void CombinationSumBackTrackDuplicate(int[] candidates, int target, List<int> combination, IList<IList<int>> res, int start)
        {
            if (target == 0)
            {
                res.Add(new List<int>(combination));
            }

            for (int i = start; i < candidates.Count() && target >= candidates[i]; i++)
            {
                //skip duplicates
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                combination.Add(candidates[i]);
                CombinationSumBackTrackDuplicate(candidates, target - candidates[i], combination, res, i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
