using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.Tree;
namespace InterviewQuestions.LeetCode
{
    class ConvertSortedArraytoBinarySearchTree_CTCI
    {
        /// <summary>
        /// Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
        //  For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
        //  Example:
        //  Given the sorted array: [-10,-3,0,5,9],
        //  One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:
        //     0
        //    / \
        //  -3   9
        //  /   /
        //-10  5
        //  </summary>
        //  <param name="nums"></param>
        // <returns></returns>
        public static TreeNode ConvertArrayBST(int[] nums)
        {
            if (nums.Length < 0)
            {
                return null;
            }

            TreeNode root = SortedBST(nums, 0, nums.Length - 1);

            return root;
        }

        public static TreeNode SortedBST(int[] nums, int low, int end)
        {
            if (low > end)
            {
                return null;
            }

            //get the mid element of the array which will be the root node
            int mid = (low + end) / 2;

            TreeNode root = new TreeNode(nums[mid]);

            //Left elements of the array will be left tree
            root.left = SortedBST(nums, low, mid - 1);

            //Right elements of the array will be right tree
            root.right = SortedBST(nums, mid + 1, end);

            return root;
        }
    }
}
