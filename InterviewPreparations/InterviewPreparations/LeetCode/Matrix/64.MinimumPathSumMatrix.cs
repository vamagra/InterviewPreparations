using InterviewQuestions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MinimumPathSumMatrix
    {
        /// <summary>
        /// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the
        //  sum of all numbers along its path.
        //  Note: You can only move either down or right at any point in time.
        //  Example 1:
        // [[1, 3, 1], 
        //  [1, 5, 1],  
        //  [4, 2, 1]]
        //  Given the above grid map, return 7. Because the path 1→3→1→1→1 minimizes the sum.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int MinPathSumMatrix(int[,] matrix)
        {
            if (matrix.Length == 0)
            {
                return 0;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Solution - update the first row every element and first column every element with 
            // previous element + curr element. when you have previous left and top element, get 
            // the min of those two element and update the current element with addinig minimum of 
            // those two elements, last element of array will have min sum

            //UtilityHelper.PrintMatrix(nums, rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // when we are checking the first row, and going from L -> R get the sum of previous
                    // left element
                    if (i == 0 && j != 0)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[i, j - 1];
                    }
                    // when we are on the first column and going from T -> D get the sum of previous
                    // top element
                    else if (i != 0 && j == 0)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[i - 1, j];
                    }
                    // first element don't do anything
                    else if (i == 0 && j == 0)
                    {
                        matrix[i, j] = matrix[i, j];
                    }
                    // get the min element from left element and top element and sum with curr element
                    else
                    {
                        matrix[i, j] = Math.Min(matrix[i - 1, j], matrix[i, j - 1]) + matrix[i, j];
                    }

                    Console.WriteLine(matrix[i, j]);
                }

                //UtilityHelper.PrintMatrix(nums, rows, columns);
            }

            return matrix[rows - 1, columns - 1];
        }
    }
}
