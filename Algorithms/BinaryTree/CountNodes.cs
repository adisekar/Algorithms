using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class CountNodes
    {
        public static int Count(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }
            int left = Count(root.left);
            int right = Count(root.right);
            return 1 + left + right;
            //return 1 + Count(root.left) + Count(root.right);
        }

        public static int CountIterative(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int count = 0;
            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                count++;
                if (current.left != null && current.left.value != -1)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null && current.right.value != -1)
                {
                    queue.Enqueue(current.right);
                }
            }
            return count;
        }
    }
}
