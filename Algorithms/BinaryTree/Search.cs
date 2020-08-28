using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class SearchTree
    {
        public static TreeNode FindTargetNode(TreeNode root, int target)
        {
            if (root != null)
            {
                if (root.value == target)
                {
                    return root;
                }
                else
                {
                    TreeNode foundNode = FindTargetNode(root.left, target);
                    if (foundNode == null)
                    {
                        foundNode = FindTargetNode(root.right, target);
                    }
                    return foundNode;
                }
            }
            else
            {
                return null;
            }
        }

        public static int Sum(TreeNode root)
        {
            return SumHelper(root, 0);
        }

        private static int SumHelper(TreeNode root, int sum)
        {
            if (root == null)
            {
                return sum;
            }

            int left = SumHelper(root.left, sum + root.value);
            int right = SumHelper(root.right, sum + root.value);
            return left + right;
        }
    }
}
