using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ImplementStackUsingQueues
    {
        #region Method 1
        //public Queue<int> queue1;
        //public Queue<int> queue2;
        ///** Initialize your data structure here. */
        //public ImplementStackUsingQueues()
        //{
        //    queue1 = new Queue<int>();
        //    queue2 = new Queue<int>();
        //}

        ///** Push element x onto stack. */
        //public void Push(int x)
        //{
        //    if (queue1.Count > 0)
        //    {
        //        queue1.Enqueue(x);
        //    }
        //    else if (queue2.Count > 0)
        //    {
        //        queue2.Enqueue(x);
        //    }
        //    else
        //    {
        //        queue1.Enqueue(x);
        //    }
        //}

        ///** Removes the element on top of the stack and returns that element. */
        //public int Pop()
        //{
        //    int popElement = -1;

        //    if (queue1.Count > 1)
        //    {
        //        while (queue1.Count != 1)
        //        {
        //            queue2.Enqueue(queue1.Dequeue());
        //        }

        //        return queue1.Dequeue();
        //    }
        //    else if (queue2.Count > 1)
        //    {
        //        while (queue2.Count != 1)
        //        {
        //            queue1.Enqueue(queue2.Dequeue());
        //        }

        //        return queue2.Dequeue();
        //    }

        //    if (queue1.Count == 0 && queue2.Count == 1)
        //    {
        //        popElement = queue2.Dequeue();
        //    }
        //    else
        //    {
        //        popElement = queue1.Dequeue();
        //    }

        //    return popElement;
        //}

        ///** Get the top element. */
        //public int Top()
        //{
        //    int topElement = -1;

        //    if (queue1.Count > 1)
        //    {
        //        while (queue1.Count != 1)
        //        {
        //            queue2.Enqueue(queue1.Dequeue());
        //        }

        //        queue2.Enqueue(queue1.First<int>());                
        //        return queue1.Dequeue();
        //    }
        //    else if (queue2.Count > 1)
        //    {
        //        while (queue2.Count != 1)
        //        {
        //            queue1.Enqueue(queue2.Dequeue());
        //        }

        //        queue1.Enqueue(queue2.First<int>());
        //        return queue2.Dequeue();
        //    }

        //    if (queue1.Count == 0 && queue2.Count == 1)
        //    {
        //        topElement =  queue2.First<int>();
        //    }
        //    else
        //    {
        //        topElement = queue1.First<int>();
        //    }

        //    return topElement;
        //}

        ///** Returns whether the stack is empty. */
        //public bool Empty()
        //{
        //    if (queue1.Count == 0 && queue2.Count==0)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        #endregion

        #region Method 2
        public Queue<int> queue1;
        public Queue<int> queue2;
        /** Initialize your data structure here. */
        public ImplementStackUsingQueues()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            queue1.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int popElement = -1;

            if (queue1.Count > 1)
            {
                while (queue1.Count != 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
            }

            popElement = queue1.Dequeue();

            //swap the queue after pop
            Queue<int> temp = queue2;
            queue2 = queue1;
            queue1 = temp;
            
            return popElement;
        }

        //public int Pop1()
        //{
        //    int popElement = -1;

        //    if (queue1.Count > 1)
        //    {
        //        while (queue1.Count != 1)
        //        {
        //            queue2.Enqueue(queue1.Dequeue());
        //        }

        //        return queue1.Dequeue();
        //    }
        //    else if (queue2.Count > 1)
        //    {
        //        while (queue2.Count != 1)
        //        {
        //            queue1.Enqueue(queue2.Dequeue());
        //        }

        //        return queue2.Dequeue();
        //    }

        //    if (queue1.Count == 0 && queue2.Count == 1)
        //    {
        //        popElement = queue2.Dequeue();
        //    }
        //    else
        //    {
        //        popElement = queue1.Dequeue();
        //    }

        //    return popElement;
        //}


        /** Get the top element. */
        public int Top()
        {
            int topElement = -1;

            if (queue1.Count > 1)
            {
                while (queue1.Count != 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
            }

            topElement = queue1.First<int>();

            return topElement;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (queue1.Count == 0 && queue2.Count == 0)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
