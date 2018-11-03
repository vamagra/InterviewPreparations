using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LongestValidParenthesesClass
    {
        /// <summary>
        /// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
        //  For "(()", the longest valid parentheses substring is "()", which has length = 2.
        //  Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// 
        #region Solution
        //  The idea is simple, we only update the result(max) when we find a "pair".
        //  If we find a pair. We throw this pair away and see how big the gap is between current and previous invalid.
        //  EX: "( )( )" stack: -1, 0,
        //  when we get to index 1 ")", the peek is "(" so we pop it out and see what's before "(".
        //  In this example it's -1. So the gap is "current_index" - (-1) = 2.
        #endregion
        public static int LongestValidParenthesisLength(string s)
        {
            Stack<int> stack = new Stack<int>();

            int maxLength = 0;

            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return maxLength;
            }

            stack.Push(-1);

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == ')' && stack.Count > 1 && s[stack.Peek()] == '(')
                {
                    stack.Pop();
                    maxLength = Math.Max(maxLength, i - stack.Peek());
                }
                else
                {
                    stack.Push(i);
                }
            }

            return maxLength;
        }
    }
}
