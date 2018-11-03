using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreeLevelOrderTraversalI
    {
        /// <summary>
        /// Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
        //        For example:
        //Given binary tree[3, 9, 20, null, null, 15, 7],
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //return its level order traversal as:
        //[
        //  [3],
        //  [9,20],
        //  [15,7]
        //]
        // </summary>
        // <param name="root"></param>
        // <returns></returns>
        public static IList<IList<int>> BinaryTreeLevelOrder(TreeNode root)
        {
            IList<IList<int>> resultList = new List<IList<int>>();

            if (root == null)
            {
                return resultList;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();
            List<int> level = null;

            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int count = queueTree.Count;
                level = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queueTree.Dequeue();

                    level.Add(node.value);

                    if (node.left != null)
                    {
                        queueTree.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queueTree.Enqueue(node.right);
                    }
                }

                resultList.Add(level);
            }

            return resultList;
        }
    }
}
