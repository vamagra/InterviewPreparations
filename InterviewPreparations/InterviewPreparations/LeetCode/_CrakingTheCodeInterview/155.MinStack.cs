using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.Design
{
    //e.g. 3 5 2 1 1 -1
    // Stack -  -2 2 -1(Push)
    // Stack - (3) (2) -1 -1 0 -1 (Pop)
    // MinElement - -3

    class MinStack_CTCI
    {
        Stack<int> stack;
        Stack<int> minStack;

        MinStack_CTCI()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int data)
        {
            stack.Push(data);

            // if minstack is not empty OR minstack top value is greate than current val then push curr in minStack
            if (minStack.Count == 0 || minStack.Peek() >= data)
            {
                minStack.Push(data);
            }
        }

        public int Pop()
        {
            int stackElement = stack.Pop();

            if (stackElement == minStack.Peek())
            {
                return minStack.Pop();
            }

            return -1;
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }

    class MinStack_
    {
        //Refer this link for solution - https://www.geeksforgeeks.org/design-and-implement-special-stack-data-structure/
        Stack<long> minStack;
        long minElement;
        public MinStack_()
        {
            minStack = new Stack<long>();
        }

        public void Push(int data)
        {
            //if this is the first element of stack
            if (minStack.Count == 0)
            {
                minStack.Push(0L);
                minElement = data;
            }
            else
            {
                minStack.Push(data - minElement);

                if (data < minElement)
                {
                    minElement = data;
                }
            }
        }

        public void Pop()
        {
            if (minStack.Count == 0)
            {
                return;
            }

            long popElement = minStack.Pop();

            if (popElement < 0)
            {
                minElement = minElement - popElement;
            }
        }

        public int Top()
        {
            long topElement = minStack.Peek();

            if (topElement > 0)
            {
                return (int)(topElement + minElement);
            }
            else
            {
                return (int)minElement;
            }
        }

        public int GetMin()
        {
            return (int)minElement;
        }
    }


}
