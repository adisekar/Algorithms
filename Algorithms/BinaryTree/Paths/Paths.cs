using System;
using System.Collections.Generic;
using System.Text;
using DS.BinaryTree;

namespace Algorithms.BinaryTree.Paths
{
    public class Paths
    {
        public static IList<string> RootToLeafPaths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            DFS(root, "", paths);
            return paths;
        }

        private static void DFS(TreeNode node, string path, IList<string> paths)
        {
            if (node == null || node.value == -1)
            {
                return;
            }

            path += node.value;

            // If either left or right leaf is null, then leaf node
            if (node.left == null && node.right == null)
            {
                paths.Add(path);
            }
            else
            {
                path += "->";
                DFS(node.left, path, paths);
                DFS(node.right, path, paths);
            }
        }
    }
}

