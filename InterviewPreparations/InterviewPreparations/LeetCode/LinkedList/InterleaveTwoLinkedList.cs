using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    // Interleave two singly linked lists into one. 
    //  LL1: 1 -> 2 -> 3 -> 4 
    //  LL2: 10 -> 20 -> 30 -> 40 ->50 
    //  Output LL1: 1-> 10 -> 2 -> 20 -> 3 -> 30 -> 4. 
    //  Note: Stop when we hit null for LL1.
    // </summary>
    class InterleaveTwoLinkedList
    {
        public static ListNode Interleave(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1;
            }

            ListNode curr1 = l1;
            ListNode curr2 = l2;

            while (curr1 != null || curr1.next != null)
            {
                ListNode currNext = curr1.next;

                curr1.next = curr2;


            }

            return null;
        }
    }
}
