using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class GenerateParentheses
    {
        /// <summary>
        // Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
        //   For example, given n = 3, a solution set is:
        //  [
        //      "((()))",
        //      "(()())",
        //      "(())()",
        //      "()(())",
        //      "()()()"
        //  ]
        /// </summary>
        // <param name="n"></param>
        // <returns></returns>
        public static IList<string> GenerateValidParenthesesFromGivenNumber(int n)
        {
            if (n < 1)
            {
                return null;
            }

            List<string> listValidParentheses = new List<string>();

            GenerateValidParenthesesOneByOne("", listValidParentheses, n, n);

            return listValidParentheses;
        }

        public static void GenerateValidParenthesesOneByOne(string subList, List<string> list, int left, int right)
        {
            if (left > right)
            {
                return;
            }

            if (left > 0)
            {
                GenerateValidParenthesesOneByOne(subList + "(", list, left - 1, right);
            }

            if (right > 0)
            {
                GenerateValidParenthesesOneByOne(subList + ")", list, left, right - 1);
            }

            //When we got all the valid Parenthesis
            if (left == 0 && right == 0)
            {
                list.Add(subList);
                return;
            }
        }
    }
}
