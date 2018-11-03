using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Queue
{
    public class Queue
    {
        public static int Max = 100;
        public static int front = -1;
        public static int rear = -1;
        public static int[] queue;

        public static void INIT(int length)
        {
            queue = new int[length];
            Max = length;
        }

        public static bool IsEmpty()
        {
            if (front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isFull()
        {
            if (rear == Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Enqueue(int data)
        {
            if (!isFull())
            {
                if (front == -1)
                {
                    front++;
                }

                queue[rear++] = data;
            }
        }

        public static int Dequeue(int data)
        {
            if (!IsEmpty())
            {
                return queue[front++];
            }

            return 0;
        }
    }
}
