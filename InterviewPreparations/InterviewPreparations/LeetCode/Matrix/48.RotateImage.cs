﻿using InterviewQuestions.Utility;
namespace InterviewQuestions.LeetCode
{
    class RotateImage
    {
        /// <summary>
        /// You are given an n x n 2D matrix representing an image.
        //  Rotate the image by 90 degrees(clockwise).
        //  Note:
        //  You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.DO NOT allocate another 2D matrix and do the rotation.
        //Example 1:
        //Given input matrix =
        //[
        //  [1,2,3],
        //  [4,5,6],
        //  [7,8,9]
        //],
        
        //rotate the input matrix in-place such that it becomes:
        //[
        //  [7,4,1],
        //  [8,5,2],
        //  [9,6,3]
        //]
        //Example 2:

        //Given input matrix =
        //[
        //  [ 5, 1, 9,11],
        //  [ 2, 4, 8,10],
        //  [13, 3, 6, 7],
        //  [15,14,12,16]
        //], 

        //rotate the input matrix in-place such that it becomes:
        //[
        //  [15,13, 2, 5],
        //  [14, 3, 4, 1],
        //  [12, 6, 8, 9],
        //  [16, 7,10,11]
        //]
        // </summary>
        public static void Rotate(int[,] matrix)
        {
            int rows = matrix.GetLength(1);
            int columns = matrix.GetLength(0);

            if (rows != columns)
            {
                return;
            }

            UtilityHelper.PrintMatrix(matrix, rows, columns);

            // Transpose Matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < columns; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            UtilityHelper.PrintMatrix(matrix, rows, columns);

            // reverse the first and last columns, left the middle one 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, columns - 1 - j];
                    matrix[i, columns - 1 - j] = temp;
                }
            }

            UtilityHelper.PrintMatrix(matrix, rows, columns);

            UtilityHelper.PrintMatrix(matrix, rows, columns);
        }
    }
}
