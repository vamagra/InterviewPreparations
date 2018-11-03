using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SearchA2DMatrix
    {
        /// <summary>
        /// Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        //  Integers in each row are sorted from left to right.
        //  The first integer of each row is greater than the last integer of the previous row.
        //  For example,
        //  Consider the following matrix:
        //  [
        //  [1,   3,  5,  7],
        //  [10, 11, 16, 20],
        //  [23, 30, 34, 50]
        //  ]
        //  Given target = 3, return true.
        // </summary>
        // <param name="matrix"></param>
        // <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int rowCounter = 0;
            int columnCounter = columns - 1;

            while (rowCounter < rows && columnCounter >= 0)
            {
                if (matrix[rowCounter, columnCounter] == target)
                {
                    return true;
                }

                if (matrix[rowCounter, columnCounter] > target)
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
