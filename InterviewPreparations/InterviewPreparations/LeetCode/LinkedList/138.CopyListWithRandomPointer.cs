using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.LinkedList
{
    /// <summary>
    /// A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.
    //  Return a deep copy of the list.
    /// </summary>
    class CopyListWithRandomPointer
    {
        public static RandomList CopyRandomLinkedList(RandomList head)
        {
            if (head == null)
            {
                return null;
            }

            RandomList curr = head, next;

            // Idea is to copy the Special linked list with random pointer
            // 1. Step 1 is to add the current code in between curr and next node
            // 2. Step 2 is to reset the curr node with head node
            // 3. Step 3 now adjust the curr random pointer to copied node random pointer
            // 4. Step 4 is to reset the curr node with head node
            // 5.  

            // Add the first node in between the first and second node
            while (curr != null)
            {
                next = curr.next;
                RandomList copyNode = new RandomList(curr.data);

                curr.next = copyNode;
                copyNode.next = next;

                curr = next;
            }

            // reset the curr node to first node here
            curr = head;

            //adjust the random pointers
            while (curr != null)
            {
                if (curr.random != null)
                {
                    curr.next.random = curr.random.next;
                }

                curr = curr.next.next;
            }

            //reset the curr node to first node here
            curr = head;

            //Detach the list now
            RandomList resultHead = new RandomList(0);

            RandomList copy, copyIter = resultHead;

            while (curr != null)
            {
                // store the original next pointer which is curr->next->next in next pointer
                next = curr.next.next;

                //Extract the copy of Node
                copy = curr.next;

                copyIter.next = copy;
                copyIter = copy;

                //Restore the original List
                curr.next = next;

                //move the curr pointer
                curr = next;
            }

            return resultHead.next;
        }
    }

    public class RandomList
    {
        public int data;
        public RandomList next, random;
        public RandomList(int x)
        {
            data = x;
        }
    }
}
