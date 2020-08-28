using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class LowestCommonAncestor
    {
        // Can use same soln in Binary Tree LCA, but this is alternate approach
        public static TreeNode LCA(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) { return null; }
            if (p.value < root.value && q.value < root.value)
            {
                return LCA(root.left, p, q);
            }
            else if (p.value > root.value && q.value > root.value)
            {
                return LCA(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
    }
}
