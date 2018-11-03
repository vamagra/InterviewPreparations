using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    /// Given a binary tree, return the values of its boundary in anti-clockwise direction starting from root. Boundary includes left boundary, leaves, and right boundary in order without duplicate nodes.
    //    Left boundary is defined as the path from root to the left-most node.Right boundary is defined as the path from root to the right-most node. If the root doesn't have left subtree or right subtree, then the root itself is left boundary or right boundary. Note this definition only applies to the input binary tree, and not applies to any subtrees.
    //    The left-most node is defined as a leaf node you could reach when you always firstly travel to the left subtree if exists.If not, travel to the right subtree.Repeat until you reach a leaf node.
    //    The right-most node is also defined by the same way with left and right exchanged.
    //    Example 1
    //    Input:
    //  1
    //   \
    //    2
    //   / \
    //  3   4
    //    Ouput:
    //[1, 3, 4, 2]
    //Explanation:
    //The root doesn't have left subtree, so the root itself is left boundary.
    //The leaves are node 3 and 4.
    //The right boundary are node 1,2,4. Note the anti-clockwise direction means you should output reversed right boundary.
    //    So order them in anti-clockwise without duplicates and we have [1,3,4,2].
    //    Example 2
    //    Input:
    //   ____1_____
    //  /          \
    //  2            3
    // / \          / 
    //4   5        6   
    //   / \      / \
    //  7   8    9  10  
    //    Ouput:
    //[1,2,4,7,8,9,10,6,3]
    //Explanation:
    //The left boundary are node 1,2,4. (4 is the left-most node according to definition)
    //The leaves are node 4,7,8,9,10.
    //The right boundary are node 1,3,6,10. (10 is the right-most node).
    //So order them in anti-clockwise without duplicate nodes we have[1, 2, 4, 7, 8, 9, 10, 6, 3].
    /// </summary>
    class PrintBoundaryBinaryTree
    {
        public static IList<int> GetBoundaryBinaryTreeRecursive(TreeNode root)
        {
            IList<int> boundaryList = new List<int>();

            // Print Left nodes
            // Print Leave nodes
            // Print right nodes Bottom up

            if (root == null)
            {
                return boundaryList;
            }

            if (root.left != null || root.right != null)
            {
                boundaryList.Add(root.value);
            }

            //Add Left Boundary Nodes
            AddLeftBoundaryNodes(root.left, boundaryList);

            //Add Leaves Nodes Tree
            AddLeaveNodesTree(root, boundaryList);

            //Add Right Boundary Nodes
            AddRightBoundaryNodes(root.right, boundaryList);

            return boundaryList;
        }

        private static void AddLeftBoundaryNodes(TreeNode root, IList<int> list)
        {
            if (root == null || (root.left == null && root.right == null))
            {
                return;
            }

            // Add the node in list
            list.Add(root.value);

            if (root.left == null)
            {
                //go to right nodes
                AddLeftBoundaryNodes(root.right, list);
            }
            else
            {
                //go to left nodes
                AddLeftBoundaryNodes(root.left, list);
            }
        }

        private static void AddRightBoundaryNodes(TreeNode root, IList<int> list)
        {
            if (root == null || (root.right == null && root.left == null))
            {
                return;
            }

            if (root.right == null)
            {
                // go to left nodes
                AddRightBoundaryNodes(root.left, list);
            }
            else
            {
                // go to right nodes
                AddRightBoundaryNodes(root.right, list);
            }

            //As we need to read the nodes from Bottom to Top fashion
            list.Add(root.value);
        }

        private static void AddLeaveNodesTree(TreeNode root, IList<int> list)
        {
            if (root == null)
            {
                return;
            }

            if (root.left == null && root.right == null)
            {
                list.Add(root.value);
            }

            AddLeaveNodesTree(root.left, list);
            AddLeaveNodesTree(root.right, list);
        }


        public static IList<int> GetBoundaryBinaryTreeIterative(TreeNode root)
        {
            //IList<int> boundaryList = new List<int>();

            //if (root == null)
            //{
            //    return boundaryList;
            //}

            //TreeNode left = root.left;
            //TreeNode right = root.right;

            //TreeNode curr = root;

            //while (left != null && (left.left != null || left.right != null))
            //{

            //}

            return null;

        }
    }
}
