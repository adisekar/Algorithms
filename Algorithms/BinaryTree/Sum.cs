using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class Sum
    {
        public static int SumOfAllNodes(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }

            return root.value + SumOfAllNodes(root.left)
                 + SumOfAllNodes(root.right);
        }

        public static bool IsSumTree(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return true;
            }

            // Leaf nodes
            if ((root.left == null && root.right == null) ||
                (root.left.value == -1 && root.right.value == -1))
            {
                return true;
            }

            int leftSum = SumOfAllNodes(root.left);
            int rightSum = SumOfAllNodes(root.right);

            if (leftSum + rightSum == root.value)
            {
                return IsSumTree(root.left) && IsSumTree(root.right);
            }
            return false;
        }
    }
}
