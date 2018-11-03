using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.LinkedListClass;
namespace InterviewQuestions.LeetCode
{
    public class Add_Two_Numbers_Linked_List_CTCI
    {
        /// <summary>
        /// You are given two non-empty linked lists representing two non-negative integers. 
        /// The digits are stored in reverse order and each of their nodes contain a single digit. 
        /// Add the two numbers and return it as a linked list.
        //  You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        //  Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //  Output: 7 -> 0 -> 8
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumersLinkedList(ListNode first, ListNode second)
        {
            int resultedSum = 0;
            int carry = 0;

            ListNode head = null;
            ListNode newNode = null;
            ListNode prevNode = null;

            while (first != null || second != null)
            {
                resultedSum = carry + (first != null ? first.val : 0) + (second != null ? second.val : 0);

                //set the carry value
                carry = (resultedSum >= 10) ? 1 : 0;

                //set the carry if sum is greater than 10
                if (resultedSum >= 10)
                {
                    // reduced the resulted sum value
                    resultedSum = resultedSum % 10;
                }

                newNode = new ListNode(resultedSum);

                // Add the node in final Linked list
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    prevNode.next = newNode;
                }

                // make prev node as new node now
                prevNode = newNode;

                if (first != null)
                {
                    first = first.next;
                }

                if (second != null)
                {
                    second = second.next;
                }
            }


            if (carry > 0)
            {
                newNode = new ListNode(carry);
                prevNode.next = newNode;
            }

            return head;
        }
    }
}
