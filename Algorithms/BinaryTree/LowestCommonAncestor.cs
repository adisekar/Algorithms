using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class LowestCommonAncestor
    {
        public static TreeNode LCA(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            if (root == p || root == q)
            {
                return root;
            }

            TreeNode left = LCA(root.left, p, q);
            TreeNode right = LCA(root.right, p, q);

            // LCA only if both left and right subtrees return non null
            if (left != null && right != null)
            {
                return root;
            }
            else
            {
                return left != null ? left : right;
            }
        }
    }
}
