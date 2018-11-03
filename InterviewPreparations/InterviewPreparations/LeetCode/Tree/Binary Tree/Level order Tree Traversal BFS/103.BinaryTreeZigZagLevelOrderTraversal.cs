using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreeZigZagLevelOrderTraversal
    {
        /// <summary>
        /// Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).
        //        For example:
        //Given binary tree[3, 9, 20, null, null, 15, 7],
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //return its zigzag level order traversal as:
        //[
        //  [3],
        //  [20,9],
        //  [15,7]
        //]
        //  </summary>
        // <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> BinaryTreeZigZagOrder(TreeNode root)
        {
            IList<IList<int>> resultedList = new List<IList<int>>();

            if (root == null)
            {
                return resultedList;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();
            List<int> level = null;

            queueTree.Enqueue(root);
            bool isZigZag = false;

            while (queueTree.Count != 0)
            {
                int count = queueTree.Count;
                level = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queueTree.Dequeue();

                    if (isZigZag)
                    {
                        level.Insert(0, node.value);
                    }
                    else
                    {
                        level.Add(node.value);
                    }

                    if (node.left != null)
                    {
                        queueTree.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queueTree.Enqueue(node.right);
                    }
                }

                isZigZag = !isZigZag;
                resultedList.Add(level);
            }

            return resultedList;
        }
    }
}
