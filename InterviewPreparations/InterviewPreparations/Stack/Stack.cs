using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.StackClass
{
    public class Stack
    {
        public static int MAX;
        public static char[] stack;

        public static int top = -1;
        
        public static void INIT(int length)
        {
            stack = new char[length];
            MAX = length;
        }

        public static bool EmptyStack()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool FullStack()
        {
            if (top == MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Push(char data)
        {
            if(!FullStack())
            {
                stack[++top] = data;
            }
        }

        public static char Pop()
        {
            if (!EmptyStack())
            {
               return stack[top--];
            }

            return 'a';
        }
    }
}
