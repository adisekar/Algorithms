using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class Insert
    {
        // Iterative
        public TreeNode InsertIntoBSTIterative(TreeNode root, int val)
        {
            // Iterative

            TreeNode r = null;
            TreeNode t = root;
            while (t != null)
            {
                if (t.value == val) { return root; }

                if (t.value < val)
                {
                    r = t;
                    t = t.right;
                }
                else
                {
                    r = t;
                    t = t.left;
                }
            }
            TreeNode newNode = new TreeNode(val);
            if (r != null)
            {
                if (r.value < newNode.value)
                {
                    r.right = newNode;
                }
                else
                {
                    r.left = newNode;
                }
                return root;
            }
            else
            {
                return newNode;
            }
        }

        public TreeNode InsertIntoBSTRecursive(TreeNode root, int val)
        {
            // Recursive
            TreeNode t = root;
            var node = RecursiveInsert(t, val);
            return root != null ? root : node;
        }

        // Recurse till node is null, that is the spot to insert
        // return the inserted node to left or right child of parent
        private TreeNode RecursiveInsert(TreeNode t, int val)
        {
            if (t == null)
            {
                var newNode = new TreeNode(val);
                return newNode;
            }
            if (t.value < val)
            {
                t.right = RecursiveInsert(t.right, val);
            }
            else
            {
                t.left = RecursiveInsert(t.left, val);
            }
            return t;
        }
    }
}
