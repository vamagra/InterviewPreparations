using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class N_aryLevelOrderTraversal
    {
        //  <summary>
        //  Given an n-ary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
        //  For example, given a 3-ary tree: We should return its level order traversal:
        //  </summary>
        //  <param name="root"></param>
        //  <returns></returns>
        public static List<List<int>> LevelOrder(NaryNode root)
        {
            if (root == null)
            {
                return null;
            }

            List<List<int>> resultList = new List<List<int>>();
            Queue<NaryNode> queue = new Queue<NaryNode>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int size = queue.Count;
                List<int> currLevel = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    NaryNode curr = queue.Dequeue();
                    currLevel.Add(curr.val);

                    foreach (var node in curr.children)
                    {
                        queue.Enqueue(node);
                    }
                }

                resultList.Add(currLevel);
            }

            return resultList;
        }
    }

    public class NaryNode
    {
        public int val;
        public List<NaryNode> children;

        public NaryNode(int data)
        {
            val = data;
            children = new List<NaryNode>();
        }
    }

}
