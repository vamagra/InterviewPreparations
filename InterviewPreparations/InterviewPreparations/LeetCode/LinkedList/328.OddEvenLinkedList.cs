﻿using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class OddEvenLinkedList
    {
        /// <summary>
        /// Given a singly linked list, group all odd nodes together followed by the even nodes. Please note here we are talking about the node number and not the value in the nodes.
        //  You should try to do it in place.The program should run in O(1) space complexity and O(nodes) time complexity.
        //  Example:
        //  Given 1->2->3->4->5->NULL,
        //  return 1->3->5->2->4->NULL.
        //  Note:
        //  The relative order inside both the even and odd groups should remain as it was in the input. 
        //  The first node is considered odd, the second node even and so on...
        //  </summary>
        //  <param name="head"></param>
        /// <returns></returns>
        public static ListNode MakeOddEvenLinkedList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode odd = head;
            ListNode even = head.next;

            //Save this even pointer to connect the odd and even list at the end
            ListNode evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = odd.next.next;
                even.next = even.next.next;

                odd = odd.next;
                even = even.next;
            }

            odd.next = evenHead;

            return head;
        }
    }
}
