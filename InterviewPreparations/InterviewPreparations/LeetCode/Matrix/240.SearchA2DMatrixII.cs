using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SearchA2DMatrixII
    {
        /// <summary>
        /// Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        //  Integers in each row are sorted in ascending from left to right.
        //  Integers in each column are sorted in ascending from top to bottom.
        //  For example,
        //  Consider the following matrix:
        //  [
        //      [1,   4,  7, 11, 15],
        //      [2,   5,  8, 12, 19],
        //      [3,   6,  9, 16, 22],
        //      [10, 13, 14, 17, 24],
        //      [18, 21, 23, 26, 30]
        //  ]
        //  Given target = 5, return true.
        //  Given target = 20, return false.
        //  </summary>
        //  <param name="matrix"></param>
        //  <param name="target"></param>
        //  <returns></returns>
        public static bool SearchIn2DMatrix(int[,] matrix, int target)
        {
            if (matrix == null)
            {
                return false;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows < 1 || columns < 1)
            {
                return false;
            }

            int rowCounter = 0;
            int columnCounter = columns - 1;
            
            while (rowCounter < rows && columnCounter >= 0)
            {
                if (matrix[rowCounter, columnCounter] == target)
                {
                    return true;
                }
                else if (matrix[rowCounter, columnCounter] > target)
                {
                    columnCounter--;
                }
                else
                {
                    rowCounter++;
                }
            }

            return false;
        }
    }
}
