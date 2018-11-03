using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    // * imagine a (literal) stack of plates. If the stack gets too high, it might topple. 
    // * Therefore, in real life, we would likely start a new stack when the previous stack exceeds
    // * some threshold.Implement a data structure SetOfStacks that mimics this. 
    // * SetOfStacks should be composed of several stacks, and should create a new stack once
    // * the previous one exceeds capacity.SetOfStacks.push() and SetOfStacks.pop() should
    // * behave identically to a single stack(that is, pop() should return the same values as it
    // * would if there were just a single stack).
    // * FOLLOW UP
    // * Implement a function popAt(int index) which performs a pop operation on a specific
    // * sub-stack.
    //  </summary>
    class SetOfStacksPlates
    {
        List<Stack> listStack;
        int thresHold;

        SetOfStacksPlates(int limit)
        {
            listStack = new List<Stack>();
            thresHold = limit;
        }

        private Stack getLastStack()
        {
            if (listStack.Count == 0)
            {
                return null;
            }

            return listStack[listStack.Count - 1];
        }

        private Stack getNthStack(int n)
        {
            if (listStack.Count == 0 || n > listStack.Count)
            {
                return null;
            }

            return listStack[n - 1];
        }

        private void Push(int data)
        {
            Stack stack = getLastStack();

            if (stack == null)
            {
                stack = new Stack();
                stack.Push(data);
                listStack.Add(stack);
            }
            else
            {
                if (stack.Count < thresHold)
                {
                    stack.Push(data);
                }
                else
                {
                    Stack newStack = new Stack();
                    newStack.Push(data);

                    listStack.Add(newStack);
                }
            }
        }

        private int Pop()
        {
            Stack stack = getLastStack();

            if (stack == null)
            {
                return -1;
            }

            int x = Convert.ToInt32(stack.Pop());
            if (stack.Count == 0)
            {
                listStack.Remove(stack);
            }

            return x;
        }

        private int PopnthStack(int n)
        {
            Stack stack = getNthStack(n);

            if (stack == null)
            {
                return -1;
            }

            int x = Convert.ToInt32(stack.Pop());

            if (stack.Count == 0)
            {
                listStack.Remove(stack);
            }

            return x;
        }
    }

    class MyStack
    {
        int[] nums;
        int top;
        int size;

        MyStack(int capacity)
        {
            nums = new int[capacity];
            top = -1;
            size = capacity;
        }

        public void Push(int data)
        {
            if (nums.Length < size)
            {
                nums[++top] = data;
                size++;
            }
        }

        public int Pop()
        {
            if (top > -1)
            {
                return nums[top--];
            }

            return -1;
        }
    }
}
