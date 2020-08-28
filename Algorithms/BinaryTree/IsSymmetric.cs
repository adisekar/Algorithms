using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class IsSymmetric
    {
        public static bool IsSymmetricTree(TreeNode root)
        {
            // If only 1 tree is given, pass it to mirror function
            // twice, to compare it against each other
            return IsMirror(root, root);
        }

        private static bool IsMirror(TreeNode p, TreeNode q)
        {
            // Both null
            if (p == null && q == null)
            {
                return true;
            }

            // One is null
            if (p == null || q == null)
            {
                return false;
            }

            // If both data is same, then check if subtrees are equal
            if (p.value == q.value)
            {
                if (IsMirror(p.left, q.right) && IsMirror(p.right, q.left))
                {
                    return true;
                }
            } // If data is not equal, return false
            return false;
        }
    }
}
