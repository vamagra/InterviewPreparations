using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class PlusOneLinkedList
    {
        /// <summary>
        /// Given a non-negative number represented as a singly linked list of digits, plus one to the number.
        //  The digits are stored such that the most significant digit is at the head of the list.
        //  Example:
        //  Input:
        //  1->2->3
        //  Output:
        //  1->2->4
        //  </summary>
        //  <param name="head"></param>
        //  <returns></returns>

        public ListNode plusOne(ListNode head)
        {
            ListNode h2 = reverse(head);
            ListNode p = h2;

            while (p != null)
            {
                if (p.val + 1 <= 9)
                {
                    p.val = p.val + 1;
                    break;
                }
                else
                {
                    p.val = 0;
                    if (p.next == null)
                    {
                        p.next = new ListNode(1);
                        break;
                    }
                    p = p.next;
                }
            }

            return reverse(h2);
        }

        private ListNode reverse(ListNode head)
        {
            throw new NotImplementedException();
        }
    }
}
