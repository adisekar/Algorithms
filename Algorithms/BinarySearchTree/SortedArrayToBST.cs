using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class SortedArrayToBST
    {
        public static TreeNode ConstructBSTRecursive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            return RecursiveBS(nums, 0, nums.Length - 1);
        }

        private static TreeNode RecursiveBS(int[] nums, int left, int right)
        {
            // Base case
            if (left > right)
            {
                return null;
            }

            int mid = left + (right - left) / 2;
            TreeNode current = new TreeNode(nums[mid]);
            current.left = RecursiveBS(nums, left, mid - 1);
            current.right = RecursiveBS(nums, mid + 1, right);
            return current;
        }

        public static TreeNode ConstructBSTIterative(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            int middle = (0 + (nums.Length - 1)) / 2;
            int i = middle - 1;
            int j = middle + 1;

            TreeNode root = new TreeNode(nums[middle]);
            TreeNode current = root;
            while (i >= 0)
            {
                current.left = new TreeNode(nums[i]);
                i--;
                current = current.left;
            }

            current = root;
            while (j < nums.Length)
            {
                current.right = new TreeNode(nums[j]);
                j++;
                current = current.right;
            }

            return root;
        }
    }
}
