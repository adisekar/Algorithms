using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class MaxPathSum
    {
        private static int result;
        public MaxPathSum()
        {
            result = Int32.MinValue;
        }
        // Do post order traversal, to go till left and right leaf, and when recursion returns, 
        // calculate / add node values
        public static int GetMaxPathSum(TreeNode root)
        {
            GetMaxPathSumHelper(root);
            PostOrder(root);
            return result;
        }
        public static int GetMaxPathSumHelper(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return 0;
            }

            int left = GetMaxPathSumHelper(root.left);
            int right = GetMaxPathSumHelper(root.right);

            // case 1 - Take either left/right + root or just root. Straight path
            int maxSum = Math.Max(Math.Max(left, right) + root.value, root.value);
            // case 2 - Take root and left and right or prev value from maxSum
            int maxSum2 = Math.Max(maxSum, left + right + root.value);
            // case 3 - Current node is not in path, so use prev maxSum2
            result = Math.Max(maxSum2, result);
            return maxSum;
        }

        // Use this approach than above, it is easier
        // Post order traversal
        private static int PostOrder(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            // Go left and right child
            int left = PostOrder(node.left);
            int right = PostOrder(node.right);

            // Upper bound negative values to 0, as negative value when added to cur node value will be negative, but we want to ignore that path    
            if (left < 0)
            {
                left = 0;
            }

            if (right < 0)
            {
                right = 0;
            }

            int curMaxPathSum = left + right + node.value;
            result = Math.Max(result, curMaxPathSum);

            // Take either left or right path along with node val
            return Math.Max(left, right) + node.value;
        }
    }   
}
