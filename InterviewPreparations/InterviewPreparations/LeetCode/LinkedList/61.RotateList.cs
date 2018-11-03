using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RotateList
    {
        /// <summary>
        // Given a list, rotate the list to the right by k places, where k is non-negative.
        //  Example:
        //  Given 1->2->3->4->5->NULL and k = 2,
        //  return 4->5->1->2->3->NULL.
        /// </summary>
        
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            ListNode fast = head;
            ListNode newHead = head;

            int length = 1;

            //get the count of Linked List
            while (fast.next != null)
            {
                fast = fast.next;
                length++;
            }

            //make a cycle here
            fast.next = head;

            k = (length - k) % length;

            while (k != 0)
            {
                fast = fast.next;
                k--;
            }

            // this will make the fast as new head of the list
            newHead = fast.next;

            //this will make the head.next as last node of the list
            fast.next = null;

            return newHead;
        }

        public static ListNode RotateRightII(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            ListNode curr = head;

            ListNode slow = head;
            ListNode fast = head;

            int counter = 1;

            while (counter <= k && slow != null)
            {
                slow = slow.next;
                counter++;
            }

            ListNode prev = null;
            ListNode next = head;

            if (k >= counter)
            {
                while (curr != null)
                {
                    next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                }

                return prev;
            }


            if (slow == null)
            {
                return head;
            }

            while (slow.next != null && slow != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            //Store the next pointer in temp node
            ListNode temp = fast.next;

            //this will make the fast node as head
            fast.next = null;

            //this will point to last node with first node
            slow.next = head;

            //Assign the temp to head node
            head = temp;

            return head;
        }
    }
}
