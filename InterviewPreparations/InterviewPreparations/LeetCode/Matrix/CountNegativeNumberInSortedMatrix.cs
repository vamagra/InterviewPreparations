using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class CountNegativeNumberInSortedMatrix
    {
        /// <summary>
        /// Count Negative Numbers in a Column-Wise and Row-Wise Sorted Matrix
        //  Find the number of negative numbers in a column-wise / row-wise sorted matrix M[][]. Suppose M has n rows and m columns.
        //  Example:
        //  Input:  M =  [-3, -2, -1, 1]
        //  [-2, 2, 3, 4]
        //  [4, 5, 7, 8]
        //  Output : 4
        //  We have 4 negative numbers in this matrix
        //  </summary>
        //  <param name="matrix"></param>
        //  <returns></returns>
        public static int CountNegative(int[,] matrix)
        {
            if (matrix == null)
            {
                return -1;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int row = 0;
            int column = columns - 1;

            int count = 0;

            while (row < rows && column >= 0)
            {
                if (matrix[row, column] < 0)
                {
                    count += column + 1;
                    row++;
                }
                else
                {
                    column--;
                }
            }

            return count;
        }
    }
}
