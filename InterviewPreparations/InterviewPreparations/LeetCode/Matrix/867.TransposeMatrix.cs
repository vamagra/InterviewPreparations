using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class TransposeMatrix
    {
        /// <summary>
        /// Given a matrix A, return the transpose of A.
        //  The transpose of a matrix is the matrix flipped over it's main diagonal, 
        //  switching the row and column indices of the matrix.
        //  Example 1:
        //  Input: [[1,2,3],
        //          [4,5,6],
        //          [7,8,9]]
        //  Output: [[1,4,7],[2,5,8],[3,6,9]]
        //  Example 2:
        //  Input: [[1,2,3],[4,5,6]]
        //  Output: [[1,4],[2,5],[3,6]]
        //  Note:
        //  1 <= A.length <= 1000
        //  1 <= A[0].length <= 1000
        //  </summary>
        //  <param name="matrix"></param>
        public static int[][] TransposeMatrixClassMethod(int[][] matrix)
        {
            if (matrix == null || matrix.Length < 1)
            {
                return matrix;
            }

            // As we need to transpose so, input matrix columns will become rows in result matrix
            // that is why we have assign the column length to resulting matrix total length
            int[][] result = new int[matrix[0].Length][];

            // run the loop on number of rows of input matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                // run the loop on every row number of columns
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    // we need to initialize the every array in matrix
                    if (i == 0)
                    {
                        // here matrix length will become column length in transpose matrix
                        result[j] = new int[matrix.Length];
                    }

                    result[j][i] = matrix[i][j];
                }
            }

            return result;
        }
    }
}
