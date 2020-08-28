using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class SubTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
            {
                return false;
            }
            if (t == null)
            {
                return true;
            }

            if (SameTree.IsSameTree(s, t))
            {
                return true;
            }
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
    }
}
