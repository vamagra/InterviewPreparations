using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class PathSumII
    {
        /// <summary>
        /// Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
        //  For example:
        //  Given the below binary tree and sum = 22,
        //              5
        //             / \
        //            4   8
        //           /   / \
        //          11  13  4
        //         /  \    / \
        //        7    2  5   1
        //  return
        //  [
        //       [5,4,11,2],
        //       [5,8,4,5]
        //  ]
        // </summary>
        // <param name="root"></param>
        // <returns></returns>
        public static IList<IList<int>> GetPathSumList(TreeNode root, int target)
        {
            IList<IList<int>> resultList = new List<IList<int>>();

            if (root == null)
            {
                return resultList;
            }

            List<int> pathList = new List<int>();
            Stack<TreeNode> stackTree = new Stack<TreeNode>();

            int pathSum = 0;

            TreeNode prev = null;
            TreeNode curr = root;

            while (curr != null || stackTree.Count != 0)
            {
                // Step 1 - Loop thorugh till left tree leaf node // go down all the way to the left leaf node
                // add all the left nodes to the stack 

                while (curr != null)
                {
                    stackTree.Push(curr);

                    // record the current sum along the current path
                    pathSum += curr.value;

                    // record the current path
                    pathList.Add(curr.value);

                    curr = curr.left;
                }

                // Step 2 - peek the leaf node from Stack Tree
                // check left leaf node's right subtree 
                // or check if it is not from the right subtree
                // why peek here? 
                // because if it has right subtree, we don't need to push it back

                curr = stackTree.Peek();

                // below condition is to check if there is any right node available or not
                // if yes then move to right node and continue checking for its left node node.right!=prev condition is to check if we have already visitied that right node
                if (curr.right != null && curr.right != prev)
                {
                    curr = curr.right;

                    // back to the outer while loop to explore right left and right nodes
                    continue;
                }

                // Step 3 - Check for the leaf nodes and check if pathSum is equal to target, if yes add new list to result
                if (curr.left == null && curr.right == null && pathSum == target)
                {
                    // why do we need new arraylist here? // if we are using the same path variable path
                    // path will be cleared after the traversal

                    resultList.Add(new List<int>(pathList));
                }

                // Step 4 - Reset curr

                // pop out the current value
                stackTree.Pop();

                // make prev node as curr node
                prev = curr;

                // remove the curr.value from pathSum as pathSum was not equal to target,
                // now we need to check for other nodes. // subtract current node's val from path sum 
                pathSum = pathSum - curr.value;

                // similary remove the curr item value from list
                // as this current node is done, remove it from the current path
                pathList.RemoveAt(pathList.Count - 1);

                // reset current node to null, so check the next item from the stack 
                curr = null;
            }

            return resultList;
        }
    }
}
