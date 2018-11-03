using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ConstructBinaryTreeFromInOrderPreOrder
    {
        /// <summary>
        //  Given preorder and inorder traversal of a tree, construct the binary tree.
        //  Note:
        //  You may assume that duplicates do not exist in the tree.
        //  For example, given
        //  preorder = [3, 9, 20, 15, 7]
        //  inorder = [9, 3, 15, 20, 7]
        //  Return the following binary tree:
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //  </summary>
        //  <param name="inorder"></param>
        //  <param name="preorder"></param>
        //  <returns></returns>
        public static TreeNode BuildTree(int[] inorder, int[] preorder)
        {
            Stack<TreeNode> stackTree = new Stack<TreeNode>();

            if (preorder.Length == 0)
            {
                return null;
            }

            if (preorder.Length == 1)
            {
                return new TreeNode(preorder[0]);
            }

            TreeNode root = new TreeNode(preorder[0]);
            TreeNode curr = root;

            for (int i = 1, j = 0; i < preorder.Length; i++)
            {
                // this condition mean that we are not reached to the middle of the inorder Tree
                // Keep pushing the elements from preorder to Stack and make left node of root untill we found match from inorder

                if (curr.value != inorder[j])
                {
                    // push the node in stack
                    stackTree.Push(curr);

                    //create a left node of the tree from preorder array
                    curr.left = new TreeNode(preorder[i]);

                    //move the curr to left
                    curr = curr.left;
                }
                else
                {
                    j++;

                    // keep poping the element from the stack to remove the left nodes
                    while (stackTree.Count != 0 && stackTree.Peek().value == inorder[j])
                    {
                        curr = stackTree.Pop();
                        j++;
                    }

                    curr.right = new TreeNode(preorder[i]);
                    curr = curr.right;
                }
            }

            return root;
        }
    }
}
