using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class CountAndSayClass
    {
        /// <summary>
        /// The count-and-say sequence is the sequence of integers with the first five terms as following:
        //  1.     1
        //  2.     11
        //  3.     21
        //  4.     1211
        //  5.     111221
        //  1 is read off as "one 1" or 11.
        //  11 is read off as "two 1s" or 21.
        //  21 is read off as "one 2, then one 1" or 1211.
        //  Given an integer n, generate the nth term of the count-and-say sequence.
        //  Note: Each term of the sequence of integers will be represented as a string.
        //  </summary>
        //  <param name="n"></param>
        /// <returns></returns>
        public static string CountAndSayNumber(int n)
        {
            #region solution

            // Idea is quite simple here
            // we need to execute the loop number of times as n
            // we need to start as 1 and keep increasing the output till n terms
            // first term output will next term input

            #endregion

            if (n == 1)
            {
                return "1";
            }

            string output = "1";

            //call countAndSay method n-1 times
            while (n != 1)
            {
                output = CountAndSayMethod(output);
                n--;
            }

            return output;
        }

        private static string CountAndSayMethod(string output)
        {
            int count = 1;
            char ch = output[0];

            StringBuilder sbOutput = new StringBuilder();

            for (int i = 1; i < output.Length; i++)
            {
                if (ch != output[i])
                {
                    sbOutput.Append(count + "" + ch);
                    ch = output[i]; // reset the ch with next available character
                    count = 1; // reste the count with 1
                }
                else
                {
                    count++;
                }
            }

            sbOutput.Append(count + "" + ch);

            return sbOutput.ToString();    
        }
    }
}
