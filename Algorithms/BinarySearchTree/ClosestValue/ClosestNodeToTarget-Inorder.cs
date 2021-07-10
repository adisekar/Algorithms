using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree.ClosestValueBT
{
    public class ClosestNodeToTarget
    {
        // O(n) soln
        /*
         Given the root of a binary search tree and a target value, return the 
        value in the BST that is closest to the target.
Example 1:
Input: root = [4,2,5,1,3], target = 3.714286
Output: 4
         */
        // O(n). Not using BST property. Retreiving entire inorder traversal
        public int ClosestValue_Inorder(TreeNode root, double target)
        {
            List<int> list = new List<int>();
            Inorder(root, list);

            double diff = Int32.MaxValue;
            int result = 0;
            foreach (var num in list)
            {
                double curDiff = Math.Abs(target - num);
                if (curDiff < diff)
                {
                    result = num;
                    diff = curDiff;
                }
            }
            return result;
        }
        private void Inorder(TreeNode root, List<int> list)
        {
            if (root == null) { return; }
            Inorder(root.left, list);
            list.Add(root.value);
            Inorder(root.right, list);
        }

        // ----------------------------------------------------------------------//

        // Best using BST property. Only equal to height of tree
        public int FindClosestValue(TreeNode root, double target)
        {
            int closestNodeVal = root.value;
            while (root != null)
            {
                closestNodeVal = Math.Abs(root.value - target) < Math.Abs(closestNodeVal - target) ? root.value : closestNodeVal;
                if (target < root.value)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }
            return closestNodeVal;
        }

        //-----------------------------------------------------//

        // Inorder iterative, so we can stop after exceeding higher value than target
        public int ClosestValue_OptimizedInorder(TreeNode root, double target)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            int closest = root.value;
            long prev = long.MinValue;

            while (stack.Count != 0 || root != null)
            {
                // Go left
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                // Print top of stack - left most element
                root = stack.Pop();
                if (prev <= target && target < root.value)
                {
                    return Math.Abs(prev - target) < Math.Abs(root.value - target) ? (int)prev : root.value;
                }
                prev = root.value;
                // go right
                root = root.right;
            }
            return (int)prev;
        }

        // ------------------------------------------------ //
        public int ClosestValue_Iterative_Inorder(TreeNode root, double target)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            int closest = root.value;

            while (stack.Count != 0 || root != null)
            {
                // Go left
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                // Print top of stack - left most element
                root = stack.Pop();
                closest = Math.Abs(root.value - target) < Math.Abs(closest - target)
                     ? root.value : closest;
                // go right
                root = root.right;
            }
            return closest;
        }
    }
}
