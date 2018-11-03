using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.LinkedListClass;

namespace InterviewQuestions.LeetCode
{
    class RemoveNthNodeFromEndOfList
    {
        /// <summary>
        /// Given a linked list, remove the n-th node from the end of list and return its head.
        //  Example:
        //  Given linked list: 1->2->3->4->5, and n = 2.
        //  After removing the second node from the end, the linked list becomes 1->2->3->5.
        //  Note:
        //  Given n will always be valid.
        //  Follow up:
        //  Could you do this in one pass?
        //  </summary>
        //  <param name="head"></param>
        //  <param name="n"></param>
        //  <returns></returns>
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;

            int i = 0;

            if (head.next == null || head == null)
            {
                return null;
            }

            while (i < n)
            {
                if (slow == null)
                {
                    return null;
                }

                i++;
                slow = slow.next;
            }

            // remove head node list
            if (slow == null)
            {
                head = head.next;
                return head;
            }

            while (slow != null && slow.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            fast.next = fast.next.next;

            return head;
        }
    }
}
