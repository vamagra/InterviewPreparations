using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    /// Convert Expression A + B * C. As shown above, A B C * + is the postfix equivalent
    /// </summary>
    class ConvertInfixToPostFix
    {
        public static string InfixToPostFix(string expression)
        {
            if(string.IsNullOrEmpty(expression))
            {
                return expression;
            }

            // Steps - 
            // 1. create stack to store the operator
            // 2. loop through the expression one by one
            // 3. operand -> add the operand to the resulted string
            // 4. operator -> we need to push the operator in stack but before that we need to add the higher precedence operator in resulted string
            //             -> loop thourgh the stack elements and get the higher precendce operator from curr operator and add to the resulted string
            // 5. "(" -> push left bracket in op stack
            // 6. ")" -> loop through the stack operator and add to the resulted string beacuse ( takes highest precendence than any operator
            // 7. after the experession loop, if is there any operator remaining in the stack add it to the resulted string

            Stack<char> opStack = new Stack<char>();
            StringBuilder sbResult = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                // 1. If Operand append it at the end of the output
                if (IsOperand(expression[i]))
                {
                    sbResult.Append(expression[i]);
                }
                // 2. If Operator 
                else if (IsOperator(expression[i]))
                {
                    // Popped all the higher precedence operators from stack then expression operator
                    while (opStack.Count != 0 && PrecedenceChar(expression[i]) <= PrecedenceChar(opStack.Peek()))
                    {
                        char popChar = opStack.Pop();
                        sbResult.Append(popChar);
                    }

                    // Push the operator if exp char precedence is higher than stack char
                    opStack.Push(expression[i]);
                }
                else if (expression[i] == '(')
                {
                    opStack.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (opStack.Count != 0 && opStack.Peek() != '(')
                    {
                        sbResult.Append(opStack.Pop());
                    }
                }
            }

            while (opStack.Count != 0)
            {
                sbResult.Append(opStack.Pop());
            }

            return sbResult.ToString();
        }

        private static bool IsOperand(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }

        private static bool IsOperator(char ch)
        {
            return (ch == '+' || ch == '-' || ch == '/' || ch == '*');
        }

        private static int PrecedenceChar(char opChar)
        {
            switch(opChar)
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
    }
}
