using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ConvertBSTToGT
    {
        /// <summary>
        // Given a Binary Search Tree (BST), convert it to a Greater Tree such that every key of the original 
        // BST is changed to the original key plus sum of all keys greater than the original key in BST.
        // Example:
        // Input: The root of a Binary Search Tree like this:
        //             5
        //           /   \
        //          2     14
        // Output: The root of a Greater Tree like this:
        //            19
        //           /   \
        //         21     14
        // </summary>
        // <param name="root"></param>
        // <returns></returns>
        public static TreeNode ConvertBinarySearchTreeToGreaterTree(TreeNode root)
        {
            // Its just Reverse Inorder
            if (root == null)
            {
                return null;
            }

            int sum = 0;

            Stack<TreeNode> stackTree = new Stack<TreeNode>();
            TreeNode curr = root;

            while (curr != null || stackTree.Count != 0)
            {
                // Read all the right nodes
                while (curr != null)
                {
                    stackTree.Push(curr);
                    curr = curr.right;
                }

                curr = stackTree.Pop();

                sum += curr.value;
                curr.value = sum;

                curr = curr.left;
            }

            return root;
        }
    }
}
