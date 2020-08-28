using System;
using System.Collections.Generic;
using System.Text;
using DS.BinaryTree;

namespace Algorithms.BinaryTree
{
    public class PathSum
    {
        public static bool HasPathSum(TreeNode node, int sum)
        {
            if (node == null)
            {
                return false;
            }
            if (node.left == null && node.right == null)
            {
                return sum - node.value == 0;
            }

            sum = sum - node.value;

            return HasPathSum(node.left, sum) || HasPathSum(node.right, sum);
        }

        public static bool HasPathSumStack(TreeNode root, int sum)
        {
            Stack<TreeNode> visitedNodes = new Stack<TreeNode>();
            TreeNode prev = null;

            while (root != null || visitedNodes.Count > 0)
            {
                while (root != null)
                {
                    visitedNodes.Push(root);
                    //int nodeVal = root != null ? root.value.GetValueOrDefault() : -1;
                    sum -= root.value;
                    prev = root;
                    root = root.left;
                }
                root = visitedNodes.Peek();
                if (root.left == null && root.right == null && sum == 0) return true;
                if (root.right != null && root.right != prev)
                //if (root.right != null)
                {
                    root = root.right;
                }
                else
                {
                    //int nodeVal = root != null ? root.value.GetValueOrDefault() : -1;
                    sum += root.value;
                    prev = visitedNodes.Pop(); ;
                    root = null;
                }
            }
            return false;
        }

        public static IList<IList<int>> PrintPaths(TreeNode root, int sum)
        {
            IList<IList<int>> paths = new List<IList<int>>();
            FindPaths(root, sum, new List<int>(), paths);
            return paths;
        }

        private static void FindPaths(TreeNode root, int sum, List<int> path, IList<IList<int>> paths)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            //int rootVal = root != null ? root.value.GetValueOrDefault() : -1;
            path.Add(root.value);
            if (root.left == null && root.right == null && sum - root.value == 0)
            {
                // Copy current path to new list, as current path object
                // is in recursive stack, and will be changing
                paths.Add(new List<int>(path));
                // Remove the current root element, as it will be last added
                path.RemoveAt(path.Count - 1); // Optimization
                return;
            }

            //int rootValue = root != null ? root.value.GetValueOrDefault() : -1;
            FindPaths(root.left, sum - root.value, path, paths);
            FindPaths(root.right, sum - root.value, path, paths);
            path.RemoveAt(path.Count - 1); // Optimization, or should pass new list in recursive call everytime
        }

        public static List<List<int>> PrintPathsStack(TreeNode root, int sum)
        {
            List<List<int>> paths = new List<List<int>>();
            Stack<int> visited = new Stack<int>();
            PreOrder(root, 0, sum, visited, paths);
            return paths;
        }

        private static void PreOrder(TreeNode root, int pathSum, int sum, Stack<int> visited,
            List<List<int>> paths)
        {
            if (root == null)
            {
                return;
            }

            //int rootVal = root != null ? root.value.GetValueOrDefault() : -1;
            pathSum = pathSum + root.value;
            visited.Push(root.value);
            if (sum == pathSum && root.left == null && root.right == null)
            {
                List<int> path = new List<int>();
                while (visited.Count > 0)
                {
                    path.Add(visited.Pop());
                }
                paths.Add(path);
            }

            // Process root
            PreOrder(root.left, pathSum, sum, visited, paths);
            PreOrder(root.right, pathSum, sum, visited, paths);

            //int rootValue = root != null ? root.value.GetValueOrDefault() : -1;
            sum = sum - root.value;
            if (visited.Count > 0)
            {
                visited.Pop();
            }
        }
    }
}
