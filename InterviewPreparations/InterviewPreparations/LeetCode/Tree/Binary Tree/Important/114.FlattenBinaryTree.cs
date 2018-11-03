using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FlattenBinaryTree
    {
        /// <summary>
        /// Given a binary tree, flatten it to a linked list in-place.
        //        For example,
        //        Given

        //         1
        //        / \
        //       2   5
        //      / \   \
        //     3   4   6
        //The flattened tree should look like:
        //   1
        //    \
        //     2
        //      \
        //       3
        //        \
        //         4
        //          \
        //           5
        //            \
        //             6
        // </summary>
        /// <param name="root"></param>
        public static void FlattenTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stackTree = new Stack<TreeNode>();
            stackTree.Push(root);

            while (stackTree.Count != 0)
            {
                TreeNode curr = stackTree.Pop();

                if (curr.right != null)
                {
                    stackTree.Push(curr.right);
                }

                if (curr.left != null)
                {
                    stackTree.Push(curr.left);
                }

                // if stack has some node, then attach the nodes on the right tree
                if (stackTree.Count != 0)
                {
                    curr.right = stackTree.Peek();
                }

                // make the left of the curr tree node to null
                curr.left = null;
            }
        }
    }
}
