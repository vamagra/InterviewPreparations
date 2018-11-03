using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ConnectsNodesAtSameLevel_CTCI
    {
        /// <summary>
        // Given a binary tree
        //        struct TreeLinkNode
        //        {
        //            TreeLinkNode* left;
        //            TreeLinkNode* right;
        //            TreeLinkNode* next;
        //        }
        //        Populate each next pointer to point to its next right node.If there is no next right node, the next pointer should be set to NULL.

        //       Initially, all next pointers are set to NULL.

        //       Note:

        //You may only use constant extra space.
        //Recursive approach is fine, implicit stack space does not count as extra space for this problem.
        //You may assume that it is a perfect binary tree (ie, all leaves are at the same level, and every parent has two children).
        //Example:

        //Given the following perfect binary tree,

        //     1
        //   /  \
        //  2    3
        // / \  / \
        //4  5  6  7
        //After calling your function, the tree should look like:

        //     1 -> NULL
        //   /  \
        //  2 -> 3 -> NULL
        // / \  / \
        //4->5->6->7 -> NULL
        //  </summary>
        //  <param name="node"></param>
        public static void connectNodesAtSameLevelBinaryTreeDFS(TreeNodeNextPointer root)
        {
            if (root == null)
            {
                return;
            }

            Queue<TreeNodeNextPointer> queue = new Queue<TreeNodeNextPointer>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int count = queue.Count;
                TreeNodeNextPointer prev = null;

                for (int i = 0; i < count; i++)
                {
                    TreeNodeNextPointer curr = queue.Dequeue();

                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }

                    if (prev != null)
                    {
                        prev.next = curr;
                    }

                    prev = curr;
                }
            }
        }
    }
}
