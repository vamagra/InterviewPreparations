using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SetMatrixZeroesClass
    {
        /// <summary>
        /// Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in place.
        /// </summary>
        /// <param name="matrix"></param>
        public static void SetMatrix(int[,] matrix)
        {
            //Use the first column and the first row as marker:

            // first scan through the whole matrix, and if one row i has zero, label matrix[i][0] = 0, if column j has zero, then label matrix[0][j] = 0.

            // if we find the first row has zero, then mark a boolean row = true, if the first column has zeros, mark a boolean col = true;

            // By the markers on the first row and first col, set the other columns and rows to zeros. (first row and first column already contain zeros)

            //According to booleans row and col, decide whether to set first row and column to zeros.

            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return;
            }

            bool frFlag = false;
            bool fcFlag = false;

            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            ////Print Input Matrix Array

            // Print(matrix, row, column);

            // Step1 - if we find zero anywhere in the matrix, make first row and first column zero
            // set the flag for Row 0 and Column 0

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        //set the row flag
                        if (i == 0)
                        {
                            frFlag = true;
                        }

                        //set the row flag
                        if (j == 0)
                        {
                            fcFlag = true;
                        }

                        matrix[0, j] = 0;
                        matrix[i, 0] = 0;
                    }
                }
            }

            Console.WriteLine("---------------------After Step1------------------");

            // Print(matrix, row, column);


            // Loop through the matrix from Row 1 to N Row on Column 0, 
            // check if any of the row is 0 then make all the columns 0 for that row.
            for (int i = 1; i < row; i++)
            {
                if (matrix[i, 0] == 0)
                {
                    for (int j = 1; j < column; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }


            Console.WriteLine("---------------------After Step2------------------");

            // Print(matrix, row, column);


            //Loop through all the columns from 1 to N column Row 0, check if any of the column is 0 then make all the rows 0 for that column
            for (int j = 1; j < column; j++)
            {
                if (matrix[0, j] == 0)
                {
                    for (int i = 1; i < row; i++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("---------------------After Step2------------------");

            // Print(matrix, row, column);

            // make first column 0 if Row flag is true
            // set all the column 0
            if (frFlag)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[0, j] = 0;
                }
            }

            Console.WriteLine("---------------------After Frflag------------------");

            // Print(matrix, row, column);

            //make first row 0 if column flag is true
            //set all the row 0
            if (fcFlag)
            {
                for (int i = 0; i < row; i++)
                {
                    matrix[i, 0] = 0;
                }
            }

            //Console.WriteLine("---------------------After Columnflag------------------");

            // Print(matrix, row, column);
        }
        public static void Print(int[,] matrix, int rowLength, int colLength)
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.ReadLine();
        }
    }
}
