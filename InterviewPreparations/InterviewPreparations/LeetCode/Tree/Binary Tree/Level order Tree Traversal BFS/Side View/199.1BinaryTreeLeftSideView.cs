using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreeLeftSideView
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<int> BinaryTreeLeftView(TreeNode root)
        {
            List<int> result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();

            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                int count = queueTree.Count;

                for (int i = 0; i < count; i++)
                {
                    TreeNode tempNode = queueTree.Dequeue();

                    if (i == 0)
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
