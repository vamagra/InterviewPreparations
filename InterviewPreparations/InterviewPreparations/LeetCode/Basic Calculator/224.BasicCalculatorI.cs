using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    public class BasicCalculatorI
    {
        /// <summary>
        /// Implement a basic calculator to evaluate a simple expression string.
        //  The expression string may contain open(and closing parentheses ), the plus + or minus sign -, non-negative integers and empty spaces.
        //  You may assume that the given expression is always valid.
        //  Some examples:
        //  "1 + 1" = 2
        //  " 2-1 + 2 " = 3
        //  "(1+(4+5+2)-3)+(6+8)" = 23
        //  </summary>
        //  <param name="exp"></param>
        //  <returns></returns>

        #region Solution Steps
        //    digit: it should be one digit from the current number
        //    '+': number is over, we can add the previous number and start a new number
        //    '-': same as above
        //    '(': push the previous result and the sign into the stack, set result to 0, just calculate the new result within the parenthesis.
        //    ')': pop out the top two numbers from stack, first one is the sign before this pair of parenthesis, second is the temporary result before this pair of parenthesis.We add them together.

        #endregion

        public static int Calculate(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return -1;
            }

            int sign = 1;
            int result = 0;

            int number = 0;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (ch >= '0' && ch <= '9')
                {
                    number = number * 10 + (ch - '0');
                }
                else if (ch == '+')
                {
                    number = sign * number;
                    result += number;
                    number = 0;
                    sign = 1;
                }
                else if (ch == '-')
                {
                    number = sign * number;
                    result += number;
                    number = 0;
                    sign = -1;
                }
                else if (ch == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    sign = 1;
                    result = 0;
                }
                else if (ch == ')')
                {
                    number = sign * number;
                    result = result + number;

                    number = 0;

                    //pop the sign first
                    result = result * stack.Pop();
                
                    //pop the result then
                    result = result + stack.Pop();
                }
            }

            if (number != 0)
            {
                number = number * sign;
                result = result + number;
            }

            return result;
        }
    }
}
