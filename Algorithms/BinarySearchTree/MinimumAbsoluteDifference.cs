using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    class MinimumAbsoluteDifference
    {
        private int minDiff;
        private TreeNode prev;

        public MinimumAbsoluteDifference()
        {
            minDiff = Int32.MaxValue;
            prev = null;
        }
        public int GetMinimumDifference(TreeNode root)
        {
            DFS(root);
            return minDiff;
        }

        private void DFS(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            DFS(root.left);
            if (prev != null)
            {
                minDiff = Math.Min(minDiff, Math.Abs(prev.value - root.value));
            }
            prev = root;
            DFS(root.right);
        }
    }
}
