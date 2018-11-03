using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SortStackUsingTempStack
    {
        /// <summary>
        // Write a program to sort a stack in ascending order (with biggest items on top).
        // You may use at most one additional stack to hold items, but you may not copy
        // the elements into any other data structure(such as an array). The stack supports
        // the following operations: push, pop, peek, and isEmpty.
        // </summary>
        // <param name="stack"></param>
        // Given a stack of integers, sort it in ascending order using another temporary stack.
        //  Examples:
        //  Input : [34, 3, 31, 98, 92, 23]
        //  Output : [3, 23, 31, 34, 92, 98]
        //  Input : [3, 5, 1, 4, 2, 8]
        //  Output : [1, 2, 3, 4, 5, 8]
        public static void SortStackAscendingOrder(Stack<int> stack)
        {
            // Here is the steps to sort the stack
            // 1. loop over the main stack
            // 2. pop the element from main stack, call it temp
            // 3. run the loop on tempStack, if temp is greater than temp Stack Peek()
            //    pop the element from temp Stack and push into the main Stack.
            // 4. now add the temp in tempStack.  

            if (stack.Count < 1)
            {
                return;
            }

            Stack<int> tempStack = new Stack<int>();

            while (stack.Count != 0)
            {
                int temp = stack.Pop();

                while (tempStack.Count != 0 && tempStack.Peek() > temp)
                {
                    stack.Push(tempStack.Pop());
                }

                tempStack.Push(temp);
            }
        }

        public static void SortStackDescendingOrder(Stack<int> stack)
        {
            // Here is the steps to sort the stack
            // 1. loop over the main stack
            // 2. pop the element from main stack, call it temp
            // 3. run the loop on tempStack, if temp is less than temp Stack Peek()
            //    pop the element from temp Stack and push into the main Stack.
            // 4. now add the temp in tempStack.  

            if (stack.Count < 1)
            {
                return;
            }

            Stack<int> tempStack = new Stack<int>();

            while (stack.Count != 0)
            {
                int temp = stack.Pop();

                while (tempStack.Count != 0 && tempStack.Peek() < temp)
                {
                    stack.Push(tempStack.Pop());
                }

                tempStack.Push(temp);
            }
        }
    }
}
