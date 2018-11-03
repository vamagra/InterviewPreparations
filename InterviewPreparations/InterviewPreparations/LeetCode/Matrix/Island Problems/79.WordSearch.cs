using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    //  Given a 2D board and a word, find if the word exists in the grid.
    //  The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are 
    //  those horizontally or vertically neighboring.The same letter cell may not be used more than once.
    //   For example,
    //   Given board =
    // [
    //  ['A','B','C','E'],
    //  ['S','F','C','S'],
    //  ['A','D','E','E']
    // ]
    // word = "ABCCED", -> returns true,
    // word = "SEE", -> returns true,
    // word = "ABCB", -> returns false.
    // </summary>
    class WordSearch
    {
        public static bool IsWordSearch2D(char[,] board, string word)
        {
            if (board == null || board.Length < 1 || string.IsNullOrEmpty(word))
            {
                return false;
            }

            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            bool[,] visited = new bool[rows + 1, columns + 1];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (searchHelper(board, visited, word, row, column, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool searchHelper(char[,] board, bool[,] visited, string word, int row, int column, int counter)
        {
            // if counter is eual to word length, then return true
            if (counter == word.Length)
            {
                return true;
            }

            // if row is out of each, column is out of reach, row is reach to last row, column is reach to last column           
            if (row < 0 || column < 0 || row >= board.GetLength(0) || column >= board.GetLength(1) || board[row, column] != word[counter] || visited[row, column])
            {
                return false;
            }

            // set the current char #
            visited[row, column] = true;

            bool exist = searchHelper(board, visited, word, row, column + 1, counter + 1)
                         || searchHelper(board, visited, word, row, column - 1, counter + 1)
                         || searchHelper(board, visited, word, row + 1, column, counter + 1)
                         || searchHelper(board, visited, word, row - 1, column, counter + 1);

            visited[row, column] = false;
            return exist;
        }
    }
}
