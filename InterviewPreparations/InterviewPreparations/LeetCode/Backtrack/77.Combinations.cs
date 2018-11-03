using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.Backtrack
{
    class Combinations
    {
        /// <summary>
        /// Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.
        //  For example,
        //  If n = 4 and k = 2, a solution is:
        //[
        //  [2,4],
        //  [3,4],
        //  [2,3],
        //  [1,2],
        //  [1,3],
        //  [1,4],
        //]
        //  </summary>
        //  <param name="n"></param>
        //  <param name="k"></param>
        // <returns></returns>
        public List<List<int>> combine(int n, int k)
        {
            List<List<int>> res = new List<List<int>>();
            backtrack(res, n, 1, k, new List<int>());
            return res;
        }
        public void backtrack(List<List<int>> res, int n, int start, int k, List<int> list)
        {
            if (list.Count == k)
            {
                res.Add(new List<int>(list));
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    list.Add(i);
                    backtrack(res, n, i + 1, k, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
