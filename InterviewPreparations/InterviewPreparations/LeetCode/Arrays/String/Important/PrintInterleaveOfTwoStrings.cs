using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class PrintInterleaveOfTwoStrings
    {
        /// <summary>
        /// Given two strings s1 and s2, write a function that will print all the interleavings of the given two strings.
        //  Here interleaving string is a string which has the same order that of individual strings.
        //  In the below example, we can see that 'A' will always comes before 'B' and 'C' will always comes before 'D'
        //  Example
        //  INPUT
        //  s1 = "AB"
        //  s2 = "CD"
        //  OUTPUT
        //  ABCD, ACBD, ACDB, CABD, CADB, CDAB
        //  </summary>
        //  <param name="s1"></param>
        //  <param name="s2"></param>
        //  <param name="i"></param>
        //  <param name="j"></param>
        //  <param name="result"></param>
        public static void PrintInterleave(string s1, string s2, int i, int j, string result)
        {
            if (i == s1.Length && j == s2.Length)
            {
                Console.WriteLine(result);
            }

            if (i != s1.Length)
            {
                PrintInterleave(s1, s2, i + 1, j, result + s1[i]);
            }

            if (j != s2.Length)
            {
                PrintInterleave(s1, s2, i, j + 1, result + s2[j]);
            }
        }
    }
}
