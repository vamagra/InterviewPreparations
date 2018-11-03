using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PrintMatrixDiaognalOrder
    {
        /// <summary>
        /// Given a matrix of M x N elements (M rows, N columns), return all elements of the matrix in diagonal order as shown in the below image.
        //  Example:
        //  Input:
        //  [
        //     [ 1, 2, 3 ],
        //     [ 4, 5, 6 ],
        //     [ 7, 8, 9 ]
        //  ]
        //  Output:  [1,2,4,7,5,3,6,8,9]
        //  Explanation:
        //  Note:
        //  The total number of elements of the given matrix will not exceed 10,000.
        //  </summary>
        //  <param name="matrix"></param>
        public static int[] PrintDiaognal(int[,] matrix)
        {
            if (matrix.Length == 0)
            {
                return null;
            }

            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            int[] result = new int[rowCount * columnCount];

            int r = 0;
            int c = 0;

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matrix[r, c];

                // if even then go up
                if (r + c % 2 == 0)
                {
                    // As columns are getting increased, there might be chance when we reached last column
                    if (c == columnCount - 1)
                    {
                        // move to next row
                        r++;
                    }
                    // As row are getting decaresed, there might be chance we reached to first row
                    else if (r == 0)
                    {
                        // move to next column
                        c++;
                    }
                    else
                    {
                        r--;
                        c++;
                    }
                }
                // else need to go down
                else
                {
                    if (r == rowCount - 1)
                    {
                        c++;
                    }
                    else if (c == 0)
                    {
                        r++;
                    }
                    else
                    {
                        r++;
                        c--;
                    }
                }
            }

            return result;
        }

    }
}
