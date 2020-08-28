using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class RangeSum
    {
        static int sum = 0;
        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            //DFS(root, L, R);
            int sum = BFS(root, L, R);
            return sum;
        }

        private static void DFS(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return;
            }
            if (root.value >= L && root.value <= R)
            {
                sum += root.value;
            }
            DFS(root.left, L, R);
            DFS(root.right, L, R);
        }

        private static int BFS(TreeNode root, int L, int R)
        {
            int rangeSum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.value >= L && current.value <= R)
                {
                    rangeSum += current.value;
                }
                if (current.left != null && current.left.value != -1)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null && current.right.value != -1)
                {
                    queue.Enqueue(current.right);
                }
            }
            return rangeSum;
        }
    }
}
