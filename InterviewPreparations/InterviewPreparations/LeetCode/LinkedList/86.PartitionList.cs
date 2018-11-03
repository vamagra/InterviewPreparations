using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PartitionList
    {
        /// <summary>
        /// Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
        //  You should preserve the original relative order of the nodes in each of the two partitions.
        //  For example,
        //  Given 1->4->3->2->5->2 and x = 3,
        //  return 1->2->2->4->3->5.
        //  </summary>
        //  <param name="head"></param>
        //  <param name="x"></param>
        //  <returns></returns>
        public static ListNode Partition(ListNode head, int x)
        {
            if (head == null || x == 0)
            {
                return head;
            }

            ListNode dummy1 = new ListNode(0);
            ListNode dummy2 = new ListNode(0);

            ListNode curr1 = dummy1;
            ListNode curr2 = dummy2;

            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val <= x)
                {
                    curr1.next = curr;
                    curr1 = curr;
                }
                else
                {
                    curr2.next = curr;
                    curr2 = curr;
                }
                curr = curr.next;
            }

            curr2.next = null;

            //here dummy2 next is head of second list
            curr1.next = dummy2.next;

            //here dummy1.next is head of first list
            return dummy1.next;
        }
    }
}
