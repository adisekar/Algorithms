using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class ConvertToGraph
    {
        public static int[,] AdjacencyMatrixGraph(TreeNode root)
        {
            int n = CountNodes.CountIterative(root);
            int[,] matrix = new int[n, n];

            DFS(root, matrix);
            return matrix;
        }

        public static void DFS(TreeNode root, int[,] matrix)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            if (root.left != null && root.left.value != -1)
            {
                matrix[root.value, root.left.value] = 1;
                matrix[root.left.value, root.value] = 1;
                DFS(root.left, matrix);
            }

            if (root.right != null && root.right.value != -1)
            {
                matrix[root.value, root.right.value] = 1;
                matrix[root.right.value, root.value] = 1;
                DFS(root.right, matrix);
            }
        }
    }
}
