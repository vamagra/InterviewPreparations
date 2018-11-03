using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class IslandPerimeter
    {
        /// <summary>
        // You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water. 
        // Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and 
        // there is exactly one island (i.e., one or more connected land cells). The island doesn't have "lakes" (water inside 
        // that isn't connected to the water around the island). One cell is a square with side length 1. The grid is rectangular, 
        // width and height don't exceed 100. Determine the perimeter of the island.
        // Example:
        //  [[0,1,0,0],
        //  [1,1,1,0],
        //  [0,1,0,0],
        //  [1,1,0,0]]
        //  Answer: 16
        //  Explanation: The perimeter is the 16 yellow stripes in the image below:
        // </summary>
        public static int perimeter = 0;
        public static int IslandPerimeterClassMethod(int[,] grid)
        {
            if (grid == null)
            {
                return -1;
            }

            int rows = grid.GetLength(0);
            if (rows == 0)
            {
                return -1;
            }

            int columns = grid.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    GetPerimeter(i, j, rows, columns, grid);
                }
            }

            return perimeter;
        }

        public static void GetPerimeter(int i, int j, int rows, int columns, int[,] grid)
        {
            if (i < 0 || i >= rows || j < 0 || j >= columns || grid[i, j] != 1)
            {
                return;
            }

            // top
            if (i == 0 || (i > 0 && grid[i - 1, j] == 0))
            {
                perimeter++;
            }

            // bottom        
            if (i == rows - 1 || (i < rows - 1 && grid[i + 1, j] == 0))
            {
                perimeter++;
            }

            // left
            if (j == 0 || (j > 0 && grid[i, j - 1] == 0))
            {
                perimeter++;
            }


            // right        
            if (j == columns - 1 || (j < columns - 1 && grid[i, j + 1] == 0))
            {
                perimeter++;
            }
        }
    }
}
