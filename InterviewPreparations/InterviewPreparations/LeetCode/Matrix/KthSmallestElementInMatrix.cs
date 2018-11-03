using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterviewPreparations.LeetCode
{
    class KthSmallestElementInMatrix
    {
        /// <summary>
        /// Given a n x n matrix where each of the rows and columns are sorted in ascending order, find the kth smallest element in the matrix.
        //  Note that it is the kth smallest element in the sorted order, not the kth distinct element.
        //  Example:
        //  matrix = [
        //       [ 1,  5,  9],
        //       [10, 11, 13],
        //       [12, 13, 15]
        //      ],
        //  k = 8,
        //  return 13.
        //  </summary>
        //  <param name="matrix"></param>
        //  <returns></returns>
        public static int KthSmallestElementMatrix (int[,] matrix, int k)
        {
            if (matrix == null)
            {
                return -1;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int low = matrix[0, 0]; // get the min element from the matrix
            int high = matrix[rows - 1, columns - 1]; // get the max element from the matrix

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int count = getLessEqual(matrix, mid, rows, columns);

                if (count < k)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
        }

        private static int getLessEqual(int[,] matrix, int val, int rows, int columns)
        {
            int res = 0;

            int i = rows - 1;
            int j = 0;

            while (i >= 0 && j < columns - 1)
            {
                if (matrix[i, j] > val)
                {
                    i--;
                }
                else
                {
                    res += i + 1;
                    j++;
                }
            }

            return res;
        }
    }
}
