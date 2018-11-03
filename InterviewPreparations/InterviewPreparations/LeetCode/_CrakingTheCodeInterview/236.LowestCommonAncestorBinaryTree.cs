using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class LowestCommonAncestorBinaryTree_CTCI
    {
        /// <summary>
        /// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.
        //  According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants(where we allow a node to be a descendant of itself).”
        //  Given the following binary tree:  root = [3,5,1,6,2,0,8,null,null,7,4]
        //        _______3______
        //       /              \
        //    ___5__ ___1__
        //   /      \        /      \
        //   6      _2       0       8
        //         /  \
        //         7   4
        //  Example 1:
        //  Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
        //  Output: 3
        //  Explanation: The LCA of of nodes 5 and 1 is 3.
        //  Example 2:
        //  Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
        //  Output: 5
        //  Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself
        //  according to the LCA definition.
        //  Note:
        //  All of the nodes' values will be unique.
        //  p and q are different and both values will exist in the binary tree.
        //  </summary>
        //  <param name="root"></param>
        //  <param name="q"></param>
        //  <param name="p"></param>
        //  <returns></returns>

        static TreeNode answer = null;
        public static TreeNode LCATwoNodesBinaryTree(TreeNode root, TreeNode q, TreeNode p)
        {
            HelperLCABinaryTree(root, p, q);
            return answer;
        }

        public static int HelperLCABinaryTree(TreeNode root, TreeNode p, TreeNode q)
        {
            // here is the counter
            int count = 0;

            if (root != null)
            {
                // if we found any of the node in tree, increase the counter
                if (root.value == p.value || root.value == q.value)
                {
                    count++;
                }

                // check if counter is less than 2, it means we need to keep finding the nodes left aur right tree
                if (count < 2)
                {
                    count += HelperLCABinaryTree(root.left, p, q);
                    count += HelperLCABinaryTree(root.right, p, q);
                }

                // once count will be 2, it means we found both the nodes return 
                if (count == 2)
                {
                    count++;
                    answer = root;
                }
            }

            return count;
        }
    }
}
