using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    /// Design a Tic-tac-toe game that is played between two players on a n x n grid.
    //  You may assume the following rules:
    //  A move is guaranteed to be valid and is placed on an empty block.
    //  Once a winning condition is reached, no more moves is allowed.
    //  A player who succeeds in placing n of their marks in a horizontal, vertical, or diagonal row wins the game.
    //  Example:
    //  Given n = 3, assume that player 1 is "X" and player 2 is "O" in the board.
    //  TicTacToe toe = new TicTacToe(3);
    //    toe.move(0, 0, 1); -> Returns 0 (no one wins)
    //  |X| | |
    //  | | | |    // Player 1 makes a move at (0, 0).
    //  | | | |

    //  toe.move(0, 2, 2); -> Returns 0 (no one wins)
    //  |X| |O|
    //  | | | |    // Player 2 makes a move at (0, 2).
    //  | | | |

    //  toe.move(2, 2, 1); -> Returns 0 (no one wins)
    //  |X| |O|
    //  | | | |    // Player 1 makes a move at (2, 2).
    //  | | |X|

    //  toe.move(1, 1, 2); -> Returns 0 (no one wins)
    //  |X| |O|
    //  | |O| |    // Player 2 makes a move at (1, 1).
    //  | | |X|

    //  toe.move(2, 0, 1); -> Returns 0 (no one wins)
    //  |X| |O|
    //  | |O| |    // Player 1 makes a move at (2, 0).
    //  |X| |X|

    //  toe.move(1, 0, 2); -> Returns 0 (no one wins)
    //  |X| |O|
    //  |O|O| |    // Player 2 makes a move at (1, 0).
    //  |X| |X|

    //  toe.move(2, 1, 1); -> Returns 1 (player 1 wins)
    //  |X| |O|
    //  |O|O| |    // Player 1 makes a move at (2, 1).
    //  |X|X|X|
    //  Follow up: Could you do better than O(n2) per move() operation?
    //  Hint:
    //  Could you trade extra space such that move() operation can be done in O(1)? You need two arrays: int rows[n], int cols[n], plus two variables: diagonal, anti_diagonal.
    //  </summary>
    public class DesignTicTacToeNaiveSolution
    {
        int[,] matrix;

        public DesignTicTacToeNaiveSolution(int n)
        {
            matrix = new int[n, n];
        }

        // Naive Solution
        public int Move(int row, int column, int player)
        {
            matrix[row, column] = player;

            bool win = true;

            // check for row
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[row, i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            // check for column
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, column] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            // check for front diaognal
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            // check for back diaognal
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, matrix.GetLength(0) - i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            return 0;
        }
    }

    public class DesignTicTacToe
    {
        int[] rows;
        int[] columns;

        int diaognal;
        int antiDiaognal;

        DesignTicTacToe(int n)
        {
            rows = new int[n];
            columns = new int[n]; 
        }

        public int Move(int row, int column, int player)
        {
            int val = (player == 1) ? 1 : -1;

            // keep adding the values from player 1 and player2 in rows and columns like for 

            // player 1 rows[0] for [1,1,1] => [3] player1 win
            // player 2 rows[0] for [-1,-1,-1] => [-3] player 2 win

            rows[row] += val;
            columns[column] += val;

            // like 0,0 => 1,1 => 2,2 diaognal from top left to bottom right
            if (row == column)
            {
                diaognal += val;
            }

            // like 0,2,=> 1,1=> 2,0
            if (column == rows.Length - row - 1)
            {
                antiDiaognal += val;
            }

            int size = rows.Length;

            if (Math.Abs(rows[row]) == size ||
                Math.Abs(columns[column]) == size ||
                    Math.Abs(diaognal) == size ||
                        Math.Abs(antiDiaognal) == size)
            {
                return player;
            }

            return 0;
        }
    }
}
