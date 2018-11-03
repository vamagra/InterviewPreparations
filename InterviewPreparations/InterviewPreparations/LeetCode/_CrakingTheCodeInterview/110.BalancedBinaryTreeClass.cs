using InterviewQuestions.Tree;
using InterviewQuestions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BalancedBinaryTreeClass_CTCI
    {
        /// <summary>
        /// Given a binary tree, determine if it is height-balanced.
        //  For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        public static bool checkBalance(TreeNode root)
        {
            if (IsBalancedBinaryTree(root) > 0)
            {
                return true;
            }

            return false;
        }

        public static int IsBalancedBinaryTree(TreeNode root)
        {
            // Step 1 - if curr node is null, treat it as balanced tree and return height 0
            if (root == null)
            {
                return 0;
            }

            // Step 2 - check if left sub tree is height balanced, get the height
            int leftHeight = IsBalancedBinaryTree(root.left);

            // if not balanced return -1
            if (leftHeight == -1)
            {
                return -1;
            }

            // Step 3 - check if right sub tree is height balanced, get the height
            int rightHeight = IsBalancedBinaryTree(root.right);

            // if not balanced return -1
            if (rightHeight == -1)
            {
                return -1;
            }

            // Step 4 - check if the left tree height and right sub tree height difference is
            // greater than 1 then return -1
            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1;
            }

            // Step 5 - else return height of subtree
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public static bool IsBalanced(TreeNode root)
        {
            bool IsResult = false;

            if (root == null)
            {
                return false;
            }

            int lheigth = TreeHeight(root.left);

            int rheigth = TreeHeight(root.right);

            // if the left height of Binary Tree and right height binary tree differnce is less than <=1
            // if left sub tree is Balanced && right sub tree is balanced
            if ((Math.Abs(lheigth - rheigth) <= 1 && IsBalanced(root.left) && IsBalanced(root.right)))
            {
                IsResult = true;
            }

            return IsResult;
        }

        public static int TreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return UtilityHelper.max(TreeHeight(root.left), TreeHeight(root.right)) + 1;
        }
    }
}
