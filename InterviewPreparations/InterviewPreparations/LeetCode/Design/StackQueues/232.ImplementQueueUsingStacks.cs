using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ImplementQueueUsingStacks
    {
        Stack<int> stack1 = null;
        Stack<int> stack2 = null;
        /** Initialize your data structure here. */
        public ImplementQueueUsingStacks()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            int popItem = -1;

            // if stack two is empty then push the element from stack1 to stack2
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            //pop the element from stack2
            popItem = stack2.Pop();

            return popItem;
        }

        /** Get the front element. */
        public int Peek()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.First();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
