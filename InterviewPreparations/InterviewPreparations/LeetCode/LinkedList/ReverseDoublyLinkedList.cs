using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// REF : http://algorithms.tutorialhorizon.com/reverse-the-doubly-linked-list/
    /// </summary>
    class ReverseDoublyLinkedList
    {
        public static DoublyNode head = null;
        public static DoublyNode tail = null;
        public static int size = 0;

        public static void AddNodeDLL(int data)
        {
            DoublyNode newNode = new DoublyNode(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                head.prev = newNode;
                newNode.next = head;
                head = newNode;
            }

            size++;
        }

        public static void Print(DoublyNode node)
        {
            DoublyNode curr = node;

            while (curr != null)
            {
                Console.Write("-> " + curr.data);
                curr = curr.next;
            }
        }

        public static DoublyNode ReverseDLL(DoublyNode head)
        {
            DoublyNode curr = head;
            DoublyNode prev = null;

            while (curr != null)
            {
                prev = curr.prev;
                curr.prev = curr.next;
                curr.next = prev;
                curr = curr.prev;
            }

            return prev.prev;
        } 
    }

    public class DoublyNode
    {
        public int data;
        public DoublyNode next;
        public DoublyNode prev;

        public DoublyNode(int x)
        {
            data = x;
            this.next = null;
            this.prev = null;
        }
    }
}
