using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class InvertBinaryTreeClass
    {
        /// <summary>
        /// Invert a binary tree.
        //     4
        //   /   \
        //  2     7
        // / \   / \
        //1   3 6   9
        //  to
        //     4
        //   /   \
        //  7     2
        // / \   / \
        //9   6 3   1
        // </summary>
        // <param name="root"></param>
        /// <returns></returns>
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            Queue<TreeNode> queueTree = new Queue<TreeNode>();
            queueTree.Enqueue(root);

            while (queueTree.Count != 0)
            {
                TreeNode node = queueTree.Dequeue();

                //Idea is to just swap the nodes of left and right of root tree node
                TreeNode temp = node.left;
                node.left = node.right;
                node.right = temp;

                if (node.left != null)
                {
                    queueTree.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queueTree.Enqueue(node.right);
                }
            }

            return root;
        }
    }
}
