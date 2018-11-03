using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ImplementBinaryTreeClass
    {
        public static void AddNodeInBinaryTree()
        {
            BinaryTreeNode root = null;
            addNodeBinaryTree(root, 50);
        }

        private static void addNodeBinaryTree(BinaryTreeNode node, int data)
        {
            if (node == null)
            {
                node = new BinaryTreeNode(data);
            }
            else
            {
                Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
                queue.Enqueue(node);

                while (queue.Count != 0)
                {
                    BinaryTreeNode temp = queue.Dequeue();

                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }

                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }

                    if (temp.left == null)
                    {
                        temp.left = new BinaryTreeNode(data);
                    }
                    else if (temp.right == null)
                    {
                        temp.right = new BinaryTreeNode(data);
                    }

                    break;
                }
            }
        }

        private static BinaryTreeNode addNodeBinarySearchTree(BinaryTreeNode node, int data)
        {
            if (node == null)
            {
                node = new BinaryTreeNode(data);
            }
            else
            {
                if (node.data < data)
                {
                    node.right = addNodeBinarySearchTree(node.right, data);
                }
                else
                {
                    node.left = addNodeBinarySearchTree(node.left, data);
                }
            }

            return node;
        }
    }

    class BinaryTreeNode
    {
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public int data;

        public BinaryTreeNode(int x)
        {
            data = x;
        }
    }
}
