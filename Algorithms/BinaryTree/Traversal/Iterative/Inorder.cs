using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal.Iterative
{
    // Small change from preorder to change where node is printed
    public class Inorder
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (stack.Count != 0 || root != null)
            {
                // Go left
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                // Print top of stack - left most element
                root = stack.Pop();
                result.Add(root.value);
                // go right
                root = root.right;
            }
            return result;
        }
    }
}
