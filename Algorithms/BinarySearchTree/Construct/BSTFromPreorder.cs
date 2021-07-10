using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree.Construct
{
    public class BSTFromPreorder
    {
        // O(n*n) as we always start from root
        public TreeNode BstFromPreorderIterative(int[] preorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[0]);

            for (int i = 1; i < preorder.Length; i++)
            {
                TreeNode p = root;
                TreeNode q = new TreeNode(preorder[i]);

                // Traverse through the tree till we find the correct spot to insert
                while (true)
                {
                    if (q.value <= p.value)
                    {
                        if (p.left == null)
                        {
                            p.left = q;
                            break;
                        }
                        else
                        {
                            p = p.left;
                        }
                    }
                    else
                    {
                        if (p.right == null)
                        {
                            p.right = q;
                            break;
                        }
                        else
                        {
                            p = p.right;
                        }
                    }
                }
            }
            return root;
        }

        // O(n) soln
        public TreeNode BstFromPreorderRecursive(int[] preorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }
            int i = 0;
            return DFS(preorder, ref i, Int32.MaxValue);
        }

        public TreeNode DFS(int[] preorder, ref int i, int limit)
        {
            // Base case
            if (i >= preorder.Length || preorder[i] > limit)
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[i]);
            i++;
            root.left = DFS(preorder, ref i, root.value);
            root.right = DFS(preorder, ref i, limit);
            return root;
        }
    }
}
