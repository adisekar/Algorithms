using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal
{
    public class IterativeInOrder
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var current = root;

            while (true)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                if (stack.Count == 0)
                {
                    break;
                }
                current = stack.Pop();
                result.Add(current.value);
                current = current.right;
            }
            return result;
        }
    }
}
