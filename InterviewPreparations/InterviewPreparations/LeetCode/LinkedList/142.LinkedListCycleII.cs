using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LinkedListCycleII
    {
        /// <summary>
        /// Given a linked list, return the node where the cycle begins. If there is no cycle, return null.
        //  Note: Do not modify the linked list.
        //  Follow up:
        //  Can you solve it without using extra space?
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode slow = head;
            ListNode fast = head;

            bool IsLoop = false;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    IsLoop = true;
                    break;
                }
            }

            if (!IsLoop)
            {
                return null;
            }

            slow = head;

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }
}
