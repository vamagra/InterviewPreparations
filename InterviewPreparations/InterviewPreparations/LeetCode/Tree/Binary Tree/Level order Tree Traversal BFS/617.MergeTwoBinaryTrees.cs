using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MergeTwoBinaryTrees
    {
        /// <summary>
        /// Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.
        //  You need to merge them into a new binary tree.The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node.Otherwise, the NOT null node will be used as the node of new tree.
        //  Example 1:
        //  Input: 
        //	Tree 1                     Tree 2                  
        //          1                         2                             
        //         / \                       / \                            
        //        3   2                     1   3                        
        //       /                           \   \                      
        //      5                             4   7                  
        //  Output: 
        //  Merged tree:
        //	     3
        //	    / \
        //	   4   5
        //	  / \   \ 
        //	 5   4   7
        //  Note: The merging process must start from the root nodes of both trees.
        //  </summary>
        //  <param name="t1"></param>
        //  <param name="t2"></param>
        //  <returns></returns>
        public static TreeNode MergeTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }

            if (t2 == null)
            {
                return t1;
            }

            Queue<TreeNode[]> queue = new Queue<TreeNode[]>();
            queue.Enqueue(new TreeNode[] { t1, t2 });

            while (queue.Count != 0)
            {
                TreeNode[] curr = queue.Dequeue();

                // merge t2 into t1 only when it is not null
                if (curr[1] == null)
                {
                    continue;
                }

                // treenode1 must not be null, so merge into t2
                curr[0].value += curr[1].value;


                // if treeNode 1 left is null, assign t2 left to t1 left
                if (curr[0].left == null)
                {
                    curr[0].left = curr[1].left;
                }
                else
                {
                    // else enqueue both left in queue
                    queue.Enqueue(new TreeNode[] { curr[0].left, curr[1].left });
                }

                if(curr[0].right==null)
                {
                    curr[0].right = curr[1].right;
                }
                else
                {
                    queue.Enqueue(new TreeNode[] { curr[0].right, curr[1].right });
                }
            }

            return t1;
        }
    }
}
