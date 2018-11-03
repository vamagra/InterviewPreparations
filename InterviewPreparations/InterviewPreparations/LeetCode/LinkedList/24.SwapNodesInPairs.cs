using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SwapNodesInPairs
    {

        /// <summary>
        /// Given a linked list, swap every two adjacent nodes and return its head.
        //  For example,
        //  Given 1->2->3->4, you should return the list as 2->1->4->3.
        //  Your algorithm should use only constant space.You may not modify the values in the list, only nodes itself can be changed.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode SwapNodesPairWise(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            //Initialize the list with second node
            ListNode newhead = head.next;

            ListNode curr = head.next;
            ListNode prev = head;

            ListNode next = null;

            while (true)
            {
                //store the 3rd node pointer store in 2nd node next in next pointer
                next = curr.next;

                //now link the second node next pointer to prev node which is 1 node for first iteration
                curr.next = prev;

                //check for null next node which is 3 node or next.next node which is 4th node is null
                // prev.next which is head next (would be second node of the list after above two swaps assign next pointer
                if (next == null || next.next == null)
                {
                    prev.next = next;
                    break;
                }

                //change the next of previous 2nd node to next next
                prev.next = next.next;

                // if not then change the curr and prev pointers
                // assign prev pointer to next which is 3rd node of the list for 1 iteration
                prev = next;

                //curr would be 4th node for the first iteration
                curr = prev.next;
            }

            return newhead;
        }

    }
}
