using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.Tree;
namespace InterviewQuestions.LeetCode
{
    //Ask Prakash about reversal output
    class BinaryTreeLevelOrderTraversalII
    {
        /// <summary>
        /// Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
        //  For example:
        //  Given binary tree[3, 9, 20, null, null, 15, 7],
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //  return its bottom-up level order traversal as:
        //[
        //  [15,7],
        //  [9,20],
        //  [3]
        //]
        //  </summary>
        // <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrderBottomUp(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            IList<IList<int>> resultedList = new List<IList<int>>();
            List<int> list = null;

            Queue<TreeNode> queueTree = new Queue<TreeNode>();

            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int count = queueTree.Count;
                list = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    TreeNode tempNode = queueTree.Dequeue();

                    list.Add(tempNode.value);

                    if (tempNode.left != null)
                    {
                        queueTree.Enqueue(tempNode.left);
                    }

                    if (tempNode.right != null)
                    {
                        queueTree.Enqueue(tempNode.right);
                    }
                }

                //this is the key difference between Top Level Order Traversal and Bottom Level Order Traversal
                resultedList.Insert(0, list);
            }

            return resultedList;
        }
    }
}
