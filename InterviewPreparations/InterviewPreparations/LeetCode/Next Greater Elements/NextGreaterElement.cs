using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class NextGreaterElement
    {
        /// <summary>
        /// Given an array, print the Next Greater Element (NGE) for every element. The Next greater Element for an element x is the first greater element on the right side of x in array. Elements for which no greater element exist, consider next greater element as -1.
        //  Examples:
        //  a) For any array, rightmost element always has next greater element as -1.
        //  b) For an array which is sorted in decreasing order, all elements have next greater element as -1.
        //  c) For the input array[4, 5, 2, 25}, the next greater elements for each element are as follows.
        //  Element NGE
        //  4      -->   5
        //  5      -->   25
        //  2      -->   25
        //  25     -->   -1
        //  d) For the input array[13, 7, 6, 12}, the next greater elements for each element are as follows.
        //  Element NGE
        //  13      -->    -1
        //  7       -->     12
        //  6       -->     12
        //  12     -->     -1
        // </summary>
        /// <param name="nums"></param>
        public static void NextGreater(int[] nums)
        {
            Stack<int> st = new Stack<int>();

            if (nums.Length < 1)
            {
                return;
            }

            //push the first element in the stack
            st.Push(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                //pick the next element from array, assume this is next greater element
                int next = nums[i];

                //if stack is not empty
                if (st.Count > 0)
                {
                    int element = st.Pop();

                    while (element < next)
                    {
                        Console.WriteLine(element + "->" + next);

                        if (st.Count != 0)
                        {
                            element = st.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (element > next)
                    {
                        st.Push(element);
                    }
                }


                //else push the next element in the stack
                st.Push(next);
            }

            while (st.Count != 0)
            {
                int item = st.Pop();
                Console.WriteLine(item + "-> -1");
            }
            
            Console.Read();
        }

        public static int[] NextGreaterII(int[] nums)
        {
            int[] result = new int[nums.Length];

            if (nums.Length < 1)
            {
                return result;
            }

            //Idea here is to solve the problem by using stack with following steps;

            //1. keep iterating the array one by one element
            //2. if stack is empty push the first element.
            //3. now for the next iterative element check if the next element is greater than stack.top element
            //4. Loop untill stack is not empty if so pop the element from the stack and print the next greater element for popped element
            //5. push the current element in the stack
            //6. idea here is to store the elements in the stack in sorted manner - means largest element at the end and smallest element in the top
            //7. after array iteration if there is any element in the stack then print null for those element after popping them from stack.


            Stack<int> stack = new Stack<int>();
            stack.Push(nums[0]);


            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                //if curr element is greater than stack top element pop the element from stack and print the next greater element
                while (stack.Count > 0 && nums[i] > stack.Peek())
                {
                    //Console.WriteLine(stack.Pop() + " --> " + nums[i]);
                    result[count++] = nums[i];
                    stack.Pop();
                }

                stack.Push(nums[i]);
            }

            while (stack.Count != 0)
            {
                //Console.WriteLine(stack.Pop() + " --> -1");
                result[count++] = -1;
                stack.Pop();
            }

            return result;

            //Console.ReadKey();
        }

    }
}
