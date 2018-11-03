using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class InOrderSuccessorBST_CTCI
    {
        /// <summary>
        /// Given a binary search tree and a node in it, find the in-order successor of that node in the BST.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static TreeNode FindSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null || p == null)
            {
                return null;
            }

            TreeNode succssorNode = null;
            TreeNode curr = root;

            while (curr != null)
            {
                if (curr.value == p.value)
                {
                    break;
                }
                else if (curr.value > p.value)
                {
                    // case 2 - when right sub tree will be null
                    // keep tracking for the last parent node of everytime we travel to left sub tree
                    succssorNode = curr;
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            if (curr == null)
            {
                return null;
            }

            // case 1 when right sub tree is not null
            if (curr.right != null)
            {
                curr = curr.right;
                while (curr.left != null)
                {
                    succssorNode = curr;
                    curr = curr.left;
                }
            }

            return succssorNode;
        }
    }
}
