using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FlipGameII
    {
        /// <summary>
        // You are playing the following Flip Game with your friend: Given a string that contains only these two characters: + and -, 
        // you and your friend take turns to flip two consecutive "++" into "--". The game ends when a person can no longer make a move and therefore the other person will be the winner.
        // Write a function to determine if the starting player can guarantee a win.
        // For example, given s = "++++", return true. The starting player can guarantee a win by flipping the middle "++" to become "+--+".
        // </summary>
        // <param name="s"></param>
        // <returns></returns>
        public static bool FlipGameWinFirstPlayer(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            char[] charArr = s.ToCharArray();

            return canWinHelper(charArr);
        }

        public static bool canWinHelper(char[] charArr)
        {
            for (int i = 0; i < charArr.Length - 1; i++)
            {
                if (charArr[i] == charArr[i + 1] && charArr[i] == '+')
                {
                    charArr[i] = '-';
                    charArr[i + 1] = '-';

                    bool win = canWinHelper(charArr);

                    charArr[i] = '+';
                    charArr[i + 1] = '+';

                    if (!win)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
