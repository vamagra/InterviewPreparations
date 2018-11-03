using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LinkedListClass
{
    public class LinkedList
    {
        //public ListNode head;

        ///// <summary>
        ///// Add Newnode in the list
        ///// </summary>
        ///// <param name="data"></param>
        ////public void AddNode(int data)
        ////{
        ////    //if this is the first node in the list
        ////    if (head == null)
        ////    {
        ////        head = new ListNode();
        ////        head.val = data;
        ////        head.next = null;
        ////    }
        ////    else
        ////    {
        ////        ListNode newNode = new ListNode();
        ////        newNode.val = data;

        ////        ListNode currentNode = head;

        ////        while(currentNode.next!=null)
        ////        {
        ////            currentNode = currentNode.next;
        ////        }

        ////        currentNode.next = newNode;
        ////    }
        ////}

        ///// <summary>
        ///// Add Node in the Begining
        ///// </summary>
        ///// <param name="data"></param>
        //public void AddNodeAtFirst(int data)
        //{
        //    ListNode newNode = new ListNode();
        //    newNode.val = data;

        //    newNode.next = head;
        //    head = newNode;
        //}

        ///// <summary>
        ///// Print the Linked List Nodes
        ///// </summary>
        //public void PrintLinkedListNodes()
        //{
        //    ListNode currentNode = head;

        //    while (currentNode != null)
        //    {
        //        Console.Write(currentNode.val + "->");
        //        currentNode = currentNode.next;
        //    }

        //    Console.ReadKey();
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int value)
        {
            this.val = value;
        }
    }
}
