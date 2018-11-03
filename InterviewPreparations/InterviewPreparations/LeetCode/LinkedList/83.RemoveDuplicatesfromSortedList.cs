using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.LinkedListClass;
using System.Collections;

namespace InterviewQuestions.LeetCode
{
    class RemoveDuplicatesfromSortedList
    {
        /// <summary>
        // Given a sorted linked list, delete all duplicates such that each element appear only once.
        //  For example,
        //  Given 1->1->2, return 1->2.
        //  Given 1->1->2->3->3, return 1->2->3.
        // </summary>
        // <param name="head"></param>
        // <returns></returns>
        public static ListNode RemoveDuplicates(ListNode head)
        {
            Hashtable hashtable = new Hashtable();

            ListNode curr = head;
            ListNode prev = null;

            while (curr != null)
            {
                if (hashtable.ContainsKey(curr.val))
                {
                    prev.next = curr.next;
                }
                else
                {
                    hashtable.Add(curr.val, curr.val);
                    prev = curr;
                }

                curr = curr.next;
            }

            return head;
        }

        public static ListNode RemoveDuplicateWithoutExtraSpace(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode curr = head;

            while (curr != null && curr.next != null)
            {
                if (curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}
