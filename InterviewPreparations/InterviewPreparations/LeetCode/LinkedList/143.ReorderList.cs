using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.LinkedList
{
    class ReorderList
    {
        /// <summary>
        /// Given a singly linked list L: L0→L1→…→Ln-1→Ln,
        //  reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…
        //  You must do this in-place without altering the nodes' values.
        //  For example,
        //  Given {1,2,3,4}, reorder it to {1,4,2,3}.
        // </summary>
        // <param name="head"></param>
        public static void ReorderLinkedListNodes(ListNode head)
        {
            if (head == null)
            {
                return;
            }

            //It can be done in below three steps - 

            // 1. get the middle of linked list and split the list in two parts
            // 2. revrese the second half of the list
            // 3. merge both the linked list

            ListNode prevSlow = null;
            ListNode slow = head;
            ListNode fast = head;
            ListNode l1 = head;

            while (fast != null && fast.next != null)
            {
                prevSlow = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            //split the list in two
            prevSlow.next = null;

            //reverse the linked list
            ListNode l2 = Reverse(slow);

            //merge the two linked list
            mergeTwoList(l1, l2);
        }

        private static ListNode Reverse(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        private static void mergeTwoList(ListNode l1, ListNode l2)
        {
            while (l1 != null)
            {
                ListNode list1Next = l1.next;
                ListNode list2Next = l2.next;

                //attach next list node to fist list node
                l1.next = l2;

                //check if next node is null of first node, its mean list node is complete
                if (list1Next == null)
                {
                    break;
                }

                l2.next = list1Next;

                l1 = list1Next;
                l2 = list2Next;
            }
        }
    }
}
