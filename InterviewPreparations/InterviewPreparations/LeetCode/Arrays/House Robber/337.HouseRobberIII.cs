using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class HouseRobberIII
    {
        /// <summary>
        /// The thief has found himself a new place for his thievery again. There is only one entrance to this area, called the "root." 
        //  Besides the root, each house has one and only one parent house. After a tour, the smart thief realized that "all houses 
        //  in this place forms a binary tree". It will automatically contact the police if two directly-linked houses were broken into 
        //  on the same night.
        //  Determine the maximum amount of money the thief can rob tonight without alerting the police.
        //  Example 1:
        //     3
        //    / \
        //   2   3
        //    \   \ 
        //     3   1
        //  Maximum amount of money the thief can rob = 3 + 3 + 1 = 7.
        //  Example 2:
        //     3
        //    / \
        //   4   5
        //  / \   \ 
        // 1   3   1
        // Maximum amount of money the thief can rob = 4 + 5 = 9.
        // </summary>
        // <param name="nums"></param>
        // <returns></returns>
        public static int HouseRoberIII(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();

            int oddLevelAmount = 0;
            int evenLevelAmount = 0;

            int levelSum = 0;
            queue.Enqueue(root);

            int level = 1;

            while (queue.Count != 0)
            {
                int size = queue.Count;
                levelSum = 0;

                for (int i = 0; i < size; i++)
                {
                    TreeNode curr = queue.Dequeue();
                    levelSum += curr.value;

                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }

                if (level % 2 == 0)
                {
                    evenLevelAmount += levelSum;
                    evenLevelAmount = Math.Max(evenLevelAmount, oddLevelAmount);
                }
                else
                {
                    oddLevelAmount += levelSum;
                    oddLevelAmount = Math.Max(evenLevelAmount, oddLevelAmount);
                }

                level++;
            }

            return Math.Max(evenLevelAmount, oddLevelAmount);
        }
    }
}
