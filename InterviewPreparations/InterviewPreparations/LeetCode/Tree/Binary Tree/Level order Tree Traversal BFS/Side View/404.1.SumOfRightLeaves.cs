using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SumOfRightLeaves
    {
        /// <summary>
        //  Example:
        //    3
        //   / \
        //  9    20
        //   \   /  \
        //    5  15   7
        // Example
        // There are two right leaves in the binary tree, with values 5 and 7 respectively.Return 12.
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        //  </summary>
        //  <param name="root"></param>
        // <returns></returns>

        public int GetSumOfRightLeavesQueue(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int rightLeavesSum = 0;

            while (queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();

                if (curr.right!= null && curr.right.right == null && curr.right.left == null)
                {
                    rightLeavesSum += curr.right.value;
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

            return rightLeavesSum;
        }

        public static int GetSumOfRightLeavesStack(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Stack<TreeNode> stackTree = new Stack<TreeNode>();
            int sum = 0;

            stackTree.Push(root);

            while (stackTree.Count != 0)
            {
                TreeNode curr = stackTree.Pop();

                if (curr.right != null && curr.right.left == null && curr.right.right == null)
                {
                    sum += curr.right.value;
                }

                if (curr.right != null)
                {
                    stackTree.Push(curr.right);
                }

                if (curr.left != null)
                {
                    stackTree.Push(curr.left);
                }
            }

            return sum;
        }
    }
}
