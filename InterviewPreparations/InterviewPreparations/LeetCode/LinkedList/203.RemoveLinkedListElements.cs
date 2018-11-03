using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.LinkedListClass;

namespace InterviewQuestions.LeetCode
{
    class RemoveLinkedListElements
    {
        /// <summary>
        /// Remove all elements from a linked list of integers that have value val.
        //  Example
        //  Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
        //  Return: 1 --> 2 --> 3 --> 4 --> 5
        /// </summary>
        /// <param name="head"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ListNode RemoveNode(ListNode head, int target)
        {
            ListNode current = head;
            ListNode prev = head;

            while (current != null)
            {
                if (head.val == target)
                {
                    current = current.next;
                    head = current;
                    continue;
                }

                if (current.val == target)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = current;
                }

                current = current.next;
            }

            return head;
        }
    }
}
