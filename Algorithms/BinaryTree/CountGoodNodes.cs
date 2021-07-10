using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class CountGoodNodes
    {
        // Recursive start
        public int GoodNodes(TreeNode root)
        {
            return DFS(root, Int32.MinValue);
        }

        private int DFS(TreeNode root, int leastVal)
        {
            if (root == null)
            {
                return 0;
            }

            int max = Math.Max(root.value, leastVal);
            int goodNode = root.value >= leastVal ? 1 : 0;
            return goodNode + DFS(root.left, max) + DFS(root.right, max);
        }

        // Recursive End

        // Recursive using static count
        private static int count = 0;
        public int GoodNodesStaticCount(TreeNode root)
        {
            DFSStaticCount(root, Int32.MinValue);
            return count;
        }

        private void DFSStaticCount(TreeNode root, int leastVal)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            if (root.value >= leastVal)
            {
                count++;
            }

            int max = Math.Max(root.value, leastVal);
            DFSStaticCount(root.left, max);
            DFSStaticCount(root.right, max);
        }
    }
}
