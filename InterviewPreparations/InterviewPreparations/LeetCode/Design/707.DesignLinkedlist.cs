using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    // Design your implementation of the linked list. You can choose to use the singly linked list or the doubly linked list. A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and next is a pointer/reference to the next node. If you want to use the doubly linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.
    // Implement these functions in your linked list class:
    // get(index) : Get the value of the index-th node in the linked list.If the index is invalid, return -1.
    //  addAtHead(val) : Add a node of value val before the first element of the linked list.After the insertion, the new node will be the first node of the linked list.
    //  addAtTail(val) : Append a node of value val to the last element of the linked list.
    //  addAtIndex(index, val) : Add a node of value val before the index-th node in the linked list.If index equals to the length of linked list, the node will be appended to the end of linked list.If index is greater than the length, the node will not be inserted.
    //  deleteAtIndex(index) : Delete the index-th node in the linked list, if the index is valid.
    //  Example:
    //  MyLinkedList linkedList = new MyLinkedList();
    //  linkedList.addAtHead(1);
    //  linkedList.addAtTail(3);
    //  linkedList.addAtIndex(1, 2);  // linked list becomes 1->2->3
    //  linkedList.get(1);            // returns 2
    //  linkedList.deleteAtIndex(1);  // now the linked list is 1->3
    //  linkedList.get(1);            // returns 3
    //  Note:
    //  All values will be in the range of[1, 1000].
    //  The number of operations will be in the range of[1, 1000].
    //  Please do not use the built-in LinkedList library.
    //  </summary>
    public class MyLinkedList
    {
        LinkedListNode head = null;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || head == null)
            {
                return -1;
            }

            if (index == 0 && head != null)
            {
                return head.val;
            }

            LinkedListNode curr = head;

            int counter = 0;

            while (curr.next != null && counter != index)
            {
                curr = curr.next;
                counter++;
            }

            return counter == index ? curr.val : -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            LinkedListNode newNode = new LinkedListNode(val);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            LinkedListNode newNode = new LinkedListNode(val);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (head.next != null)
                {
                    head = head.next;
                }
                head.next = newNode;
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            LinkedListNode newNode = new LinkedListNode(val);

            if (index < 0)
            {
                return;
            }

            if (head == null)
            {
                if (index > 0)
                {
                    return;
                }

                head = newNode;
            }
            else
            {
                LinkedListNode prev = null;
                LinkedListNode curr = head;
                int counter = 0;
                while (curr != null && counter != index)
                {
                    prev = curr;
                    curr = curr.next;
                    counter++;
                }

                prev.next = newNode;
                newNode.next = curr;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (head == null)
            {
                return;
            }
            else
            {
                if (index == 0)
                {
                    head = head.next;
                    return;
                }

                LinkedListNode prev = null;
                LinkedListNode curr = head;

                int counter = 0;
                while (curr.next != null && counter != index)
                {
                    prev = curr;
                    curr = curr.next;
                    counter++;
                }

                if (prev != null && prev.next != null)
                {
                    prev.next = curr.next;
                }
            }
        }
    }

    class LinkedListNode
    {
        public int val;
        public LinkedListNode next;

        public LinkedListNode(int data)
        {
            val = data;
            next = null;
        }
    }

}
