using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class InOrderPredecessorBST
    {
        /// <summary>
        /// Inorder predecessor for a given key in BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static TreeNode FinPredecessor(TreeNode root, TreeNode p)
        {
            // Ref: Link - https://www.youtube.com/watch?v=rukYFD8cYBY
            if (root == null || p == null)
            {
                return null;
            }

            TreeNode curr = root;
            TreeNode predecessor = null;

            while (curr != null)
            {
                if (curr.value == p.value)
                {
                    break;
                }
                else if (curr.value > p.value)
                {
                    curr = curr.left;
                }
                else
                {
                    predecessor = curr; 
                    curr = curr.right;
                }
            }

            if (curr == null)
            {
                return null;
            }

            // case 1 : when left sub tree is not null
            if (curr.left != null)
            {
                curr = curr.left;

                // find the max element from the left sub tree
                while (curr.right != null)
                {
                    curr = curr.right;
                }

                predecessor = curr;
            }

            return predecessor;

        }
    }
}
