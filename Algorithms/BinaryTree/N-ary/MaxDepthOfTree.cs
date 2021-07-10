using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.N_ary
{
    public class MaxDepthOfTree
    {
        public int MaxDepth(Node root)
        {
            // base case
            if (root == null)
            {
                return 0;
            }

            int curMax = 0;

            for (int i = 0; i < root.children.Count; i++)
            {
                curMax = Math.Max(curMax, MaxDepth(root.children[i]));
            }
            return curMax + 1;
        }
    }
}
