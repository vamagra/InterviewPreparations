using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class Pascal_TriangleII
    {
        /// <summary>
        /// Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.
        //  Note that the row index starts from 0.
        //  In Pascal's triangle, each number is the sum of the two numbers directly above it.
        //  Example:
        //  Input: 3
        //  Output: [1,3,3,1]
        //  Follow up:
        //  Could you optimize your algorithm to use only O(k) extra space?
        //  </summary>
        //  <param name="rowNumber"></param>
        //  <returns></returns>
        public static IList<int> GetPascalTraiangleRow(int rowNumber)
        {
            int[] rowsAray = new int[rowNumber + 1];

            if (rowNumber <= 0)
            {
                List<int> result = new List<int>();
                result.Add(1);
                return result;
            }

            for (int i = 0; i <= rowNumber; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if(j == 0 || i == j)
                    {
                        rowsAray[j] = 1;
                    }
                    else
                    {
                        rowsAray[j] =  rowsAray[j] + rowsAray[j - 1];
                    }
                }
            }

            return rowsAray.ToList();
        }
    }
}
