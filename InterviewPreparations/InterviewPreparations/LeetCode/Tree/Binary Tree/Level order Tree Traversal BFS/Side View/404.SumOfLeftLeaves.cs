using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SumOfLeftLeaves
    {
        /// <summary>        
        //  Example:
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        /// Example
        //There are two left leaves in the binary tree, with values 9 and 15 respectively.Return 24.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        /// 
        public int LeftLeavesTotalSumIterativeQueue(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int leftLeavesSum = 0;

            while (queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();

                if (curr.left != null && curr.left.left == null && curr.left.right == null)
                {
                    leftLeavesSum += curr.left.value;
                }

                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }

                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }

            return leftLeavesSum;
        }

        public static int LeftLeavesTotalSumIterativeStack(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftSum = 0;

            Stack<TreeNode> stackTree = new Stack<TreeNode>();
            stackTree.Push(root);

            while (stackTree.Count != 0)
            {
                TreeNode node = stackTree.Pop();

                if (node.left != null && node.left.left == null && node.left.right == null)
                {
                    leftSum += node.left.value;
                }

                if (node.right != null)
                {
                    stackTree.Push(node.right);
                }

                if (node.left != null)
                {
                    stackTree.Push(node.left);
                }
            }

            return leftSum;
        }
        public static int sumOfLeftLeavesRecursive(TreeNode root)
        {
            return sumOfLeftLeavesHelper(root, false);
        }

        public static int sumOfLeftLeavesHelper(TreeNode root, bool b)
        {
            if (root == null) return 0;

            if (root.left == null && root.right == null)
            {
                if (b) return root.value;
                else return 0;
            }
            return sumOfLeftLeavesHelper(root.left, true) + sumOfLeftLeavesHelper(root.right, false);
        }

        
    }
}
