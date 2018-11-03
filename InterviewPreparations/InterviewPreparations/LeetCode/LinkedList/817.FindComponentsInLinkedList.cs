using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FindComponentsInLinkedList
    {
        /// <summary>
        /// We are given head, the head node of a linked list containing unique integer values.
        //  We are also given the list G, a subset of the values in the linked list.
        //  Return the number of connected components in G, where two values are connected if they appear consecutively in the linked list.
        //  Example 1:
        //  Input: 
        //  head: 0->1->2->3
        //  G = [0, 1, 3]
        //  Output: 2
        //  Explanation: 
        //  0 and 1 are connected, so[0, 1] and[3] are the two connected components.
        //  Example 2:
        //  Input: 
        //  head: 0->1->2->3->4
        //  G = [0, 3, 1, 4]
        //  Output: 2
        //  Explanation: 
        //  0 and 1 are connected, 3 and 4 are connected, so[0, 1] and [3, 4] are the two connected components.
        //  Note:
        //  If N is the length of the linked list given by head, 1 <= N <= 10000.
        //  The value of each node in the linked list will be in the range [0, N - 1].
        //  1 <= G.length <= 10000.
        //  G is a subset of all values in the linked list.
        //  </summary>
        //  <param name="head"></param>
        //  <param name="G"></param>
        //  <returns></returns>
        public static int ComponentsInLinkedList(ListNode head, int[] G)
        {
            if (head == null || G == null || G.Length < 1)
            {
                return -1;
            }

            HashSet<int> hashSet = new HashSet<int>();
            int count = 0;

            // Step1 - add the array elements in the Hashset
            foreach (int item in G)
            {
                hashSet.Add(item);
            }

            ListNode curr = head;

            while (curr != null)
            {
                // check if curr node value exist in hashSet
                // if curr next is null means its a last node and its already exists in set OR curr next node is exists in Set increase the count
                if (hashSet.Contains(curr.val) && (curr.next == null || !hashSet.Contains(curr.next.val)))
                {
                    count++;
                }

                curr = curr.next;
            }

            return count;
        }
    }
}
