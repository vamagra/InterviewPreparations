using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FlipGame
    {
        /// <summary>
        // You are playing the following Flip Game with your friend: Given a string that contains only these two characters: + and -, you and your friend take turns 
        // to flip two consecutive "++" into "--". The game ends when a person can no longer make a move and therefore the other person will be the winner.
        // Write a function to compute all possible states of the string after one valid move.
        // </summary>
        // <param name="s"></param>
        // <returns></returns>
        public static IList<string> GetFlipGameCombinations(string s)
        {
            IList<string> result = new List<string>();

            if (s.Length < 1)
            {
                return result;
            }

            char[] chArr = s.ToCharArray();

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (chArr[i] == chArr[i + 1] && chArr[i] == '+')
                {
                    chArr[i] = '-';
                    chArr[i + 1] = '-';

                    result.Add(new string(chArr));

                    chArr[i] = '+';
                    chArr[i + 1] = '+';
                }
            }

            return result;
        }

    }
}
