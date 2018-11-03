using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SpiralMatrixcs
    {
        /// <summary>
        /// Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
        //  For example,
        //  Given the following matrix:
        // [
        //  [ 1, 2, 3 ],
        //  [ 4, 5, 6 ],
        //  [ 7, 8, 9 ]
        // ]
        // You should return [1,2,3,6,9,8,7,4,5].
        // </summary>
        // <param name="matrix"></param>
        /// <returns></returns>
        public static IList<int> SpiralMatrix(int[,] matrix)
        {
            IList<int> resultMatrix = new List<int>();

            //  This is a very simple and easy to understand solution.I traverse right and increment rowBegin, then traverse down and decrement colEnd, 
            //  then I traverse left and decrement rowEnd, and finally I traverse up and increment colBegin.
            //  The only tricky part is that when I traverse left or up I have to check whether the row or col 
            //  still exists to prevent duplicates. If anyone can do the same thing without that check, please let me know!

            if (matrix == null || matrix.Length == 0)
            {
                return resultMatrix;
            }

            int rowBegin = 0;
            int rowEnd = matrix.GetLength(0) - 1;

            int columnBegin = 0;
            int columnEnd = matrix.GetLength(1) - 1;

            while (rowBegin <= rowEnd && columnBegin <= columnEnd)
            {
                // Trverse Right
                for (int column = columnBegin; column <= columnEnd; column++)
                {
                    resultMatrix.Add(matrix[rowBegin, column]);
                }

                rowBegin++;

                // Traverse Down
                for (int row = rowBegin; row <= rowEnd; row++)
                {
                    resultMatrix.Add(matrix[row, columnEnd]);
                }

                columnEnd--;

                // TraverseLeft

                if (rowBegin <= rowEnd)
                {
                    for (int column = columnEnd; column >= columnBegin; column--)
                    {
                        resultMatrix.Add(matrix[rowEnd, column]);
                    }
                }
                rowEnd--;

                // TraverseUp

                if (columnBegin <= columnEnd)
                {
                    for (int row = rowEnd; row >= rowBegin; row--)
                    {
                        resultMatrix.Add(matrix[row, columnBegin]);
                    }
                }

                columnBegin++;
            }

            return resultMatrix;
        }
    }
}
