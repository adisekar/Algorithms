using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.N_ary
{
    public class LevelOrder
    {
        public IList<IList<int>> LevelOrderTraversal(Node root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> temp = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();

                    temp.Add(current.val);

                    if (current.children != null)
                    {
                        foreach (var child in current.children)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
                result.Add(temp);
            }
            return result;
        }
    }
}
