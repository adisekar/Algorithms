using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal
{
    public class ZigZagSpiral
    {
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null || root.value == -1)
            {
                return result;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            Stack<int> stack = new Stack<int>();
            int level = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                IList<int> levelList = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (level % 2 == 0)
                    {
                        levelList.Add(current.value);
                    }

                    if (level % 2 == 1)
                    {
                        stack.Push(current.value);
                    }

                    if (current.left != null && current.left.value != -1)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null && current.right.value != -1)
                    {
                        queue.Enqueue(current.right);
                    }
                }
                while (stack.Count > 0)
                {
                    levelList.Add(stack.Pop());
                }
                level++;
                result.Add(levelList);
            }
            return result;
        }
    }
}
