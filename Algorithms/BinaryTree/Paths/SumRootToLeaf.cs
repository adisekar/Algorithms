using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class SumRootToLeaf
    {
        public int SumNumbers(TreeNode root)
        {
            List<List<int>> paths = new List<List<int>>();
            List<int> path = new List<int>();
            FindPaths(root, path, paths);

            int sum = 0;
            foreach (var curPath in paths)
            {
                string curPathSum = "";
                foreach (var val in curPath)
                {
                    curPathSum += val;
                }
                sum += Convert.ToInt32(curPathSum);
            }
            return sum;
        }

        private void FindPaths(TreeNode root, List<int> path, List<List<int>> paths)
        {
            if (root == null) { return; }

            if (root.left == null && root.right == null)
            {
                path.Add(root.value);
                paths.Add(new List<int>(path));
                path.RemoveAt(path.Count - 1);
                return;
            }

            path.Add(root.value);
            FindPaths(root.left, path, paths);
            FindPaths(root.right, path, paths);
            path.RemoveAt(path.Count - 1);
        }
    }
}
