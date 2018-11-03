using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    // Evaluate infix expression: 2 + 3 * 5 which is also called Polish Notation
    // Implement a basic calculator to evaluate a simple expression string.
    // The expression string may contain open(and closing parentheses ), the plus + or minus sign -, non-negative integers and empty spaces.
    // You may assume that the given expression is always valid.
    // Some examples:
    // "1 + 1" = 2
    // " 2-1 + 2 " = 3
    // "(1+(4+5+2)-3)+(6+8)" = 23
    // Note: Do not use the eval built-in library function.
    // </summary>
    class EvaluateInfixPolishNotation
    {
        public static int ComputeInfixPolishNotation(string expr)
        {
            if(string.IsNullOrEmpty(expr))
            {
                return -1;
            }

            Stack<char> opStack = new Stack<char>();
            Stack<int> operandStack = new Stack<int>();

            bool noOp = false;
            for (int i = 0; i < expr.Length; i++)
            {
                char ch = expr[i];

                if (ch == ' ')
                {
                    continue;
                }
                else if (IsOperand(ch))
                {
                    //// number can be more that one digit
                    StringBuilder sbNumber = new StringBuilder();

                    while (i < expr.Length && expr[i] >= '0' && expr[i] <= '9')
                    {
                        sbNumber.Append(expr[i]);
                        i++;
                    }

                    int num;
                    if (int.TryParse(sbNumber.ToString(), out num))
                    {
                        operandStack.Push(num);
                    }
                    //operandStack.Push(Convert.ToInt32(Char.GetNumericValue(expr[i])));
                }
                else if (ch == '(')
                {
                    opStack.Push(ch);
                    noOp = true;
                }
                else if (IsOperator(ch))
                {
                    while (opStack.Count != 0 && prec(ch) <= prec(opStack.Peek()) && operandStack.Count >= 2)
                    {
                        char op = opStack.Pop();

                        int op1 = operandStack.Pop();
                        int op2 = operandStack.Pop();

                        int result = ComputeExpression(op, op1, op2);

                        if (result != -1)
                        {
                            operandStack.Push(result);                            
                        }
                        else
                        {
                            return -1;
                        }
                    }

                    opStack.Push(ch);
                    noOp = true;
                }
                else if (ch == ')')
                {
                    while (opStack.Count != 0 && opStack.Peek() != '(')
                    {
                        char op = opStack.Pop();

                        int op1 = operandStack.Pop();
                        int op2 = operandStack.Pop();

                        int result = ComputeExpression(op, op1, op2);

                        if (result != -1)
                        {
                            operandStack.Push(result);
                        }
                        else
                        {
                            return -1;
                        }
                    }

                    opStack.Pop();
                    noOp = true;
                }
            }

            while (opStack.Count != 0 && operandStack.Count >= 2)
            {
                char op = opStack.Pop();

                int op1 = operandStack.Pop();
                int op2 = operandStack.Pop();

                int result = ComputeExpression(op, op1, op2);

                if (result != -1)
                {
                    operandStack.Push(result);
                }
                else
                {
                    return -1;
                }
            }

            if(!noOp)
            {
                return Convert.ToInt32(expr);
            }

            return operandStack.Pop();
        }

        private static int ComputeExpression(char op, int op1, int op2)
        {
            switch (op)
            {
                case '+':
                    return op1 + op2;
                case '-':
                    return op2 - op1;
                case '/':
                    return op2 / op1;
                case '*':
                    return op2 * op1;
            }

            return -1;
        }

        private static int prec(char ch)
        {
            switch(ch)
            {
                case '+':
                case '-':
                    return 1;
                case '/':
                case '*':
                    return 2;
                case '^':
                    return 3;
            }

            return -1;
        }

        private static bool IsOperand(char ch)
        {
            return ch >= '0' && ch <= '9';
        }

        private static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '/' || ch == '*';
        }
    }
}
