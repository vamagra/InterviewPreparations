using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.LinkedListClass;
namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Merge two sorted linked lists and return it as a new list. 
    /// The new list should be made by splicing together the nodes of the first two lists.
    /// </summary>
    class MergeTwoSortedLists
    {
        public static ListNode MergeTwoSortedLinkedLists(ListNode firstListHeadNode, ListNode secondListHeadNode)
        {
            ListNode head = null;
            ListNode tail = null;

            if (firstListHeadNode == null && secondListHeadNode == null)
            {
                return null;
            }

            if (firstListHeadNode == null)
            {
                return secondListHeadNode;
            }

            if (secondListHeadNode== null)
            {
                return firstListHeadNode;
            }

            while (firstListHeadNode != null && secondListHeadNode != null)
            {
                if (firstListHeadNode.val >= secondListHeadNode.val)
                {
                    if (head == null)
                    {
                        head = secondListHeadNode;
                        tail = head;
                    }
                    else
                    {
                        tail.next = secondListHeadNode;
                        tail = tail.next;
                    }
                    secondListHeadNode = secondListHeadNode.next;
                }
                else if (firstListHeadNode.val <= secondListHeadNode.val)
                {
                    if (head == null)
                    {
                        head = firstListHeadNode;
                        tail = head;
                    }
                    else
                    {
                        tail.next = firstListHeadNode;
                        tail = tail.next;
                    }
                    firstListHeadNode = firstListHeadNode.next;
                }
            }

            while (firstListHeadNode != null)
            {
                tail.next = firstListHeadNode;
                tail = tail.next;
                firstListHeadNode = firstListHeadNode.next;
            }

            while (secondListHeadNode != null)
            {
                tail.next = secondListHeadNode;
                tail = tail.next;
                secondListHeadNode = secondListHeadNode.next;
            }

            return head;
        }
    }
}
