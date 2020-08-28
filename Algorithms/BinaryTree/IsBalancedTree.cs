using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class IsBalancedTree
    {
        public static bool IsBalanced(TreeNode root)
        {
            bool isBalanced = true;
            GetHeight(root, ref isBalanced);
            return isBalanced;
        }

        private static int GetHeight(TreeNode root, ref bool isBalanced)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }

            int left = GetHeight(root.left, ref isBalanced);
            int right = GetHeight(root.right, ref isBalanced);

            if (Math.Abs(left - right) > 1)
            {
                isBalanced = false;
            }

            return Math.Max(left, right) + 1;
        }
    }
}
