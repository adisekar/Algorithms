using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class ClosestValue
    {
        public static int FindClosestValueRecursive(TreeNode root, int target)
        {
            return FindClosestValueHelper(root, target, Int32.MaxValue);
        }

        public static int FindClosestValueIterative(TreeNode root, int target, int closestNodeValue = Int32.MaxValue)
        {
            var currentNode = root;

            while (currentNode != null)
            {
                // Update closest, if target - current root, is smaller
                // than previously calculated target - closest
                if (Math.Abs(target - closestNodeValue) > Math.Abs(target - currentNode.value))
                {
                    closestNodeValue = currentNode.value;
                }

                if (root.value > target)
                {
                    currentNode = currentNode.left;
                }
                else if (root.value < target)
                {
                    currentNode = currentNode.right;
                }
                else // If root value is equal to target
                {
                    break; ;
                }
            }
            return closestNodeValue;
        }

        private static int FindClosestValueHelper(TreeNode root, int target, int closestNodeValue)
        {
            if (root == null || root.value == -1)
            {
                return closestNodeValue;
            }

            // Update closest, if target - current root, is smaller
            // than previously calculated target - closest
            if (Math.Abs(target - closestNodeValue) > Math.Abs(target - root.value))
            {
                closestNodeValue = root.value;
            }

            if (root.value > target)
            {
                return FindClosestValueHelper(root.left, target, closestNodeValue);
            }
            else if (root.value < target)
            {
                return FindClosestValueHelper(root.right, target, closestNodeValue);
            }
            else // If root value is equal to target
            {
                return closestNodeValue;
            }
        }
    }
}
