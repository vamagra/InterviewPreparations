using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class VerticalLevelOrderTraversal
    {
        /// <summary>
        /// Given a binary tree, return the vertical order traversal of its nodes' values. (ie, from top to bottom, column by column).
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        // http://letstalkalgorithms.com/binary-tree-vertical-order-traversal-leetcode/
        // https://www.youtube.com/watch?v=PQKkr036wRc
        public static List<List<int>> verticalOrderTreeTraversalII(TreeNodeVerticalOrder root)
        {
            List<List<int>> result = new List<List<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNodeVerticalOrder> queue = new Queue<TreeNodeVerticalOrder>();
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            queue.Enqueue(root);

            int minColumnNumber = 0, maxColumnNumber = 0;

            while (queue.Count != 0)
            {
                TreeNodeVerticalOrder curr = queue.Dequeue();
                int col = curr.horizontalDistance;

                if (!map.ContainsKey(col))
                {
                    map.Add(col, new List<int>());
                }

                map[col].Add(curr.value);

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

        public static List<List<int>> verticalOrderTreeTraversal(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<int> cols = new Queue<int>();

            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            queue.Enqueue(root);
            cols.Enqueue(0);

            int minColumnNumber = 0, maxColumnNumber = 0;

            while (queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();
                int col = cols.Dequeue();

                if (!map.ContainsKey(col))
                {
                    map.Add(col, new List<int>());
                }

                map[col].Add(curr.value);

                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                    cols.Enqueue(col - 1);
                    minColumnNumber = Math.Min(minColumnNumber, col - 1);
                }

                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                    cols.Enqueue(col + 1);
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



    public class TreeNodeVerticalOrder
    {
        public int value;
        public int horizontalDistance;
        public TreeNodeVerticalOrder left;
        public TreeNodeVerticalOrder right;

        public TreeNodeVerticalOrder(int data)
        {
            value = data;
            horizontalDistance = 0;
        }
    }
}
