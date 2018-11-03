using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LinkedListDetectCycle_CTCI
    {
        /// <summary>
        /// Given a linked list, determine if it has a cycle in it.
        //  Follow up:
        //  Can you solve it without using extra space?
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool DetetctLoopLinkedList(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            bool loopDetected = false;

            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (slowPointer != null && fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;

                if (slowPointer == fastPointer)
                {
                    loopDetected = true;
                    break;
                }
            }

            return loopDetected;
        }
    }
}
