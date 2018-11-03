using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Island_Problems
{
    class NoOfIIslandsClass
    {
        /// <summary>
        /// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
        //  Example 1:
        //  11110
        //  11010
        //  11000
        //  00000
        //  Answer: 1
        //  Example 2:
        //  11000
        //  11000
        //  00100
        //  00011
        //  Answer: 3
        //  </summary>
        //  <param name="matrix"></param>
        //  <returns></returns>
        public static int NumIslands(char[,] matrix)
        {
            if (matrix == null)
            {
                return -1;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == '1')
                    {
                        MarkIsland(i, j, rows, columns, matrix);
                        count++;
                    }
                }
            }

            return count;
        }

        public static void MarkIsland(int i, int j, int rows, int columns, char[,] matrix)
        {
            if (i < 0 || i >= rows || j < 0 || j >= columns || matrix[i, j] != '1')
            {
                return;
            }

            matrix[i, j] = '0';

            MarkIsland(i - 1, j, rows, columns, matrix);
            MarkIsland(i + 1, j, rows, columns, matrix);
            MarkIsland(i, j - 1, rows, columns, matrix);
            MarkIsland(i, j + 1, rows, columns, matrix);
        }
    }
}
