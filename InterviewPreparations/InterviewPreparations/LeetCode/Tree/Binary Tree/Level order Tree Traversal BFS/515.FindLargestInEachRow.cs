using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FindLargestInEachRow
    {
        /// <summary>
        /// You need to find the largest value in each row of a binary tree.
        //  Example:
        //  Input: 
        //          1
        //         / \
        //        3   2
        //       / \   \  
        //      5   3   9 
        //  Output: [1, 3, 9]
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static IList<int> FindMaxEachRowTree(TreeNode root)
        {
            IList<int> list = new List<int>();

            if (root == null)
            {
                return list;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();

            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int size = queueTree.Count;
                int max = int.MinValue;

                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queueTree.Dequeue();

                    if (temp.value > max)
                    {
                        max = temp.value;
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

                list.Add(max);
            }

            return list;
        }
    }
}
