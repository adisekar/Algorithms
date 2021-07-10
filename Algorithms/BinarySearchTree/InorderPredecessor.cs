using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class InorderPredecessor
    {
        public static TreeNode FindPredecessor(TreeNode root, TreeNode p)
        {
            if (p.left != null)
            {
                p = p.left;
                while (p.right != null)
                {
                    p = p.right;
                }
                return p;
            }
            else // when leaf node or no left subtree.
                 // Get last right turn
            {
                TreeNode t = root;
                TreeNode r = null;
                while (t != p)
                {
                    if (t.value < p.value)
                    {
                        r = t;
                        t = t.right;
                    }
                    else
                    {
                        t = t.left;
                    }
                }
                return r;
            }
        }
    }
}
