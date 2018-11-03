using InterviewQuestions.LinkedListClass;
using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class BinaryTreeCreateLinkedListDepthD
    {
        /// <summary>
        /// Given a binary search tree, design an algorithm which creates a linked list of all the nodes at each depth (eg, if you have a tree with depth D, you’ll have D linked lists)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<LinkedList<TreeNode>> CreateLevelLinkedList(TreeNode root)
        {
            int level = 0;

            List<LinkedList<TreeNode>> result = new List<LinkedList<TreeNode>>();
            LinkedList<TreeNode> list = new LinkedList<TreeNode>();

            list.AddLast(root);
            result.Insert(level, list);

            if (root == null)
            {
                return result;
            }

            while (true)
            {
                list = new LinkedList<TreeNode>();

                // loop through all the nodes of curr level
                for (int i = 0; i < result[level].Count; i++)
                {
                    TreeNode curr = (TreeNode)result[level].ElementAt(i);

                    if (curr.left != null)
                    {
                        list.AddLast(curr.left);
                    }

                    if (curr.right != null)
                    {
                        list.AddLast(curr.right);
                    }
                }

                if (list.Count > 0)
                {
                    result.Insert(level + 1, list);
                }
                else
                {
                    break;
                }

                level++;
            }

            return result;
        }
    }
}
