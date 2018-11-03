using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ConnectNodesAtSameLevelWithoutExtraSpace_CTCI
    {
        /// <summary>
        /// Given a binary tree
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
        //Example:
        //Given the following binary tree,
        //     1
        //   /  \
        //  2    3
        // / \    \
        //4   5    7
        //After calling your function, the tree should look like:

        //     1 -> NULL
        //   /  \
        //  2 -> 3 -> NULL
        // / \    \
        //4-> 5 -> 7 -> NULL

        /// </summary>
        /// <param name="root"></param>
        public static void connectNodesAtSameLevel(TreeNodeNextPointer root)
        {
            if (root == null)
            {
                return;
            }

            TreeNodeNextPointer curr = root;
            TreeNodeNextPointer prev = root;

            while (prev.left != null)
            {
                // here curr is top level node, which will help to connect next level left 
                // to connect to next level right like 

                curr = prev;

                while (curr.next != null)
                {
                    //    1  - here curr is 1 ( when loop is running on first iteration)
                    //  2  3 -
                    // 4 5 6 7

                    // curr -> 2
                    // curr.left -> 4 connecting nex to right
                    // curr.right -> 5 (connecting 4 -> 5)
                    curr.left.next = curr.right;

                    // now connect 5 -> 6 
                    // curr.right -> 5 
                    // curr -> 2
                    // curr.next -> 3 (we have already connected 2 -> 3 in previous level)
                    // curr.next.left = 6 (below line will connecr 5 -> 6) 
                    curr.right.next = curr.next.left;

                    // now curr will move to 3
                    curr = curr.next;
                }

                //    1  - here curr is 1 ( when loop is running on first iteration)
                //  2  3 -

                //curr -> 1
                // curr.left -> 2 connecting next to right
                // curr.right -> 3 (connecting 2->3)
                curr.left.next = curr.right;

                // move to next level start
                prev = prev.left;
            }
        }
    }
}
