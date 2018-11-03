using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class KthSmallestElementBST
    {
        /// <summary>
        /// Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.
        ///  Note: You may assume k is always valid, 1 ≤ k ≤ BST's total elements.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int KthSmallest(TreeNode root, int k)
        {
            if (root == null)
            {
                return 0;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            
            // Inorder Traversal  
            while (curr != null || stack.Count != 0)
            {
                // kepp moving to the left untill we got the left node in tree and push into the stack
                // beacuse we will get the smallest element in the left node
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                // pop the root element which has smallest element
                curr = stack.Pop();

                //for every loop cycle down the kth element by one
                if (--k == 0)
                {
                    break;
                }

                // move to the right
                curr = curr.right;
            }

            return curr.value;
        }
    }
}
