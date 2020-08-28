using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.BinaryTree.Traversal
{
    public class LevelOrderTraversal
    {
        public IList<IList<int?>> LevelOrder(TreeNode root)
        {
            IList<IList<int?>> result = new List<IList<int?>>();
            if (root == null)
            {
                return result;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int?> currentLevel = new List<int?>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode current = queue.Dequeue();

                    currentLevel.Add(current.value);

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }
                result.Add(currentLevel);
            }

            return result;
        }

        /* Recursive DFS approach to print in reverse. can do regular Level order and also reverse the results.
         * Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

        For example:
        Given binary tree [3,9,20,null,null,15,7],
        return its bottom-up level order traversal as:
        [
        [15,7],
        [9,20],
        [3]
        ]
        */
        public IList<IList<int?>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int?>> lists = new List<IList<int?>>();
            Level(lists, root, 0);
            return lists.Reverse().ToList();
        }

        public void Level(IList<IList<int?>> lists, TreeNode node, int level)
        {
            if (node == null) return;
            if (lists.Count == level) lists.Add(new List<int?>());
            lists[level].Add(node.value);
            Level(lists, node.left, level + 1);
            Level(lists, node.right, level + 1);
        }
    }
}
