using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class Search
    {
        public static TreeNode SearchBSTRecursive(TreeNode root, int target)
        {
            if (root == null)
            {
                return root;
            }

            if (root.value == target)
            {
                return root;
            }
            else
            {
                if (root.value > target)
                {
                    return SearchBSTRecursive(root.left, target);
                }
                else
                {
                    return SearchBSTRecursive(root.right, target);
                }
            }
        }

        public static TreeNode SearchBSTIterative(TreeNode root, int target)
        {
            if (root == null)
            {
                return root;
            }

            while (root != null && root.value != target)
            {
                if (root.value > target)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }
            return root;
        }
    }
}
