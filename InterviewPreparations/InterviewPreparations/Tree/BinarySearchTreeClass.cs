using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Tree
{
    public class BinaryTree
    {
        //public TreeNode Insert(TreeNode root, int data)
        //{
        //    if (root == null)
        //    {
        //        root = new TreeNode();
        //        root.value = data;
        //    }
        //    else if (data < root.value)
        //    {
        //        root.left = Insert(root.left, data);
        //    }
        //    else
        //    {
        //        root.right = Insert(root.right, data);
        //    }

        //    return root;
        //}

        //public TreeNode InsertIterative(TreeNode root, int data)
        //{
        //    TreeNode current = root;
        //    TreeNode newNode = CreateNode(data);

        //    if (root == null)
        //    {
        //        root = new TreeNode();
        //        root = newNode;
        //    }
        //    else
        //    {
        //        while (current != null)
        //        {
        //            if (current.value < data)
        //            {
        //                if (current.left == null)
        //                {
        //                    current.left = newNode;
        //                    break;
        //                }
        //                else
        //                {
        //                    current = current.left;
        //                }
        //            }
        //            else
        //            {
        //                if (current.right == null)
        //                {
        //                    current.right = newNode;
        //                    break;
        //                }
        //                else
        //                {
        //                    current = current.right;
        //                }
        //            }
        //        }
        //    }

        //    return root;
        //}

        //public TreeNode CreateNode(int value)
        //{
        //    TreeNode temp = new TreeNode();
        //    temp.value = value;
        //    temp.left = null;
        //    temp.right = null;
        //    return temp;
        //}
    }

    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int data)
        {
            value = data;
            left = null;
            right = null;
        }
    }
}
