using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MinimumReversalValidParenthesis
    {
        /// <summary>
        /// You will be provided a string containing opening and closing brackets, You need to identify that how many reversals is required to balance the brackets.
        //  For Ex
        //  "{}" this is balanced but this is not "{{{}", You need to make this balanced by doing reversal
        //  "}{{{{}" This is not balanced you need 3 reversals to make this a balanced bracket string.
        //  "}{}{{{}" This is not a balanced string and you cannot make it as balanced as 
        //  it contains improper number of opening and closing brakcets
        //  </summary>
        //  <param name="s"></param>
        // <returns></returns>
        public static int MinimumReversalNeededForValidString(string s)
        {
            // So in order to achieve this we will push all the opening brackets in stack and then as we encounter any closing bracket 
            // we will pop an opening bracket from the stack. if at last if even number of brackets left in 
            // stack than the string can be made balanced otherwise 
            // not.

            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return -1;
            }

            Stack<char> stack = new Stack<char>();
            int reversalCount = 0;

            if (s[0] == '}')
            {
                stack.Push('{');
                reversalCount++;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == '}')
                {
                    stack.Pop();
                }
            }

            if (stack.Count % 2 != 0)
            {
                return -1;
            }

            return stack.Count / 2 + reversalCount;
        }
    }
}
