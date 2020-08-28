using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class Height
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }

        /*
         * "The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node."

The term "leaf node" is defined as a node with no children; therefore, root node cannot be a leaf node. There is only one leaf node, "2", and the path is the number of nodes along the path from root to that node, which is 2.

Edit for clarification: in this particular case, where there are 2 nodes, the root node cannot be a leaf node. That was not a general statement. A single node tree's root node would of course also be a leaf node, and the depth would be calculated as 1.
         */
        public static int MinDepth(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }

            int left = MinDepth(root.left);
            int right = MinDepth(root.right);

            if (left > 0 && right > 0)
            {
                return 1 + Math.Min(left, right);
            }
            else
            {
                return 1 + Math.Max(left, right);
            }
        }
    }
}
