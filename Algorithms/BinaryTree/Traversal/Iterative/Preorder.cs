using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal.Iterative
{
    public class Preorder
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;

            while (node != null || stack.Count > 0)
            {
                if (node != null)
                {
                    result.Add(node.value);

                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    node = stack.Pop();
                    node = node.right;
                }
            }

            return result;
        }

    }
}
