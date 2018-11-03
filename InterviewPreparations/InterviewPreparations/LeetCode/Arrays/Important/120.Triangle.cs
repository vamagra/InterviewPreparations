using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class Triangle
    {
        /// <summary>
        /// Given a triangle, find the minimum path sum from top to bottom. Each step you may move to adjacent numbers on the row below.
        //  For example, given the following triangle
        //  [
        //      [2],
        //    [3,4],
        //   [6,5,7],
        //  [4,1,8,3]
        // ]
        // The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).
        //  </summary>
        //  <param name="list"></param>
        //  <returns></returns>
        public static int MinPath(IList<IList<int>> list)
        {
            if (list == null)
            {
                return int.MaxValue;
            }

            int[] A = new int[list.Count() + 1];

            for (int i = list.Count() - 1; i >= 0; i--)
            {
                for (int j = 0; j < list[i].Count(); j++)
                {
                    A[j] = Math.Min(A[j], A[j + 1]) + list[i][j];
                }
            }

            return A[0];
        }            
    }
}
