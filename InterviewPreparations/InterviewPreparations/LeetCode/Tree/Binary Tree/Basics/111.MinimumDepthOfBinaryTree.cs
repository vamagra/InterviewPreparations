using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MinimumDepthOfBinaryTree
    {
        /// <summary>
        /// Given a binary tree, find its minimum depth.
        //  The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MinDepthBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            //below condition is true when we reach to Leaf node
            if (root.left == null && root.right == null)
            {
                return 1;
            }

            int leftMinDepth = root.left != null ? MinDepthBinaryTree(root.left) : int.MaxValue;

            int rightMinDepth = root.right != null ? MinDepthBinaryTree(root.right) : int.MaxValue;

            return leftMinDepth > rightMinDepth ? rightMinDepth + 1 : leftMinDepth + 1;
        }
    }
}
