using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Given a singly linked list, determine if it is a palindrome.
    //  Follow up:Could you do it in O(n) time and O(1) space?
    /// </summary>
    class PalindromeLinkedListClass
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }

            //Get the middle of List
            //ListNode middle = GetMiddle(head);

            ListNode slow = head;
            ListNode fast = head;

            //To Handle the Even List 
            ListNode prev_slow = head;

            while (fast != null && fast.next != null)
            {
                //assign the slow pointer before moving to next
                prev_slow = slow;

                slow = slow.next;
                fast = fast.next.next;
            }

            //Becasue fast pointer is moving two node ahead, so it will become Null for Even List
            //while not null for Odd list

            //if the input list is odd list
            //only when fast pointer is not null, move the slow point to one node ahead
            //if (fast != null)
            //{
            //    slow = slow.next;
            //}

            //Set head of next list
            ListNode secondListHead = slow;

            //set null for first half of list
            prev_slow.next = null;

            //Reverse the second List
            secondListHead = ReverseList(secondListHead);

            //Compare Both the List
            return CompareList(head, secondListHead);
        }

        private static ListNode ReverseList(ListNode head)
        {
            ListNode next = head;
            ListNode curr = head;
            ListNode previous = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = previous;

                previous = curr;
                curr = next;
            }

            return previous;
        }

        private static bool CompareList(ListNode curr1, ListNode curr2)
        {
            while (curr1 != null && curr2 != null)
            {
                if (curr1.val != curr2.val)
                {
                    return false;
                }

                curr1 = curr1.next;
                curr2 = curr2.next;
            }

            return true;
        }
    }
}
