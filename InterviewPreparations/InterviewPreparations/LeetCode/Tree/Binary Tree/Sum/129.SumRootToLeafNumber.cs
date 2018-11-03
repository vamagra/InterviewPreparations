using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SumRootToLeafNumber
    {
        /// <summary>
        //  Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.
        //  An example is the root-to-leaf path 1->2->3 which represents the number 123.
        //  Find the total sum of all root-to-leaf numbers.
        //  Note: A leaf is a node with no children.
        //  Example:
        //  Input: [1,2,3]
        //    1
        //   / \
        //  2   3
        //  Output: 25
        //  Explanation:
        //  The root-to-leaf path 1->2 represents the number 12.
        //  The root-to-leaf path 1->3 represents the number 13.
        //  Therefore, sum = 12 + 13 = 25.
        //  Example 2:
        //  Input: [4,9,0,5,1]
        //    4
        //   / \
        //  9   0
        // / \
        //5   1
        //  Output: 1026
        //  Explanation:
        //  The root-to-leaf path 4->9->5 represents the number 495.
        //  The root-to-leaf path 4->9->1 represents the number 491.
        //  The root-to-leaf path 4->0 represents the number 40.
        //  Therefore, sum = 495 + 491 + 40 = 1026.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SumRootToLeafPath(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<string> path = new Stack<string>();

            stack.Push(root);
            path.Push(Convert.ToString(root.value));

            int totalSum = 0;

            while (stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                string currPath = path.Pop();

                // base condition, when reach to leaf node
                if (node.left == null || node.right == null)
                {
                    totalSum += Convert.ToInt32(currPath);
                }

                if (node.left != null)
                {
                    path.Push(currPath + Convert.ToString(node.left.value));
                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    path.Push(currPath + Convert.ToString(node.right.value));
                    stack.Push(node.right);
                }
            }

            return totalSum;
        }
    }
}
