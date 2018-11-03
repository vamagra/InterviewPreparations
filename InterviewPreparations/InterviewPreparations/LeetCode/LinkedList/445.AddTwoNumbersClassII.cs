using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class AddTwoNumbersClassII
    {
        /// <summary>
        //  You are given two non-empty linked lists representing two non-negative integers. 
        //  The most significant digit comes first and each of their nodes contain a single digit. 
        //  Add the two numbers and return it as a linked list.
        //  You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        //  Follow up:
        //  What if you cannot modify the input lists? In other words, reversing the lists is not allowed.
        //  Example:
        //  Input: (7 -> 2 -> 4 -> 3) + (5 -> 6 -> 4)
        //  Output: 7 -> 8 -> 0 -> 7
        // </summary>
        // <param name="l1"></param>
        // <param name="l2"></param>
        // <returns></returns>
        public static ListNode AddTwoNumbersII(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();

            //Add First List In Stack1
            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            };

            //Add Second List In Stack2
            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            int sum = 0;
            ListNode newList = new ListNode(0);

            while (s1.Count != 0 || s2.Count != 0)
            {
                //if stack 1 is not empty
                if (s1.Count != 0)
                {
                    sum += s1.Pop();
                }

                //if stack 2 is not empty
                if (s2.Count != 0)
                {
                    sum += s2.Pop();
                }

                newList.val = sum % 10;

                ListNode newNode = new ListNode(sum / 10);

                newNode.next = newList;

                newList = newNode;

                sum /= 10;
            }

            return newList.val == 0 ? newList.next : newList;
        }
    }
}
