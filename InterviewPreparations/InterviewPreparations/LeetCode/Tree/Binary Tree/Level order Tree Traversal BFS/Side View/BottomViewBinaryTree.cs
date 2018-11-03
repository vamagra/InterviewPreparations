using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class BottomViewBinaryTree
    {
        /// <summary>
        /// Given a binary tree, Given a binary tree, print the values of nodes which would be present in         
        /// bottom of view of binary tree. You are not allowed to use level order traversal.
        // Print the node values starting from left-most end.A node will be in the bottom-view if 
        // it is the bottommost node at its horizontal distance from the root. Horizontal distance of root from itself is 0. 
        // Horizontal distance of right child of root node is 1 and horizontal distance of left child of root node is -1.
        // Horizontal distance of node 'n' from root = horizontal distance of its parent from root + 1, if node 'n' is right child of its parent.
        // Horizontal distance of node 'n' from root = horizontal distance of its parent from root - 1, if node 'n' is left child of its parent.
        // If more than one nodes are at the same horizontal distance and are the bottom-most nodes for  that horizontal distance, 
        // then you can choose to include either of the nodes in the bottom view.
        //        example - 
        //            For the following tree:
        //                1
        //        2                3
        //    4        5        6        7
        //        Horizontal distance of 1 = +0
        //Horizontal distance of 2 = -1
        //Horizontal distance of 3 = +1
        //Horizontal distance of 4 = -2
        //Horizontal distance of 5 = +0
        //Horizontal distance of 6 = +0
        //Horizontal distance of 7 = +2    
        //        and the bottom view would be 4, 2, 6, 3, 7.
        //        Please note that though there are three nodes(nodes 1,5,6) with horizontal distance of 0, only node 6 is in bottom view because it is at the bottom-most level of all three nodes.Note that you could have chosen to keep node 5 instead of node 6 in bottom view since it is also at the bottom-most layer.. 
        //        For the following tree:
        //                1
        //           2          3
        //        4    5     6     7
        //          8 9        10    11
        //        Horizontal distance of 1 = +0
        //Horizontal distance of 2 = -1
        //Horizontal distance of 3 = +1
        //Horizontal distance of 4 = -2
        //Horizontal distance of 5 = +0
        //Horizontal distance of 6 = +0
        //Horizontal distance of 7 = +2    
        //Horizontal distance of 8 = -1 (right child of 4)
        //Horizontal distance of 9 = -1 (left child of 5)
        //Horizontal distance of 10 = +1 (right child of 6)
        //Horizontal distance of 11 = +3 (right child of 7)     
        //and the bottom view would be 4, 9, 6, 10, 7, 11
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static List<int> BottomView(TreeNodeVerticalOrder root)
        {
            List<int> result = new List<int>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNodeVerticalOrder> queue = new Queue<TreeNodeVerticalOrder>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            queue.Enqueue(root);

            int minColumnNumber = 0, maxColumnNumber = 0;

            while (queue.Count != 0)
            {
                TreeNodeVerticalOrder curr = queue.Dequeue();
                int col = curr.horizontalDistance;

                map[col]= curr.value;

                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                    curr.left.horizontalDistance = col - 1; ;
                    minColumnNumber = Math.Min(minColumnNumber, col - 1);
                }

                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                    curr.right.horizontalDistance = col + 1;
                    maxColumnNumber = Math.Max(maxColumnNumber, col + 1);
                }
            }

            for (int i = minColumnNumber; i <= maxColumnNumber; i++)
            {
                result.Add(map[i]);
            }

            return result;
        }
    }
}
