using System;
using System.Collections.Generic;
using System.Text;
using DS.BinaryTree;

namespace Algorithms.BinaryTree
{
    public class Paths
    {
        public IList<string> RootToLeafPaths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            DFS(root, "", paths);
            return paths;
        }

        private void DFS(TreeNode node, string path, IList<string> paths)
        {

            path += node.value;

            // If either left or right leaf is null, then leaf node
            if (node.left == null && node.right == null)
            {
                paths.Add(path);
            }

            DFS(node.left, path + "->", paths);
            DFS(node.right, path + "->", paths);
        }
    }
}

