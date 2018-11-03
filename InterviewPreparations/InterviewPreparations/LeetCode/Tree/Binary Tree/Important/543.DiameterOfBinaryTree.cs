using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations
{
    class DiameterOfBinaryTree
    {
        /// <summary>
        /// Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
        //  Example:
        //  Given a binary tree 
        //          1
        //         / \
        //        2   3
        //       / \     
        //      4   5    
        //  Return 3, which is the length of the path[4, 2, 1, 3] or[5, 2, 1, 3].
        //  Note: The length of path between two nodes is represented by the number of edges between them.
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static int CalculateDiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            int leftDiameter = CalculateDiameterOfBinaryTree(root.left);
            int rightDiameter = CalculateDiameterOfBinaryTree(root.right);

            int diameter = Math.Max(leftHeight + rightHeight, Math.Max(leftDiameter, rightDiameter));

            return diameter;
        }

        public static int GetHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
        }
    }
}
