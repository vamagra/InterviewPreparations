using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class EvaluateReversePolishNotation
    {
        /// <summary> 
        //  Evaluate the value of an arithmetic token expression in Reverse Polish Notation.
        //  Valid operators are +, -, *, /. Each operand may be an integer or another token expression.
        //  Some examples:
        //  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
        //  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
        //  </summary>
        //  <param name="tokens"></param>
        // This notation also called Post polish notation
        ///  <returns></returns>        
        public static int ComputePostFixtokensression(string[] tokens)
        {
            if (tokens.Length < 1)
            {
                return -1;
            }

            // Steps - 
            // 1. we will use stack to store the operand
            // 2. loop through the string one by one
            // 3. if that is operand push it into stack
            // 4. if that is operator & stack count is greater than equal to 2 (beacuse we need atleast two operand two perform some operation)\
            // 5. Pop last two operand
            // 6. apply the operator on two operand
            // 7. get the result and push this result in stack

            Stack<int> operandStack = new Stack<int>();
            int num;

            foreach (string s in tokens)
            {
                if (int.TryParse(s, out num))
                {
                    operandStack.Push(num);
                }
                else if(IsOp(s))
                {
                    if (operandStack.Count >= 2)
                    {
                        int num1 = operandStack.Pop();
                        int num2 = operandStack.Pop();

                        int result = Apply(s, num1, num2);
                        operandStack.Push(result);
                    }
                }
            }

            return operandStack.Pop();
        }

        private static bool IsOp(string s)
        {
            return s == "+" || s == "-" || s == "/" || s == "*";
        }

        private static int Apply(string op, int num1, int num2)
        {
            switch(op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num2 - num1;
                case "/":
                    if (num1 == 0)
                    {
                        return int.MaxValue;
                    }
                    return num2 / num1;
                case "*":
                    return num2 * num1;
            }

            return int.MaxValue;
        }
    }
}
