using InterviewQuestions.LinkedListClass;
using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ConvertSortedListToBinaryTree
    {
        /// <summary>
        /// Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
        //       For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
        //       Example:
        //       Given the sorted linked list: [-10,-3,0,5,9],
        //       One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:
        //     0
        //    / \
        //  -3   9
        //  /   /
        //-10  5
        // </summary>
        // <param name="head"></param>
        /// <returns></returns>
        public static TreeNode ConvertListToBST(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            TreeNode root = CreateBST(head, null);

            return root;
        }

        private static TreeNode CreateBST(ListNode head, ListNode tail)
        {
            ListNode slow = head;
            ListNode fast = head;

            if (head == tail)
            {
                return null;
            }

            //get the middle node
            while (fast != tail && fast.next != tail)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            TreeNode root = new TreeNode(slow.val);

            root.left = CreateBST(head, slow);
            root.right = CreateBST(slow.next, tail);

            return root;
        }
    }
}
