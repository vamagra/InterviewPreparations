using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    //  Given a Binary Search Tree and a number N, the task is to find the smallest number in the 
    //  binary search tree that is greater than or equal to N. Print the value of the element if it exists otherwise 
    //  print -1.
    // Examples:
    // Input: N = 20
    // Output: 21
    // Explanation: 21 is the smallest element greater than 20.
    // Input: N = 18
    // Output: 19
    // Explanation: 19 is the smallest element greater than 18.
    // </summary>
    class SmallestNumberBSTGreaterThanN
    {
        public static int SmallestNumberBSTGreterThanGivenN(TreeNode root, int target)
        {
            if (root == null)
            {
                return -1;
            }

            // if this is leaf node and target is greater than root node, then there is no greater element in this
            // tree, so return it from here
            if (root.left == null && root.right == null && root.value < target)
            {
                return -1;
            }

            // if root node is greater than target and left node is null then root.right will defenitly greater than target, so root is first largest element, return root
            // if root node is greater than target and target is greater than root.left then root is the first largest element, return root
            if (root.value >= target && root.left == null || root.value >= target && root.left.value < target)
            {
                return root.value;
            }

            // if root is smaller than target then next greater element will be in right tree, because left will have element less than root
            if (root.value < target)
            {
                return SmallestNumberBSTGreaterThanN.SmallestNumberBSTGreterThanGivenN(root.right, target);
            }
            // if root is greater than target then next greater element will be in left tree, beacuse right will have element greater than root
            else
            {
                return SmallestNumberBSTGreaterThanN.SmallestNumberBSTGreterThanGivenN(root.left, target);
            }
        }
    }
}
