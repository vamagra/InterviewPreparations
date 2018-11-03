using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class UniquePathsII
    {
        /// <summary>
        // A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
        // The robot can only move either down or right at any point in time.The robot is trying to reach the bottom-right corner of the grid(marked 'Finish' in the diagram below).
        // Now consider if some obstacles are added to the grids. How many unique paths would there be?
        // </summary>
        // <param name="matrix"></param>
        // <returns></returns>
        public static int GetUniquePathsInMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.Length < 1)
            {
                return -1;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] dp = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 0] == 1)
                {
                    break;
                }

                dp[i, 0] = 1;
            }

            for (int j = 0; j < columns; j++)
            {
                if (matrix[0, j] == 1)
                {
                    break;
                }

                dp[0, j] = 1;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        continue;
                    }

                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[rows - 1, columns - 1];
        }
    }
}
