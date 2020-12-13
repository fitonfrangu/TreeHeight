using System;
using System.Collections.Generic;
using System.Text;

namespace TreeHeight
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    public static class Tree
    {
        public static Node root;

        public static int CalculateDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int leftDepth = CalculateDepth(node.left);
                int rightDepth = CalculateDepth(node.right);

                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else
                    return (rightDepth + 1);
            }
        }

        public static Node Insert(Node root, int data)
        {
            if (root == null) 
                root = new Node(data);
            else if (data <= root.data) 
                root.left = Insert(root.left, data);
            else if (data > root.data) 
                root.right = Insert(root.right, data);

            return root;
        }
    }
}
