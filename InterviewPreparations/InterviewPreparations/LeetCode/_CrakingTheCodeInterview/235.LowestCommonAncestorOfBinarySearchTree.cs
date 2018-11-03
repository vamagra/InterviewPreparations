using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LowestCommonAncestorOfBinarySearchTree_CTCI
    {
        /// <summary>
        /// Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.
        //  According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes v and w as the lowest node in T 
        //  that has both v and w as descendants(where we allow a node to be a descendant of itself).”
        //        _______6______
        //       /              \
        //    ___2__          ___8__
        //   /      \        /      \
        //   0      _4       7       9
        //         /  \
        //         3   5
        // For example, the lowest common ancestor(LCA) of nodes 2 and 8 is 6. Another example is LCA of nodes 2 and 4 is 2, since a node can be a descendant of 
        // itself according to the LCA definition.
        // </summary>
        // <param name="root"></param>
        // <param name="p"></param>
        // <param name="q"></param>
        /// <returns></returns>
        public static TreeNode LowestCommonAncestorBSTIterative(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode curr = root;

            int max = p.value > q.value ? p.value : q.value;
            int min = p.value < q.value ? p.value : q.value;

            while (curr != null)
            {
                if (curr.value >= min && curr.value <= max)
                {
                    return curr;
                }
                else if (curr.value > max)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            return curr;
        }
        public static TreeNode LowestCommonAncestorBST(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            //if Root.value is greater than both p and q search the lower common ancesor in left tree
            if (root.value > p.value && root.value > q.value)
            {
                return LowestCommonAncestorBST(root.left, p, q);
            }

            //if root.value is less than both p and q then search the lower common ancestor in right tree
            if (root.value < p.value && root.value < q.value)
            {
                return LowestCommonAncestorBST(root.right, p, q);
            }

            return root;
        }

        
    }
}
