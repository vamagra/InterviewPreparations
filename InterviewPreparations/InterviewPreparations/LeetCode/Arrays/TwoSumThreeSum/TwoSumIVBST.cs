using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.TwoSumThreeSum
{
    class TwoSumIVBST
    {
        /// <summary>
        /// Given a Binary Search Tree and a target number, return true if there exist two elements in the BST such that their sum is equal to the given target.
        //  Example 1:
        //  Input: 
        //     5
        //    / \
        //   3   6
        //  / \   \
        // 2   4   7
        // Target = 9
        // Output: True
        // Example 2:
        // Input: 
        //     5
        //    / \
        //   3   6
        //  / \   \
        // 2   4   7
        // Target = 28
        // Output: False
        //  </summary>
        //  <param name="root"></param>
        //  <param name="target"></param>
        //  <returns></returns>
        public static bool CheckTwoSumBST(TreeNode root, int target)
        {
            // https://leetcode.com/problems/two-sum-iv-input-is-a-bst/discuss/106071/Iterative-solution-with-O(n)-time-O(logn)-space-with-detailed-explanation.-Only-traverse-the-binary-tree-once!!!
            if (root == null)
            {
                return false;
            }

            Stack<TreeNode> leftStack = new Stack<TreeNode>();
            Stack<TreeNode> rightStack = new Stack<TreeNode>();

            getMin(root.left, leftStack);
            getMax(root.right, rightStack);

            TreeNode min = leftStack.Pop();
            TreeNode max = rightStack.Pop();

            while (min.value != max.value)
            {
                int currSum = min.value + max.value;
                if (currSum == target)
                {
                    return true;
                }
                else if (currSum < target)
                {
                    if (min.right != null)
                    {
                        min = min.right;
                        //getMin(min, leftStack);

                    }

                    min = leftStack.Pop();
                }
                else
                {
                    if (max.left != null)
                    {
                        max = max.left;
                        getMax(max, rightStack);
                    }
                    max = rightStack.Pop();
                }
            }

            return false;
        }

        private static void getMin(TreeNode curr, Stack<TreeNode> leftStack)
        {
            while (curr != null)
            {
                leftStack.Push(curr);
                curr = curr.left;
            }
        }

        private static void getMax(TreeNode curr, Stack<TreeNode> rightStack)
        {
            while (curr != null)
            {
                rightStack.Push(curr);
                curr = curr.right;
            }
        }
    }
}
