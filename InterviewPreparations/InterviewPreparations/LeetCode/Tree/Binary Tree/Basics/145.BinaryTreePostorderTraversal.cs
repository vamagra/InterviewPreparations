using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreePostorderTraversal
    {
        /// <summary>
        // Given a binary tree, return the postorder traversal of its nodes' values.
        //  Example:
        //  Input: [1,null,2,3]
        //   1
        //    \
        //     2
        //    /
        //   3
        //  Output: [3,2,1]
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static IList<int> BinaryTreePostorderTraversalIterative(TreeNode root)
        {
            IList<int> resultList = new List<int>();

            if (root == null)
            {
                return resultList;
            }

            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();

            stack1.Push(root);

            while (stack1.Count != 0)
            {
                TreeNode curr = stack1.Pop();
                stack2.Push(curr);

                if (curr.left != null)
                {
                    stack1.Push(curr.left);
                }

                if (curr.right != null)
                {
                    stack1.Push(curr.right);
                }
            }

            while (stack2.Count != 0)
            {
                resultList.Add(stack2.Pop().value);
            }

            return resultList;
        }

        //Post Order
        public static void BinaryTreePostorderTraversalRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            BinaryTreePostorderTraversalRecursive(root.left);
            BinaryTreePostorderTraversalRecursive(root.right);
            Console.Write(root.value);
        }
    }
}
