using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal
{
    public class PopulateNextRightPointer
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<Node> levelNodes = new List<Node>();

                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    levelNodes.Add(curr);

                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }

                for (int i = 0; i < levelNodes.Count - 1; i++)
                {
                    levelNodes[i].next = levelNodes[i + 1];
                }
            }
            return root;
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
