using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class BasicCalculatorII
    {
        /// <summary>
        // Implement a basic calculator to evaluate a simple expression string.
        // The expression string contains only non-negative integers, +, -, *, / operators and empty spaces.The integer division should truncate toward zero.
        // You may assume that the given expression is always valid.
        // Some examples:
        // "3+2*2" = 7
        // " 3/2 " = 1
        // " 3+5 / 2 " = 5
        //  </summary>
        //  <param name="expr"></param>
        //  <returns></returns>
        public static int Calculate(string expr)
        {
            if (expr.Length < 1)
            {
                return 0;
            }

            if (expr.Length == 1)
            {
                return expr[0] - '0';
            }

            Stack<int> stack = new Stack<int>();
            int number = 0;

            char sign = '+';

            int len = expr.Length - 1;

            for (int i = 0; i < expr.Length; i++)
            {
                char ch = expr[i];

                if (ch >= '0' && ch <= '9')
                {
                    number = number * 10 + (ch - '0');
                }

                if ((!(ch >= '0' && ch <= '9') && ch != ' ') || i == len)
                {
                    if (sign == '+')
                    {
                        stack.Push(number);
                    }
                    else if (sign == '-')
                    {
                        stack.Push(-number);
                    }
                    else if (sign == '*')
                    {
                        stack.Push(stack.Pop() * number);
                    }
                    else if (sign == '/')
                    {
                        stack.Push(stack.Pop() / number);
                    }

                    sign = ch;
                    number = 0;
                }
            }

            int result = 0;

            if (stack.Count >= 1)
            {
                for (int i = 0; i < stack.Count;)
                {
                    result += stack.Pop();
                }
            }
            else
            {
                result = number;
            }

            return result;
        }
    }
}
