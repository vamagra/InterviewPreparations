using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Island_Problems
{
    class MaximalSquares
    {
        /// <summary>
        /// Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.
        //  For example, given the following matrix:
        //  1 0 1 0 0
        //  1 0 1 1 1
        //  1 1 1 1 1
        //  1 0 0 1 0
        //  Return 4.
        //  </summary>
        //  <param name="a"></param>
        //  <returns></returns>
        public static int MaximalSquare(char[,] a)
        {
            if (a == null || a.GetLength(0) == 0 || a.GetLength(1) == 0)
                return 0;

            int max = 0, n = a.GetLength(0), m = a.GetLength(1);

            // dp(i, j) represents the length of the square 
            // whose lower-right corner is located at (i, j)
            // dp(i, j) = min{ dp(i-1, j-1), dp(i-1, j), dp(i, j-1) + 1 }

            int[,] dp = new int[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (a[i - 1, j - 1] == '1')
                    {
                        dp[i, j] = Math.Min((dp[i - 1, j - 1]), Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                        max = Math.Max(max, dp[i, j]);
                    }
                }
            }

            // return the area
            return max * max;
        }
    }
}
