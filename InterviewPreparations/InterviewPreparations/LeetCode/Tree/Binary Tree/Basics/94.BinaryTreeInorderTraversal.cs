using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreeInorderTraversal
    {
        /// <summary>
        /// Given a binary tree, return the inorder traversal of its nodes' values.
        //  For example:
        //  Given binary tree[1, null, 2, 3],
        //   1
        //    \
        //     2
        //    /
        //   3
        //  return [1,3,2].
        //  Note: Recursive solution is trivial, could you do it iteratively?
        //  </summary>
        //  <param name="root"></param>
        /// <returns></returns>
        public static IList<int> BinaryTreeInorderTraversalIterative(TreeNode root)
        {
            // Source - https://www.youtube.com/watch?v=SiyEwLrPpyQ&list=PLeIMaH7i8JDj7DnmO7lll97P1yZjMCpgY

            IList<int> resultedList = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            
            if (root == null)
            {
                return resultedList;
            }

            TreeNode curr = root;

            while (curr != null || stack.Count != 0)
            {
                //read all the left nodes
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                //Pop the node from stack
                curr = stack.Pop();
                resultedList.Add(curr.value);

                curr = curr.right;
            }

            return resultedList;
        }

        //In Order
        public static void BinaryTreeInorderTraversalRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            BinaryTreeInorderTraversalRecursive(root.left);
            Console.Write(root.value);
            BinaryTreeInorderTraversalRecursive(root.right);
        }

        public static IList<int> BinaryTreePreorderTraversalIterative(TreeNode root)
        {
            // Source - https://www.youtube.com/watch?v=VQTF_pRTZek

            IList<int> resultedList = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            if (root == null)
            {
                return resultedList;
            }

            TreeNode curr = root;

            while (curr != null || stack.Count != 0)
            {
                //read all the left nodes
                while (curr != null)
                {
                    resultedList.Add(curr.value);

                    stack.Push(curr);
                    curr = curr.left;
                }

                //Pop the node from stack
                curr = stack.Pop();

                //resultedList.Add(curr.value);
                curr = curr.right;
            }

            return resultedList;
        }

        //Pre Order
        public static void BinaryTreePreorderTraversalRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.value);
            BinaryTreePreorderTraversalRecursive(root.left);
            BinaryTreePreorderTraversalRecursive(root.right);
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
