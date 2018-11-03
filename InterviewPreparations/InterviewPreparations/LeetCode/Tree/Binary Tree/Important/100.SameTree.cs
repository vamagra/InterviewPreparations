using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.Tree;
namespace InterviewQuestions.LeetCode
{
    class SameTree
    {
        /// <summary>
        /// Given two binary trees, write a function to check if they are equal or not.
        //  Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
        /// </summary>
        /// <param name="leftTree"></param>
        /// <param name="rightTree"></param>
        /// <returns></returns>
                
        public static bool IsIdenticalBinaryTreeIterative(TreeNode leftRoot, TreeNode rightRoot)
        {
            //Initialize Two Stack for Trees
            Stack<TreeNode> leftTreeStack = new Stack<TreeNode>();
            Stack<TreeNode> rightTreeStack = new Stack<TreeNode>();

            //Add the first node from Trees to stack if they are not null
            if (leftRoot != null)
            {
                leftTreeStack.Push(leftRoot);
            }

            if (rightRoot != null)
            {
                rightTreeStack.Push(rightRoot);
            }

            //Run loop on both stacks
            while (leftTreeStack.Count != 0 && rightTreeStack.Count != 0)
            {
                //Pop the latest tree node from stacks
                TreeNode leftTreeRoot = leftTreeStack.Pop();
                TreeNode rightTreeRoot = rightTreeStack.Pop();

                //if they are not matching, return false
                if (leftTreeRoot.value != rightTreeRoot.value)
                {
                    return false;
                }

                // Add left node of both tree and check the count
                if (leftTreeRoot.left != null)
                {
                    leftTreeStack.Push(leftTreeRoot.left);
                }

                if (rightTreeRoot.left != null)
                {
                    rightTreeStack.Push(rightTreeRoot.left);
                }

                if (leftTreeStack.Count != rightTreeStack.Count)
                {
                    return false;
                }

                // Add right node of both tree and check the count
                if (leftTreeRoot.right != null)
                {
                    leftTreeStack.Push(leftTreeRoot.right);
                }

                if (rightTreeRoot.right != null)
                {
                    rightTreeStack.Push(rightTreeRoot.right);
                }

                // check for the count after adding right node in both the left and right tree
                if (leftTreeStack.Count != rightTreeStack.Count)
                {
                    return false;
                }
            }

            return leftTreeStack.Count == rightTreeStack.Count;
        }

        public static bool IsIdenticalBinaryTreeRecursiveBFS(TreeNode leftTree, TreeNode rightTree)
        {
            if (leftTree == null && rightTree == null)
            {
                return true;
            }
            else if (leftTree == null || rightTree == null)
            {
                return false;
            }

            if ((leftTree.value == rightTree.value) && (IsIdenticalBinaryTreeRecursiveBFS(leftTree.left, rightTree.left))
                    && (IsIdenticalBinaryTreeRecursiveBFS(leftTree.right, rightTree.right)))
            {
                return true;
            }

            return false;
        }
    }
}
