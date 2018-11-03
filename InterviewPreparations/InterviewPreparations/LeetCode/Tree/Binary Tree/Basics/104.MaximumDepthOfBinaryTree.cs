using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.Tree;
namespace InterviewQuestions.LeetCode
{
    class MaximumDepthOfBinaryTree
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaximumDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return (Math.Max(MaximumDepth(root.left), MaximumDepth(root.right))) + 1;
        }

        public int MaxDepthIterativeSoution(TreeNode root)
        {
            TreeNode curr = root;

            Stack<TreeNode> nodeStack = new Stack<TreeNode>();
            Stack<int> depthStack = new Stack<int>();

            int max = 0;
            int depth = 1;

            while (curr != null || nodeStack.Count > 0)
            {
                if (curr != null)
                {
                    nodeStack.Push(curr);
                    depthStack.Push(depth);
                    curr = curr.left;
                    depth++;
                }
                else
                {
                    curr = nodeStack.Pop();
                    depth = depthStack.Pop();

                    if (depth > max)
                    {
                        max = depth;
                    }

                    curr = curr.right;
                    depth++;
                }
            }

            return max;
        }
    }
}
