using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class DeleteNodeBinarySearchTree
    {
        /// <summary>
        //  Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.
        //  Basically, the deletion can be divided into two stages:
        //  Search for a node to remove.
        //  If the node is found, delete the node.
        //  Note: Time complexity should be O(height of tree).
        //  Example:
        //  root = [5,3,6,2,4,null,7]
        //        key = 3
        //    5
        //   / \
        //  3   6
        // / \   \
        //2   4   7
        //  Given key to delete is 3. So we find the node with value 3 and delete it.
        //  One valid answer is [5,4,6,2,null,null,7], shown in the following BST.
        //    5
        //   / \
        //  4   6
        // /     \
        //2       7
        //  Another valid answer is [5,2,6,null,4,null,7].
        //    5
        //   / \
        //  2   6
        //   \   \
        //    4   7
        //  </summary>
        //  <param name="root"></param>
        //  <param name="key"></param>
        //  <returns></returns>
        public static TreeNode DeleteNodeBST(TreeNode root, int key)
        {
            if (root == null)
            {
                return root;
            }

            // if key is smaller than curr node, move to left
            if (root.value > key)
            {
                root.left = DeleteNodeBST(root.left, key);
            }
            // if key is greater than curr node, move to right
            else if (root.value < key)
            {
                root.right = DeleteNodeBST(root.right, key);
            }
            // when we found the key
            else
            {
                // when there is only child
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }
                else
                {
                    // when there is two child
                    TreeNode temp = MinNodeValueSubTree(root.right);

                    // copy the inorder successor
                    root.value = temp.value;

                    // delete the inorder successor
                    root.right = DeleteNodeBST(root.right, temp.value);
                }
            }

            return root;
        }

        private static TreeNode MinNodeValueSubTree(TreeNode node)
        {
            TreeNode curr = node;

            while (curr.left != null)
            {
                curr = curr.left;
            }

            return curr;
        }
    }
}
