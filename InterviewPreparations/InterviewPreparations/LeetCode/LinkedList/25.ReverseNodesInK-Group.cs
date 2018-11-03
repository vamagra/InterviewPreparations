using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseNodesInK_Group
    {
        /// <summary>
        ///// Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

        //k is a positive integer and is less than or equal to the length of the linked list.If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.
        //You may not alter the values in the nodes, only nodes itself may be changed.
        //Only constant memory is allowed.
        //For example,
        //Given this linked list: 1->2->3->4->5
        //For k = 2, you should return: 2->1->4->3->5
        //For k = 3, you should return: 3->2->1->4->5
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode ReverseNodesKGroups(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            // this condition will make sure that it won't reverse the list if list count is less than K
            // You may not alter the values in the nodes, only nodes itself may be changed.
            if (ListLength(head) < k)
            {
                return head;
            }

            ListNode curr = head;
            ListNode next = head;

            ListNode prev = null;
            int counter = 0;

            while (curr != null && counter < k)
            {
                next = curr.next;
                curr.next = prev;

                prev = curr;
                curr = next;

                counter++;
            }

            if (next != null)
            {
                // we are using head.next because as we have already reverse k nodes first node will 
                // be last after K nodes reverse and next iteration will result point to next of head node
                head.next = ReverseNodesKGroups(next, k);
            }

            return prev;
        }

        public static int ListLength(ListNode head)
        {
            int counter = 0;

            while (head != null)
            {
                head = head.next;
                counter++;
            }

            return counter;
        }
    }
}
