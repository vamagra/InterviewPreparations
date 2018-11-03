using InterviewQuestions.LinkedListClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RemoveDuplicatesFromSortedListII
    {
        /// <summary>
        /// Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
        //  Example 1:
        //  Input: 1->2->3->3->4->4->5
        //  Output: 1->2->5
        //  Example 2:
        //  Input: 1->1->1->2->3
        //  Output: 2->3
        //  </summary>
        //  <param name="head"></param>
        //  <returns></returns>
        public static ListNode RemoveDuplicate(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode curr = head;
            ListNode prev = null;

            //delete duplicate from starting
            int n = CountDuplicates(head);
            if (n > 1)
            {
                head = DeleteDuplicates(head, n);
            }

            curr = head;
            prev = null;

            while (curr != null && curr.next != null)
            {
                n = CountDuplicates(curr);
                if (n > 1)
                {
                    curr = DeleteDuplicates(curr, n);

                    if (prev == null && curr == null)
                    {
                        return null;
                    }

                    if (prev == null)
                    {
                        head = curr;
                    }
                    else
                    {
                        prev.next = curr;
                    }
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
            }

            return head;
        }

        private static int CountDuplicates(ListNode curr)
        {
            int n = 1;

            while (curr != null && curr.next != null)
            {
                if (curr.val == curr.next.val)
                {
                    n++;
                    curr = curr.next;
                }
            }

            return n;
        }

        private static ListNode DeleteDuplicates(ListNode head, int n)
        {
            int counter = 0;
            ListNode prev = null;
            ListNode curr = head;

            while (counter < n && curr != null)
            {
                prev = curr;
                curr = curr.next;
                counter++;
            }
            prev = null;

            return curr;
        }
    }
}
