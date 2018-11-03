using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SerializeAndDeserializeBinaryTree
    {
        /// <summary>
        /// Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.
        //  Design an algorithm to serialize and deserialize a binary tree.There is no restriction on how your serialization/deserialization algorithm should work. You just need to ensure that a binary tree can be serialized to a string and this string can be deserialized to the original tree structure.
        //  Example: 
        //  You may serialize the following tree:
        //    1
        //   / \
        //  2   3
        //     / \
        //    4   5
        // as "[1,2,3,null,null,4,5]"
        // Clarification: Just the same as how LeetCode OJ serializes a binary tree.You do not necessarily need to follow this format, so please be creative and come up with different approaches yourself.
        // Note: Do not use class member/global/static variables to store states.Your serialize and deserialize algorithms should be stateless.
        /// </summary>

        public static string SerializeBinaryTreeBFS(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            if (root == null)
            {
                return sb.ToString();
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();
                if (node == null)
                {
                    sb.Append("null,");
                    continue;
                }

                sb.Append(node.value + ",");

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            return sb.ToString();
        }

        public static TreeNode DeSerializeBinaryTreeBFS(string data)
        {
            TreeNode root;

            if(string.IsNullOrEmpty(data))
            {
                return null;
            }

            string[] nodes = data.Split(',');
            root = new TreeNode(int.Parse(nodes[0]));

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            for (int i = 1; i < nodes.Length; i++)
            {
                TreeNode curr = queue.Dequeue();

                if (nodes[i] != "null")
                {
                    curr.left = new TreeNode(int.Parse(nodes[i]));
                    queue.Enqueue(curr.left);
                }

                if (nodes[++i] != "null")
                {
                    curr.right = new TreeNode(int.Parse(nodes[i]));
                    queue.Enqueue(curr.right);
                }
            }

            return root;
        }
    }
}
