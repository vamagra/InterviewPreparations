using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseLinkedListClass
    {
        // O(n)
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode curr = head, next = null;
            ListNode prev = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        static ListNode head = null;
        // O(n)
        public static void ReverseListRecursiveMethod(ListNode prev, ListNode curr)
        {
            //Call the function this way:

            //rec_reverse(NULL, head);
            //Approach:

            // Calling the function recursively (line 6) we go to the last node of linked list.
            // ReverseListRecursiveMethod(curr, curr.next);

            // Then we update head with the address of the last node(line 10).
            // head = prev;

            // Finally, we point link of each node to its previous node (line 7).
            // curr.next = prev;

            if (curr != null)
            {
                ReverseListRecursiveMethod(curr, curr.next);
                curr.next = prev;
            }
            else
            {
                head = prev;
            }
        }
    }
}
