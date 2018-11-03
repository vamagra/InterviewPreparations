using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class DeleteNodeLinkedList
    {
        /// <summary>
        /// Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.
        //  Supposed the linked list is 1 -> 2 -> 3 -> 4 and you are given the third node with value 3, the linked list should become 1 -> 2 -> 4 after calling your function.
        /// </summary>
        /// <param name="node"></param>
        public static void DeleleNode(ListNode node)
        {
            if (node == null)
            {
                return;
            }

            ListNode next = node.next;
            node.val = next.val;
            node.next = next.next;
        }

    }
}
