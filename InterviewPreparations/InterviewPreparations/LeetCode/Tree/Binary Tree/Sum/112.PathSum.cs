using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PathSum
    {
        /// <summary>
        /// 
        // Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that 
        // adding up all the values along the path equals the given sum.
        //  For example:
        //  Given the below binary tree and sum = 22,
        //              5
        //             / \
        //            4   8
        //           /   / \
        //          11  13  4
        //         /  \      \
        //        7    2      1
        //  return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
        //  </summary>
        //  <param name="root"></param>
        //  <param name="sum"></param>
        //  <returns></returns>        
        public static bool HasPathSumIterative(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            Stack<TreeNode> stackTree = new Stack<TreeNode>();
            Stack<int> stackSums = new Stack<int>();

            stackTree.Push(root);
            stackSums.Push(sum);

            //  Given the below binary tree and sum = 22,
            //              5
            //             / \
            //            4   8
            //           /   / \
            //          11  13  4
            //         /  \      \
            //        7    2      1

            while (stackTree.Count != 0)
            {
                int currSum = stackSums.Pop();
                TreeNode currNode = stackTree.Pop();

                // base condition
                if (currNode.left == null && currNode.right == null && currNode.value == currSum)
                {
                    return true;
                }

                if (currNode.left != null)
                {
                    stackTree.Push(currNode.left);
                    stackSums.Push(currSum - currNode.value);
                }

                if (currNode.right != null)
                {
                    stackTree.Push(currNode.right);
                    stackSums.Push(currSum - currNode.value);
                }
            }

            return false;
        }

        public static bool PathSumBinaryTree(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                if (root.value == sum)
                {
                    return true;
                }
            }

            return PathSumBinaryTree(root.left, sum - root.value) || PathSumBinaryTree(root.right, sum - root.value);
        }
    }
}
