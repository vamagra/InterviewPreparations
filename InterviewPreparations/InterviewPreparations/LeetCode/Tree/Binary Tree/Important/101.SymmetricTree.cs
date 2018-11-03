using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.Tree;
namespace InterviewQuestions.LeetCode
{
    class SymmetricTree
    {
        /// <summary>
        //  Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
        //  For example, this binary tree[1, 2, 2, 3, 4, 4, 3] is symmetric:

        //     1
        //    /  \
        //   2    2
        //  / \  / \
        // 3   4 4  3

        // But the following[1, 2, 2, null, 3, null, 3] is not:
        //    1
        //   / \
        //  2   2
        //   \   \
        //   3    3
        // Note:
        // Bonus points if you could solve it both recursively and iteratively.
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        //  
        public static bool IsSymmetricBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            //return IsSymmetricRecursiveMethod(root, root);

            TreeNode leftTreeNode = null;
            TreeNode rightTreeNode = null;

            if (root.left != null)
            {
                leftTreeNode = root.left;
            }

            if (root.right != null)
            {
                rightTreeNode = root.right;
            }

            if (leftTreeNode != null && rightTreeNode != null)
            {
                return IsSymmetricIterativeMethod(leftTreeNode, rightTreeNode);
            }

            return false;
        }

        public static bool IsSymmetricIterativeMethod(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            Stack<TreeNode> leftStackTree = new Stack<TreeNode>();
            Stack<TreeNode> rightStackTree = new Stack<TreeNode>();

            if (left != null)
            {
                leftStackTree.Push(left);
            }

            if (right != null)
            {
                rightStackTree.Push(right);
            }

            while (leftStackTree.Count != 0 && rightStackTree.Count != 0)
            {
                TreeNode leftNode = leftStackTree.Pop();
                TreeNode rightNode = rightStackTree.Pop();

                if (leftNode.value != rightNode.value)
                {
                    return false;
                }

                if (leftNode.left != null)
                {
                    leftStackTree.Push(leftNode.left);
                }

                if (rightNode.right != null)
                {
                    rightStackTree.Push(rightNode.right);
                }

                if (leftNode.left != null && rightNode.right != null && leftNode.left.value != rightNode.right.value)
                {
                    return false;
                }

                if (leftNode.right != null)
                {
                    leftStackTree.Push(leftNode.right);
                }

                if (rightNode.left != null)
                {
                    rightStackTree.Push(rightNode.left);
                }

                if (leftNode.right != null && rightNode.left != null &&  leftNode.right.value != rightNode.left.value)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsSymmetricRecursiveMethod(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }
            else if (t1 == null || t2 == null)
            {
                return false;
            }

            return t1.value == t2.value && IsSymmetricRecursiveMethod(t1.left, t2.right) && IsSymmetricRecursiveMethod(t1.right, t2.left);
        }
    }
}
