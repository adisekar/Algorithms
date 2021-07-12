using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class TwoSumBST
    {
        // Soln 1
        HashSet<int> set = new HashSet<int>();
        public bool FindTargetRecursive(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }

            if (set.Contains(k - root.value))
            {
                return true;
            }
            else
            {
                set.Add(root.value);
            }
            return FindTargetRecursive(root.left, k) || FindTargetRecursive(root.right, k);
        }

        // Soln 2
        public static bool FindTargetBFS(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            HashSet<int> set = new HashSet<int>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var node = q.Dequeue();

                if (set.Contains(k - node.value))
                {
                    return true;
                }
                else
                {
                    set.Add(node.value);
                }

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }
            return false;
        }

        List<int> list = new List<int>();

        // Soln 3
        public bool FindTargetInorder(TreeNode root, int k)
        {
            Inorder(root);

            int l = 0;
            int r = list.Count - 1;

            while (l < r)
            {
                int sum = list[l] + list[r];
                if (sum == k)
                {
                    return true;
                }
                else if (sum > k)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
            return false;
        }

        private void Inorder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.left);
            list.Add(root.value);
            Inorder(root.right);
        }
    }
}
