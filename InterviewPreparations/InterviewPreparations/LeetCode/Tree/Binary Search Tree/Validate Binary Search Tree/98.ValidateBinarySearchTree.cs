using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidateBinarySearchTree
    {
        /// <summary>
        //  Given a binary tree, determine if it is a valid binary search tree (BST).
        //  Assume a BST is defined as follows:
        //  The left subtree of a node contains only nodes with keys less than the node's key.
        //  The right subtree of a node contains only nodes with keys greater than the node's key.
        //  Both the left and right subtrees must also be binary search trees.
        //        Example 1:
        //    2
        //   / \
        //  1   3
        //  Binary tree[2, 1, 3], return true.
        //  Example 2:
        //    1
        //   / \
        //  2   3
        //  Binary tree[1, 2, 3], return false.
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static bool ValidBST(TreeNode root)
        {
            // https://www.youtube.com/watch?v=MILxfAbIhrE
            return CheckBST(root, long.MinValue, long.MaxValue);
        }

        private static bool CheckBST(TreeNode root, long min, long max)
        {
            if (root == null)
            {
                return true;
            }

            // check if root value lies between min and max range, if not return false;
            // use below condition when duplicates are not allowed
            if (root.value <= min || root.value >= max)
            {
                return false;
            }

            // use below condition when duplicates are allowed
            //if (root.value <= min || root.value > max)
            //{
            //    return false;
            //}

            return CheckBST(root.left, min, root.value) && CheckBST(root.right, root.value, max);
        }
    }
}
