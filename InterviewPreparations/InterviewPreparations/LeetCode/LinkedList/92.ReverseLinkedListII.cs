using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Reverse a linked list from position m to n. Do it in-place and in one-pass.
    //  For example:
    //  Given 1->2->3->4->5->NULL, m = 2 and n = 4,
    //  return 1->4->3->2->5->NULL.
    //  Note:
    //  Given m, n satisfy the following condition:
    //  1 ≤ m ≤ n ≤ length of list.
    /// </summary>
    class ReverseLinkedListII
    {
        public static ListNode ReverseList(ListNode head, int m, int n)
        {
            if (head == null)
            {
                return null;
            }

            if (m > n && m > 1 && n > 1)
            {
                return head;
            }

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prev1 = null;
            ListNode curr1 = dummy;

            //reach to the mth pointer where from we want to start the reverse
            for (int i = 0; i < m; i++)
            {
                prev1 = curr1;
                curr1 = curr1.next;
            }

            //reverse the list till nth node
            ListNode prev2 = prev1;
            ListNode curr2 = curr1;
            
            for (int i = m; i <= n; i++)
            {
                ListNode next = curr2.next;
                curr2.next = prev2;
                prev2 = curr2;
                curr2 = next;
            }

            //connect the nodes from mth to nth node
            prev1.next = prev2;
            curr1.next = curr2;

            return dummy.next;
        }
    }
}
