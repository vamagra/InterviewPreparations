using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ValidWordSquareClass
    {
        /// <summary>
        //  Input:
        //        [
        //          "abcd",
        //          "bnrt",
        //          "crm",
        //          "dt"
        //  ]
        //  Output:
        //  true
        //  Explanation:
        //  The first row and first column both read "abcd".
        //  The second row and second column both read "bnrt".
        //  The third row and third column both read "crm".
        //  The fourth row and fourth column both read "dt".
        //  Therefore, it is a valid word square.
        //  </summary>
        //  <param name="charMatrix"></param>
        //  <returns></returns>
        public static bool IsValidWordSquare(List<string> words)
        {
            if (words.Count < 1)
            {
                return false;
            }

            // Loop over the word list
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    // loop is running row vs column every i loop run for row and every j loop run for column
                    if (j >= words.Count || i >= words[j].Length || words[i][j] != words[j][i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
