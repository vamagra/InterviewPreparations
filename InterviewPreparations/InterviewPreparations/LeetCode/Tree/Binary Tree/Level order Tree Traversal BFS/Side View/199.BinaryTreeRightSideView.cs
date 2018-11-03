using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreeRightSideView
    {
        /// <summary>
        /// Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
        //  For example:
        //  Given the following binary tree,
        //   1            <---
        // /   \
        //2     3         <---
        // \     \
        //  5     4       <---
        //  You should return [1, 3, 4].
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static List<int> PrintBinaryTreeRightSideView(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            List<int> result = new List<int>();

            Queue<TreeNode> queueTree = new Queue<TreeNode>();

            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int count = queueTree.Count;

                for (int i = 0; i < count; i++)
                {
                    TreeNode tempNode = queueTree.Dequeue();

                    //Add the last element of the list
                    if (i == count - 1)
                    {
                        result.Add(tempNode.value);
                    }

                    if (tempNode.left != null)
                    {
                        queueTree.Enqueue(tempNode.left);
                    }

                    if (tempNode.right != null)
                    {
                        queueTree.Enqueue(tempNode.right);
                    }
                }
            }

            return result;
        }
    }
}
