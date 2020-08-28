using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Flatten
{
    public class BTtoDLinkedListInOrder
    {
        private static TreeNode prev = null;
        private static TreeNode head = null;
        public TreeNode Flatten(TreeNode root)
        {
            FlattenTree(root);
            return head;
        }

        // Only In Order can be done by this approach
        private void FlattenTree(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            FlattenTree(root.left);
            // Process current node
            if (prev == null)
            {
                head = root;
            }
            else
            {
                root.left = prev;
                prev.right = root;
            }
            prev = root;
            FlattenTree(root.right);
        }
    }
}
