using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class PathInMazeAllDirection
    {
        /// <summary>
        /// There is a ball in a maze with empty spaces and walls. The ball can go through empty spaces by rolling up, down, left or right, but 
        /// it won't stop rolling until hitting a wall. When the ball stops, it could choose the next direction.
        //  Given the ball's start position, the destination and the maze, determine whether the ball could stop at the destination.
        //  The maze is represented by a binary 2D array. 1 means the wall and 0 means the empty space.You may assume that 
        //  the borders of the maze are all walls.The start and destination coordinates are represented by row and column indexes.

        //Example 1

        //Input 1: a maze represented by a 2D array

        //0 0 1 0 0
        //0 0 0 0 0
        //0 0 0 1 0
        //1 1 0 1 1
        //0 0 0 0 0

        //Input 2: start coordinate (rowStart, colStart) = (0, 4)
        //Input 3: destination coordinate(rowDest, colDest) = (4, 4)

        //Output: true
        //Explanation: One possible way is : left -> down -> left -> down -> right -> down -> right.

        //Example 2

        //Input 1: a maze represented by a 2D array

        //0 0 1 0 0
        //0 0 0 0 0
        //0 0 0 1 0
        //1 1 0 1 1
        //0 0 0 0 0

        //Input 2: start coordinate(rowStart, colStart) = (0, 4)
        //Input 3: destination coordinate(rowDest, colDest) = (3, 2)

        //Output: false
        //Explanation: There is no way for the ball to stop at the destination.

        //Note:
        //There is only one ball and one destination in the maze.
        //Both the ball and the destination exist on an empty space, and they will not be at the same position initially.
        //The given maze does not contain border (like the red rectangle in the example pictures), but you could assume the border of the maze are all walls.
        //The maze contains at least 2 empty spaces, and both the width and height of the maze won't exceed 100.
        //  </summary>
        //  <param name="maze"></param>
        //  <returns></returns>
        public static bool IsPathInMaze(int[,] maze)
        {
            if (maze == null || maze.Length < 1)
            {
                return false;
            }

            bool[,] visited = new bool[maze.GetLength(0), maze.GetLength(1)];

            return mazeTraverse(maze, visited, new coordinates(0, 4), new coordinates(4, 4));
        }

        public static bool mazeTraverse(int[,] maze, bool[,] visited, coordinates src, coordinates dest)
        {
            // Failed Conditions
            // when we reached to end of matrix and didn;t find the path
            if (src.row == maze.GetLength(0) || src.column == maze.GetLength(1) || src.row == -1 || src.column == -1)
            {
                return false;
            }

            // when src starts from wall
            if (maze[src.row, src.column] == 1)
            {
                return false;
            }

            // when we try to access the visited box again
            if (visited[src.row, src.column] == true)
            {
                return false;
            }

            // Passed condition when we found the path
            if (src.row == dest.row && src.column == dest.column)
            {
                return true;
            }


            visited[src.row, src.column] = true;

            return mazeTraverse(maze, visited, new coordinates(src.row + 1, src.column), dest)
                || mazeTraverse(maze, visited, new coordinates(src.row, src.column + 1), dest)
                || mazeTraverse(maze, visited, new coordinates(src.row - 1, src.column), dest)
                || mazeTraverse(maze, visited, new coordinates(src.row, src.column - 1), dest);
        }
    }

    public class coordinates
    {
        public int row;
        public int column;

        public coordinates(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
