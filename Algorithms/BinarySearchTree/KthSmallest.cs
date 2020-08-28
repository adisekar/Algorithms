using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class KthSmallest
    {
        private static int currentCount;
        public KthSmallest()
        {
            currentCount = 0;
        }

        public static int KthSmallestElement(TreeNode root, int k)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }

            int left = KthSmallestElement(root.left, k);
            if (left != 0)
            {
                return left;
            }
            currentCount++;
            if (k == currentCount)
            {
                return root.value;
            }
            int right = KthSmallestElement(root.right, k);
            return right;
        }
    }
}
