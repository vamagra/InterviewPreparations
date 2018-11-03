using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class PathInRatMaze
    {
        /// <summary>
        /// We have discussed Backtracking and Knight’s tour problem in Set 1. Let us discuss Rat in a Maze as another example problem that can be solved using Backtracking.
        //  A Maze is given as N* N binary matrix of blocks where source block is the upper left most block i.e., maze[0][0] and 
        //  destination block is lower rightmost block i.e., maze[N - 1][N - 1]. A rat starts from source and has to reach the 
        //  destination.
        //  The rat can move only in two directions: forward and down.
        //  In the maze matrix, 0 means the block is a dead end and 1 means the block can be used in the path from source to destination. 
        //  Note that this is a simple version of the typical Maze problem. For example, a more complex version can be that the rat can move in 
        //  4 directions and a more complex version can be with a limited number of moves.
        //  Following is an example maze.
        //  Gray blocks are dead ends (value = 0). 
        //  Following is binary matrix representation of the above maze.
        //                {1, 0, 0, 0}
        //                {1, 1, 0, 1}
        //                {0, 1, 0, 0}
        //                {1, 1, 1, 1}
        //  Following is a maze with highlighted solution path.
        //  Following is the solution matrix (output of program) for the above input matrx.
        //                {1, 0, 0, 0}
        //                {1, 1, 0, 0}
        //                {0, 1, 0, 0}
        //                {0, 1, 1, 1}
        //  All enteries in solution path are marked as 1.
        //  </summary>
        //  <param name="maze"></param>
        //  <returns></returns>
        public static bool IsPathInMaze(int[,] maze)
        {
            if (maze == null || maze.Length < 1)
            {
                return false;
            }

            int rows = maze.GetLength(0);
            int columns = maze.GetLength(1);

            int[,] solu = new int[rows, columns];

            return SolveMazePathProblem(maze, solu, 0, 0);
        }

        private static bool SolveMazePathProblem(int[,] maze, int[,] solu, int x, int y)
        {
            // this is condition where we found the path
            if (x == maze.GetLength(0) - 1 && y == maze.GetLength(1) - 1)
            {
                solu[x, y] = 1;
                return true;
            }

            if (x < 0 && x > maze.GetLength(0) && y < 0 && y > maze.GetLength(1) && maze[x, y] != 1 && solu[x, y] == 1)
            {
                return false;
            }

            solu[x, y] = 1;

            bool exists = SolveMazePathProblem(maze, solu, x + 1, y)
                         || SolveMazePathProblem(maze, solu, x, y + 1);

            solu[x, y] = 0;
            return exists;

            //// check if we can move forward / down or not
            //if (isSafeToMoveForward(maze, x, y))
            //{
            //    solu[x, y] = 1;

            //    // Check to move right
            //    if (SolveMazePathProblem(maze, solu, x + 1, y))
            //    {
            //        return true;
            //    }
            //    // Check to move down
            //    else if (SolveMazePathProblem(maze, solu, x, y + 1))
            //    {
            //        return true;
            //    }

            //    solu[x, y] = 0;
            //    return false;
            //}

            //return false;
        }

        // Method safe to check if we can move forward Right / Down in maze 
        private static bool isSafeToMoveForward(int[,] maze, int x, int y)
        {
            if (x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == 1)
            {
                return true;
            }

            return false;
        }
    }
}
