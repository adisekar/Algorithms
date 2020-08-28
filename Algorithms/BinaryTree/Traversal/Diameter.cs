using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal
{
    public class Diameter
    {
        static int numOfNodes;

        // Not good solution, as recursion inside recursion, 
        // and lot of overlapping subproblems.
        // O(n^2) time cmplexity
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            // 2 options, diameter passes thru root, or diameter is in left/right child nodes
            int left = Height(root.left);
            int right = Height(root.right);
            // For path not passing thru root
            int lDiameter = DiameterOfBinaryTree(root.left);
            int rDiameter = DiameterOfBinaryTree(root.right);
            int max = Math.Max(left + right, Math.Max(lDiameter, rDiameter));
            return max;
        }

        private static int Height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = Height(root.left);
            int right = Height(root.right);

            int max = Math.Max(left, right);
            return max + 1;
        }

        // O(N) Best Solution
        public static int DiameterOfBinaryTreeBest(TreeNode root)
        {
            numOfNodes = 1;
            Depth(root);
            return numOfNodes - 1;
        }

        private static int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = Depth(root.left);
            int right = Depth(root.right);
            numOfNodes = Math.Max(left + right + 1, numOfNodes);
            return Math.Max(left, right) + 1;
        }
    }
}
