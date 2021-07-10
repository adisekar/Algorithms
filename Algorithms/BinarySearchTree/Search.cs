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
            // Recursive
            if (root == null)
            {
                return null;
            }

            if (root.value == target)
            {
                return root;
            }

            if (root.value < target)
            {
                return SearchBSTRecursive(root.right, target);
            }
            else
            {
                return SearchBSTRecursive(root.left, target);
            }
        }

        public static TreeNode SearchBSTIterative(TreeNode root, int target)
        {
            // Iterative
            while (root != null)
            {
                if (root.value == target)
                {
                    return root;
                }

                if (root.value < target)
                {
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }
            return null;
        }
    }
}
