using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PascalsTriangle
    {
        /// <summary>
        /// Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
        //  In Pascal's triangle, each number is the sum of the two numbers directly above it.
        //  Example:
        //  Input: 5
        //  Output:
        //  [
        //      [1],
        //     [1,1],
        //    [1,2,1],
        //   [1,3,3,1],
        //  [1,4,6,4,1]
        // ]
        //  </summary>
        // <param name="rows"></param>
        // <returns></returns>
        public static IList<IList<int>> GeneratePascalTriangleRows(int rows)
        {
            IList<IList<int>> allRows = new List<IList<int>>();

            if (rows <= 0)
            {
                return null;
            }

            for (int i = 0; i < rows; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    // if j is first element or last element add 1
                    if (j == 0 || i == j)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        // Add last row left and right element, means curr element top two elements
                        //  for second row which is 1 - [0,0] + [0,1]
                        row.Add(allRows[i - 1][j - 1] + allRows[i - 1][j]);
                    }
                }

                allRows.Add(row);
            }

            return allRows;
        } 
    }
}
