using System;
using System.Collections.Generic;
using System.Text;
using DS.BinaryTree;

namespace Algorithms.BinaryTree
{
    public class DepthFirstSearch
    {
        // Depth First Search DFS has 3 types preOrder, inOrder, postOrder
        public static void PreOrder(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return;
            }
            Console.WriteLine(root.value);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public static void InOrder(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return;
            }
            // Ascending Order
            InOrder(root.left);
            Console.WriteLine(root.value);
            InOrder(root.right);
        }

        public static void PostOrder(TreeNode root)
        {
            if (root == null || root.value == -1)
            {
                return;
            }
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.value);
        }
    }
}
