using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class CheckIsBSTSumTree
    {
        public static bool IsBSTSumTree(TreeNode root)
        {
            int leftSum = 0;
            int rightSum = 0;

            //check if this is leaf node
            if (root == null && root.left == null && root.right == null)
            {
                return true;
            }

            leftSum = Sum(root.left);
            rightSum = Sum(root.right);

            if ((root.value == leftSum + rightSum) && IsBSTSumTree(root.left) && IsBSTSumTree(root.right))
            {
                return true;
            }

            return false;
        }

        public static int Sum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Sum(node.left) + node.value + Sum(node.right);
        }

    }
}
