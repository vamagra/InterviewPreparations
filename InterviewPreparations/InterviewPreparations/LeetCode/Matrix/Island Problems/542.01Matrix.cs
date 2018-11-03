using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class _01Matrix
    {
        /// <summary>
        //  Given a matrix consists of 0 and 1, find the distance of the nearest 0 for each cell.
        //  The distance between two adjacent cells is 1.
        //  Example 1: 
        //  Input:
        //  0 0 0
        //  0 1 0
        //  0 0 0
        //  Output:
        //  0 0 0
        //  0 1 0
        //  0 0 0
        //  Example 2: 
        //  Input:
        //  0 0 0
        //  0 1 0
        //  1 1 1
        //  Output:
        //  0 0 0
        //  0 1 0
        //  1 2 1
        //  Note:
        //  The number of elements of the given matrix will not exceed 10,000.
        //  There are at least one 0 in the given matrix.
        //  The cells are adjacent in only four directions: up, down, left and right.
        //  </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] GetDistance(int[,] matrix)
        {
            if (matrix == null || matrix.Length < 1)
            {
                return matrix;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Assigned a large value to all the positions with value 1 and don't have 0 neighbors
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 1 && !NearZero(i, j, matrix))
                    {
                        matrix[i, j] = rows + columns + 1;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        DFSMethod(i, j, matrix, 1);
                    }
                }
            }

            return matrix;
        }

        private static void DFSMethod(int x, int y, int[,] matrix, int val)
        {
            if (x < 0 || y < 0 || x >= matrix.GetLength(0) || y >= matrix.GetLength(1) || (matrix[x, y] <= val && val != 1))
            {
                return;
            }

            matrix[x, y] = val;

            DFSMethod(x - 1, y, matrix, matrix[x, y] + 1);
            DFSMethod(x + 1, y, matrix, matrix[x, y] + 1);
            DFSMethod(x, y - 1, matrix, matrix[x, y] + 1);
            DFSMethod(x, y + 1, matrix, matrix[x, y] + 1);
        }

        private static bool NearZero(int x, int y, int[,] matrix)
        {
            //check for left position
            if (x > 0 && matrix[x - 1, y] == 0)
            {
                return true;
            }

            //check for right position
            if (x < matrix.GetLength(0) - 1 && matrix[x + 1, y] == 0)
            {
                return true;
            }

            //check for top position
            if (y > 0 && matrix[x, y - 1] == 0)
            {
                return true;
            }

            //check for bottom position
            if (y < matrix.GetLength(1) - 1 && matrix[x, y + 1] == 0)
            {
                return true;
            }

            return false;
        }
    }
}