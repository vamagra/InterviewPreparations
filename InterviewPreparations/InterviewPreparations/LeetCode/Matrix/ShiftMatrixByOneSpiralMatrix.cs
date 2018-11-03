using InterviewQuestions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ShiftMatrixByOneSpiralMatrix
    {
        /// <summary>
        /// Shift elements by one
        /// </summary>
        /// <param name="n"></param>
        public static void ShiftMatrix(int[,] matrix)
        {
            int top = 0, bottom = matrix.GetLength(0) - 1;
            int left = 0, right = matrix.GetLength(1) - 1;
            int prev = matrix[0, 0];
            UtilityHelper.PrintMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1));

            while (true)
            {
                if (left > right)
                    break;

                // change top row
                for (int i = left; i <= right; i++)
                {
                    // swap(matrix[top, i], prev);
                    prev = matrix[top, i];
                    matrix[top, i] = prev;
                    prev = matrix[top, i];
                }
                    
                top++;

                if (top > bottom)
                    break;

                // change right column
                for (int i = top; i <= bottom; i++)
                {
                    // swap(matrix[i, right], prev);
                    prev = matrix[i, right];
                    matrix[i, right] = prev;
                    prev = matrix[i, right];
                }
                right--;

                if (left > right)
                    break;

                // change bottom row
                for (int i = right; i >= left; i--)
                {
                    // swap(matrix[bottom, i], prev);
                    prev = matrix[bottom, i];
                    matrix[bottom, i] = prev;
                    prev = matrix[bottom, i];
                }
                    

                bottom--;

                if (top > bottom)
                    break;

                // change left column
                for (int i = bottom; i >= top; i--)
                {
                    // swap(matrix[i, left], prev);
                    // swap(matrix[bottom, i], prev);

                    prev = matrix[i, left];
                    matrix[i, left] = prev;
                    prev = matrix[i, left];
                }
                    
                left++;
            }

            // first element of the matrix will be the last element replaced
            matrix[0, 0] = prev;

            UtilityHelper.PrintMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1));
            Console.Read();
        }

        private static void swap(int element, int prev)
        {
            int temp = element;
            element = prev;
            prev = element;
        }
    }
}
