using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class RotateString
    {
        /// <summary>
        /// We are given two strings, A and B.
        //  A shift on A consists of taking string A and moving the leftmost character to the rightmost position.For example, if A = 'abcde', then it will be 'bcdea' after one shift on A.Return True if and only if A can become B after some number of shifts on A.
        //  Example 1:
        //  Input: A = 'abcde', B = 'cdeab'
        //  Output: true
        //  Example 2:
        //  Input: A = 'abcde', B = 'abced'
        //  Output: false
        //  </summary>
        //  <param name="A"></param>
        //  <param name="B"></param>
        //  <returns></returns>
        public static bool RotateStr(string A, string B)
        {
            if (A == null || B == null)
            {
                return true;
            }

            if(A.Length != B.Length)
            {
                return false;
            }

            string bigA = A + A;

            int j = 0;
            for (int i = 0; i < bigA.Length; i++)
            {
                if (j < B.Length && bigA[i] == B[j])
                {
                    j++;
                }
                else
                {
                    if (j > 0)
                    {
                        return false;
                    }
                }

                if (j == B.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
