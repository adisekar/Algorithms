using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Paths
{
    public class LeftLeavesSum
    {
        // [3,9,20,null,null,15,7]. o/p = 24
        public int SumOfLeftLeaves(TreeNode root, bool isLeft = false)
        {
            if (root == null) { return 0; }
            int left = SumOfLeftLeaves(root.left, true);
            int right = SumOfLeftLeaves(root.right, false);

            if (isLeft && root.left == null && root.right == null)
            {
                return root.value;
            }
            else
            {
                return left + right;
            }
        }

        public int SumOfLeftLeavesIterativeBFS(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int total = 0;

            while (q.Count > 0)
            {
                var cur = q.Dequeue();

                if (cur.left != null)
                {
                    if (cur.left.left == null && cur.left.right == null)
                    {
                        total += cur.left.value;
                    }
                    q.Enqueue(cur.left);
                }

                if (cur.right != null)
                {
                    q.Enqueue(cur.right);
                }
            }
            return total;
        }

        public int SumOfLeftLeavesIterativePreorder(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            int total = 0;
            bool isLeft = false;

            while (root != null || stack.Count > 0)
            {
                if (root != null)
                {
                    stack.Push(root);
                    if (isLeft == true && root.left == null && root.right == null)
                    {
                        total += root.value;
                    }
                    isLeft = true;
                    root = root.left;
                }
                else
                {
                    root = stack.Pop();
                    root = root.right;
                    isLeft = false;
                }
            }
            return total;
        }
    }
}
