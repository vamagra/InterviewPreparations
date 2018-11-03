using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SpiralMatrixII
    {
        /// <summary>
        //  Given a positive integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
        //  Example:
        //  Input: 3
        //  Output:
        //  [
        //   [ 1, 2, 3 ],
        //   [ 8, 9, 4 ],
        //   [ 7, 6, 5 ]
        //  ]
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static int[,] GenerateSpiralMatrixFromN(int n)
        {
            int[,] matrix = new int[n, n];
            if (n < 1)
            {
                return matrix;
            }

            int rowBegin = 0;
            int rowEnd = n - 1;

            int columnBegin = 0;
            int columnEnd = n - 1;

            int num = 1;

            while (rowBegin <= rowEnd && columnBegin <= columnEnd)
            {
                // Traverse Left To Right
                for (int column = columnBegin; column <= columnEnd; column++)
                {
                    matrix[rowBegin, column] = num;
                    num++;
                }

                rowBegin++;

                // Traverse Top To Down
                for (int row = rowBegin; row <= rowEnd; row++)
                {
                    matrix[row, columnEnd] = num;
                    num++;
                }
                columnEnd--;

                if (rowBegin <= rowEnd)
                {
                    // Traverse Right to left
                    for (int column = columnEnd; column >= columnBegin; column--)
                    {
                        matrix[rowEnd, column] = num;
                        num++;
                    }
                }
                rowEnd--;

                if (columnBegin <= columnEnd)
                {
                    // Traverse Down to Top
                    for (int row = rowEnd; row >= rowBegin; row--)
                    {
                        matrix[row, columnBegin] = num;
                        num++;
                    }
                }
                columnBegin++;
            }

            return matrix;
        }
    }
}
