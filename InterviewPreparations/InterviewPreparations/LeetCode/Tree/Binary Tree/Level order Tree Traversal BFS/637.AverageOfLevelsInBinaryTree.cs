﻿using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class AverageOfLevelsInBinaryTree
    {
        /// <summary>
        /// Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
        //  Example 1:
        //  Input:
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //Output: [3, 14.5, 11]
        //        Explanation:
        //The average value of nodes on level 0 is 3,  on level 1 is 14.5, and on level 2 is 11. Hence return [3, 14.5, 11].
        //Note:
        //The range of node's value is in the range of 32-bit signed integer.
        //  </summary>
        // <param name="root"></param>
        /// <returns></returns>
        public static IList<double> AverageBinaryTreeLevelOrder(TreeNode root)
        {
            IList<double> resultedList = new List<double>();

            if (root == null)
            {
                return resultedList;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();

            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int count = queueTree.Count;

                int sum = 0;

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queueTree.Dequeue();

                    sum += node.value;

                    if (node.left != null)
                    {
                        queueTree.Enqueue(node.left);
                    }

                    if (node.right!= null)
                    {
                        queueTree.Enqueue(node.right);
                    }
                }

                resultedList.Add(sum / count);
            }

            return resultedList;
        }
    }
}
