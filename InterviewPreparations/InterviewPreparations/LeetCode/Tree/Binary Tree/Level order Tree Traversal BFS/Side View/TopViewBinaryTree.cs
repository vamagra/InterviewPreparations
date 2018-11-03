using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class TopViewBinaryTree
    {
        /// <summary>
        //  A node x is there in output if x is the topmost node at its horizontal distance. Horizontal distance of left child of a node x is equal to horizontal distance of x minus 1, and that of right child is horizontal distance of x plus 1.
        //       1
        //    /     \
        //   2       3
        //  /  \    / \
        // 4    5  6   7
        //Top view of the above binary tree is
        //4 2 1 3 7
        //        1
        //      /   \
        //    2       3
        //      \   
        //        4  
        //          \
        //            5
        //             \
        //               6
        // Top view of the above binary tree is
        // 2 1 3 6
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static List<int> TopView(TreeNodeVerticalOrder root)
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

                if(!map.ContainsKey(col))
                {
                    map.Add(col, curr.value);
                }
                
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
