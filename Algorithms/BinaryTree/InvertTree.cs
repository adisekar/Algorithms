using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class InvertTree
    {
        public static TreeNode InvertTreeRecursive(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            Swap(root);
            InvertTreeRecursive(root.left);
            InvertTreeRecursive(root.right);
            return root;
        }
        public static TreeNode InvertTreeToMirrorBFS(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                Swap(current);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
            return root;
        }

        private static void Swap(TreeNode current)
        {
            TreeNode temp = current.left;
            current.left = current.right;
            current.right = temp;
        }
    }
}
