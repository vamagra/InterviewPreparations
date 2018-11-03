using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MaxBinaryTreeClass
    {
        /// <summary>
        /// Given an integer array with no duplicates. A maximum tree building on this array is defined as follow:
        //  The root is the maximum number in the array.
        //  The left subtree is the maximum tree constructed from left part subarray divided by the maximum number.
        //  The right subtree is the maximum tree constructed from right part subarray divided by the maximum number.
        //  Construct the maximum tree by the given array and output the root node of this tree.
        //  Example 1:
        //  Input: [3,2,1,6,0,5]
        //  Output: return the tree root node representing the following tree:
        //      6
        //    /   \
        //   3     5
        //    \    / 
        //     2  0   
        //       \
        //        1
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static TreeNode MaxTree(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return null;
            }

            // Solution ref:
            // https://leetcode.com/problems/maximum-binary-tree/discuss/106156/Java-worst-case-O(N)-solution

            // traverse the array once and create the node one by one. and use stack to store a decreasing sequence.
            // like 4,3,2,1
            Stack<TreeNode> stack = new Stack<TreeNode>();

            for (int i = 0; i < nums.Length; i++)
            {
                // each step, we create a new curNode
                TreeNode curr = new TreeNode(nums[i]);

                //  keep popping the stack while (stack.peek().val < curNode.val), and set 
                //  the last popping node to be curNode.left. Because the last one 
                //  fulfilling the criteria is the largest number among 
                //  curNode's left children. => curNode.left = last pop node
                //  stack must hold the values in decreasing order means last element at the end of the 
                //  stack like  1 - 2 - 3 - 4 (4 is the last element), so if we keep pop the element till
                //  last element largest element will automatically aligned with curr left
                while (stack.Count != 0 && stack.Peek().value < nums[i])
                {
                    curr.left = stack.Pop();
                }

                //  after popping up all nodes that fulfill (stack.peek().val < curNode.val),
                //  thus(stack.peek().val > curNode.val), the stack.peek() 
                //  is curNode's root => peek.right = curNode like keep adding the decreasing sequence number
                //  at the right of stack curr node like if 4 is current node in stack then curr should be in right
                if (stack.Count != 0)
                {
                    stack.Peek().right = curr;
                }

                // push every node in stack
                stack.Push(curr);
            }

            TreeNode resultNode = null;

            // return the last node from the stack
            foreach (TreeNode tree in stack)
            {
                resultNode = tree;
            }

            return stack.Count == 0 ? null : resultNode;
        }
    }
}
