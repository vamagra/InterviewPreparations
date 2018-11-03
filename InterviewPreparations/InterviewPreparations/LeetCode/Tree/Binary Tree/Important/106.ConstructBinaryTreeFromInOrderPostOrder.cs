using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ConstructBinaryTreeFromInOrderPostOrder
    {
        /// <summary>
        // Given inorder and postorder traversal of a tree, construct the binary tree.
        // Note:
        // You may assume that duplicates do not exist in the tree.
        // For example, given
        // inorder = [9, 3, 15, 20, 7]
        // postorder = [9, 15, 7, 20, 3]
        // Return the following binary tree:
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        // </summary>
        // <param name="inorder"></param>
        // <param name="postorder"></param>
        // <returns></returns>
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder.Length == 0)
            {
                return null;
            }

            Stack<TreeNode> stackTree = new Stack<TreeNode>();

            // make a root from last element
            TreeNode root = new TreeNode(postorder[postorder.Length - 1]);
            TreeNode curr = root;

            stackTree.Push(root);

            int po = postorder.Length - 2;
            int io = inorder.Length - 1;

            while (po >= 0)
            {
                if (curr.value != inorder[io])
                {
                    curr.right = new TreeNode(postorder[po]);
                    stackTree.Push(new TreeNode(postorder[po]));
                    po--;
                }
                else
                {
                    while (stackTree.Count != 0 && stackTree.Peek().value == inorder[io])
                    {
                        curr = stackTree.Pop();
                        io--;
                    }

                    curr.left = new TreeNode(postorder[po]);
                    stackTree.Push(new TreeNode(postorder[po]));

                    po--;
                }
            }

            return root;
        }
    }
}
