using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class SumRootToLeaf
    {
        private static int sum = 0;
        //private static string str = "";
        public static int SumNumbers(TreeNode root)
        {
            DFS(root, "");
            return sum;
        }

        private static void DFS(TreeNode root, string str)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            str += root.value;

            if (root.left == null && root.right == null && str.Length > 0)
            {
                int currentPathVal = Convert.ToInt32(str);
                sum += currentPathVal;

                str = str.Remove(str.Length - 1);
            }
            DFS(root.left, str);
            DFS(root.right, str);
            str = str.Length > 0 ? str.Remove(str.Length - 1) : str;
        }
    }
}
