using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ConvertBinarySearchTreeToSumTree
    {
        public static int ConvertBSTToSumTree(TreeNode root)
        {
            // Base case
            if (root == null)
            {
                return 0;
            }

            // Base case
            int old_value = root.value;

            // Recursively call for left and right subtrees and store the sum as
            // new value of this node
            root.value = ConvertBSTToSumTree(root.left) + ConvertBSTToSumTree(root.right);

            // Return the sum of values of nodes in left and right subtrees and
            // old_value of this node
            return root.value + old_value;
        }
    }
}
