using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class UniquePaths
    {
        /// <summary>
        //  A robot is located at the top-left corner of amxngrid (marked 'Start' in the diagram below).
        //  The robot can only move either down or right at any point in time.The robot is trying to reach the bottom-right corner of the grid(marked 'Finish' in the diagram below).
        //  How many possible unique paths are there?
        //  Above is a 7 x 3 grid.How many possible unique paths are there?
        //  Note: m and n will be at most 100.
        //  Example 1:
        //  Input: m = 3, n = 2
        //  Output: 3
        //  Explanation:
        //  From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
        //  1. Right -> Right -> Down
        //  2. Right -> Down -> Right
        //  3. Down -> Right -> Right
        //  Example 2:
        //  Input: m = 7, n = 3
        //  Output: 28
        //  </summary>
        //  <param name="m"></param>
        //  <param name="n"></param>
        //  <returns></returns>
        public static int GetUniquePathInMatrix(int m, int n)
        {
            // To understand the problem solution, look here for pictorial reqpresentation 
            // https://leetcode.com/problems/unique-paths/discuss/22953/Java-DP-solution-with-complexity-O(n*m)

            int[,] matrix = new int[m, n];

            // Set 1 to first row and column as there can be only 1 path in the row or column
            // When(n == 0 || m == 0) the function always returns 1 since the robot
            // can't go left or up.
            for (int i = 0; i < m; i++)
            {
                matrix[0, i] = 1;
            }

            for (int j = 0; j < n; j++)
            {
                matrix[j, 0] = 1;
            }


            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    // take the sum of Top and Left column sum For all other cells. The result = uniquePaths(m-1,n)+uniquePaths(m,n-1)
                    // Therefore I populated the edges with 1 first and use DP to get the full 2 - D array.

                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }

            return matrix[m - 1, n - 1];
        }

    }
}
