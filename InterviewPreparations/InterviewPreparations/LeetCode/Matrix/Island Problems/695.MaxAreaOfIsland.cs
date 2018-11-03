using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Island_Problems
{
    class MaxAreaOfIsland
    {
        /// <summary>
        //  Given a non-empty 2D array grid of 0's and 1's, an island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.
        //  Find the maximum area of an island in the given 2D array. (If there is no island, the maximum area is 0.)
        //  Example 1:
        //  [[0,0,1,0,0,0,0,1,0,0,0,0,0],
        //  [0,0,0,0,0,0,0,1,1,1,0,0,0],
        //  [0,1,1,0,1,0,0,0,0,0,0,0,0],
        //  [0,1,0,0,1,1,0,0,1,0,1,0,0],
        //  [0,1,0,0,1,1,0,0,1,1,1,0,0],
        //  [0,0,0,0,0,0,0,0,0,0,1,0,0],
        //  [0,0,0,0,0,0,0,1,1,1,0,0,0],
        //  [0,0,0,0,0,0,0,1,1,0,0,0,0]]
        //  Given the above grid, return 6. Note the answer is not 11, because the island must be connected 4-directionally.
        //  Example 2:
        //  [[0,0,0,0,0,0,0,0]]
        //  Given the above grid, return 0.
        //  Note: The length of each dimension in the given grid does not exceed 50.
        //  </summary>

        public static int currArea = 0;
        public static int TotalMaxAreaOfIsland(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int rows = grid.GetLength(0);
            if (rows <= 0)
            {
                return 0;
            }

            int columns = grid.GetLength(1);

            //int currArea = 0;
            int maxArea = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        MarkIsland(i, rows, j, columns, grid);
                        maxArea = currArea > maxArea ? currArea : maxArea;
                        currArea = 0;
                    }
                }
            }

            return maxArea;
        }

        public static void MarkIsland(int i, int x, int j, int y, int[,] grid)
        {
            if (i < 0 || i >= x || j < 0 || j >= y || grid[i, j] != 1)
            {
                return;
            }

            currArea++;

            grid[i, j] = 0;

            MarkIsland(i + 1, x, j, y, grid);
            MarkIsland(i - 1, x, j, y, grid);
            MarkIsland(i, x, j + 1, y, grid);
            MarkIsland(i, x, j - 1, y, grid);
        }
    }
}
