using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FindBottomTreeRight
    {
        /// <summary>
        /// Given a binary tree, find the leftmost value in the last row of the tree.
        //  Example 1:
        //  Input:
        //    2
        //   / \
        //  1   3
        //  Output:
        //  1
        //  Example 2: 
        //  Input:
        //        1
        //       / \
        //      2   3
        //     /   / \
        //    4   5   6
        //             \
        //              9
        //  Output:
        //  9
        //  Note: You may assume the tree(i.e., the given root node) is not NULL.
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static int FindBottomLeftTree(TreeNode root)
        {
            int result = 0;

            if (root == null)
            {
                return -1;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();
            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int size = queueTree.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queueTree.Dequeue();

                    if (i == size - 1)
                    {
                        result = temp.value;
                    }

                    if (temp.left != null)
                    {
                        queueTree.Enqueue(temp.left);
                    }

                    if (temp.right != null)
                    {
                        queueTree.Enqueue(temp.right);
                    }
                }
            }

            return result;
        }
    }
}
