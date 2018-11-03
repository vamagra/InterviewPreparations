using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BinaryTreePathsClass
    {
        /// <summary>
        /// Given a binary tree, return all root-to-leaf paths.
        //  For example, given the following binary tree:
        //   1
        // /   \
        //2     3
        // \
        //  5

        //All root-to-leaf paths are:
        //["1->2->5", "1->3"]
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<string> TreePaths(TreeNode root)
        {
            IList<string> resultedPath = new List<string>();

            if (root == null)
            {
                return resultedPath;
            }

            if (root != null)
            {
                SearchBinaryTreePath(root, "", resultedPath);
            }

            return resultedPath;
        }

        private static void SearchBinaryTreePath(TreeNode root, string path, IList<string> resultedPath)
        {
            //Leaf Node
            if (root.left == null && root.right == null)
            {
                resultedPath.Add(path + root.value);
            }

            //Left Node
            if (root.left != null)
            {
                SearchBinaryTreePath(root.left, path + root.value + "->", resultedPath);
            }

            //Right Node
            if (root.right != null)
            {
                SearchBinaryTreePath(root.right, path + root.value + "->", resultedPath);
            }
        }
    }
}
