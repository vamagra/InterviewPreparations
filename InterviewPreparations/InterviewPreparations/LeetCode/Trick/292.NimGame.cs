using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.Trick
{
    class NimGame
    {
        public static bool CanWinNimGame(int n)
        {
            return !(n % 4 == 0);
        }
    }
}
