using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Flatten
{
    public class BTtoDLinkedListBFS
    {
        public static TreeNode FlattenTree(TreeNode root)
        {
            TreeNode prev = null;
            TreeNode head = null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                // Create new node everytime
                TreeNode p = q.Dequeue();
                TreeNode curr = new TreeNode(p.value);

                if (prev == null)
                {
                    head = curr;
                }
                else
                {
                    curr.left = prev;
                    prev.right = curr;
                }
                prev = curr;

                if (p.left != null && p.left.value != -1)
                {
                    q.Enqueue(p.left);
                }

                if (p.right != null && p.right.value != -1)
                {
                    q.Enqueue(p.right);
                }
            }
            return head;
        }

        public static TreeNode FlattenTreeInPlace(TreeNode root)
        {
            TreeNode prev = null;
            TreeNode head = null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                // Create new node everytime
                TreeNode p = q.Dequeue();

                if (p.left != null && p.left.value != -1)
                {
                    q.Enqueue(p.left);
                }

                if (p.right != null && p.right.value != -1)
                {
                    q.Enqueue(p.right);
                }

                if (prev == null)
                {
                    head = p;
                }
                else
                {
                    p.left = prev;
                    prev.right = p;
                }
                prev = p;
            }
            return head;
        }
    }
}
