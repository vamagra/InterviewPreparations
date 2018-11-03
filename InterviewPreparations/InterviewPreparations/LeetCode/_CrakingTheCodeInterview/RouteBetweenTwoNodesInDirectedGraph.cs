using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class RouteBetweenTwoNodesInDirectedGraph_CTCI
    {
        /// <summary>
        //  Given a directed graph, design an algorithm to find out whether there is a route
        //  between two nodes
        //        Example
        //  Given graph:

        //  A----->B----->C
        //  \     |
        //   \    |
        //    \   |
        //     \  v
        //      ->D----->E
        //  for s = B and t = E, return true
        //  for s = D and t = C, return false
        //  </summary>
        //  <param name="source"></param>
        //  <param name="destination"></param>
        //  <returns></returns>
        public static bool FoundRouteTwoNodesGraph(GraphNode source, GraphNode destination)
        {
            if (source == null || destination == null)
            {
                return false;
            }

            Queue<GraphNode> queue = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();

            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    GraphNode node = queue.Dequeue();

                    // add into visited list
                    visited.Add(node);

                    if (node == destination)
                    {
                        return true;
                    }

                    if (node.neighbours.Count > 0)
                    {
                        foreach (GraphNode item in node.neighbours)
                        {
                            if(visited.Contains(item))
                            {
                                continue;
                            }

                            queue.Enqueue(item);
                        }
                    }
                }
            }

            return false;
        }
    }

    //public class GraphNode
    //{
    //    public int data;
    //    public List<GraphNode> neighbours;

    //    GraphNode(int val)
    //    {
    //        data = val;
    //        list = new List<GraphNode>();
    //    }
    //}
}
