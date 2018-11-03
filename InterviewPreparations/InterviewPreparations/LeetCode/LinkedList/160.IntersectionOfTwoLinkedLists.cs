using InterviewQuestions.LinkedListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class IntersectionOfTwoLinkedLists
    {
        /// <summary>
        /// Write a program to find the node at which the intersection of two singly linked lists begins.
        //        For example, the following two linked lists:

        //A:          a1 → a2
        //                   ↘
        //                     c1 → c2 → c3
        //                   ↗            
        //B:     b1 → b2 → b3
        //begin to intersect at node c1.

        //Notes:

        //If the two linked lists have no intersection at all, return null.
        //The linked lists must retain their original structure after the function returns.
        //You may assume there are no cycles anywhere in the entire linked structure.
        //Your code should preferably run in O(n) time and use only O(1) memory.
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>
        /// 

        #region Solution
        //        Procedure:

        // X=4 Y=8
        // When pointer X in shorter list reaches the end, pointer Y in the longer list will have len(longer) - len(shorter) left. 4 left in Y
        // Put pointer X to the head of the longer list, then when Y reaches its end, X already traveled len(longer)-len(shorter). Then put Y to the head of shorter list.
        // X = 1 in Y List 

        // Now X and Y have the same distance to the end:
        //1). If has intersection, intersection is the first node where X = Y
        //2). If no intersection, termination case is X = Y = null, where they reach end together(as X, Y have the same distance to end)

        //Runtime complexity = O(m + n)

        //m = len(longer), n = len(shorter):

        //step 1: uses m time
        //step 2: uses n time
        #endregion

        public static ListNode GetIntersectionTwoList(ListNode head1, ListNode head2)
        {
            ListNode p1 = head1;
            ListNode p2 = head2;

            if (p1 == null || p2 == null)
            {
                return null;
            }

            while (p1 != p2)
            {
                p1 = p1 == null ? head2 : p1.next;
                p2 = p2 == null ? head1 : p2.next;

                //p1 = p1.next;
                //p2 = p2.next;

                //if (p1 == p2)
                //{
                //    return p1;
                //}

                //if (p1 == null)
                //{
                //    p1 = head2;
                //}

                //if (p2 == null)
                //{
                //    p2 = head1;
                //}
            }

            return p1;
        }
    }
}
