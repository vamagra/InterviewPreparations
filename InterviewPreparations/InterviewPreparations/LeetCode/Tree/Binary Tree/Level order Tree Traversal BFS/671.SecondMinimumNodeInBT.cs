using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SecondMinimumNodeInBT
    {
        /// <summary>
        // Given a non-empty special binary tree consisting of nodes with the non-negative value, where each node in this tree has exactly two or zero sub-node. If the node has two sub-nodes, then this node's value is the smaller value among its two sub-nodes.
        // Given such a binary tree, you need to output the second minimum value in the set made of all the nodes' value in the whole tree.
        // If no such second minimum value exists, output -1 instead.
        // Example 1:
        // Input: 
        //    2
        //   / \
        //  2   5
        //     / \
        //    5   7
        // Output: 5
        // Explanation: The smallest value is 2, the second smallest value is 5.
        // Example 2:
        // Input: 
        //   2
        //  / \
        // 2   2
        // Output: -1
        // Explanation: The smallest value is 2, but there isn't any second smallest value.
        // </summary>
        // <param name="root"></param>
        // <returns></returns>
        public static int FindSecondMinimumNodeInBT(TreeNode root)
        {
            int secondMin = int.MaxValue;
            int min = int.MaxValue;

            if (root == null)
            {
                return -1;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();
            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                TreeNode curr = queueTree.Dequeue();

                if (curr.value < min)
                {
                    secondMin = min;
                    min = curr.value;
                }
                else if (curr.value != min && curr.value < secondMin)
                {
                    secondMin = curr.value;
                }

                if (curr.left != null)
                {
                    queueTree.Enqueue(curr.left);
                }

                if (curr.right != null)
                {
                    queueTree.Enqueue(curr.right);
                }
            }

            return secondMin == int.MaxValue ? -1 : secondMin;
        }
    }
}
