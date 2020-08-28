using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.BinaryTree.Traversal
{
    public class VerticalOrder
    {
        // Root is 0 position, left is -1 and right is +1
        // Use hashtable to store order and List of nodes in that order
        // Find Horizontal distance by doing BFS
        public static IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null || root.value == -1)
            {
                return result;
            }
            Queue<NodeOrder> queue = new Queue<NodeOrder>();
            queue.Enqueue(new NodeOrder(root, 0));

            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            map.Add(0, new List<int>() { root.value });

            while (queue.Count > 0)
            {
                var currentNodeOrderObj = queue.Dequeue();

                var currentNode = currentNodeOrderObj.Node;
                var currentNodeOrder = currentNodeOrderObj.Order;

                if (currentNode.left != null && currentNode.left.value != -1)
                {
                    var currentNodeLeft = currentNode.left;
                    var currentNodeLeftOrder = currentNodeOrder - 1;

                    if (map.ContainsKey(currentNodeLeftOrder))
                    {
                        map[currentNodeLeftOrder].Add(currentNodeLeft.value);
                    }
                    else
                    {
                        map[currentNodeLeftOrder] = new List<int>() { currentNodeLeft.value };
                    }
                    queue.Enqueue(new NodeOrder(currentNodeLeft, currentNodeLeftOrder));
                }

                if (currentNode.right != null && currentNode.right.value != -1)
                {
                    var currentNodeRight = currentNode.right;
                    var currentNodeRightOrder = currentNodeOrder + 1;

                    if (map.ContainsKey(currentNodeRightOrder))
                    {
                        map[currentNodeRightOrder].Add(currentNodeRight.value);
                    }
                    else
                    {
                        map[currentNodeRightOrder] = new List<int>() { currentNodeRight.value };
                    }
                    queue.Enqueue(new NodeOrder(currentNodeRight, currentNodeRightOrder));
                }
            }

            var sortedDict = map.OrderBy(kv => kv.Key);
            foreach (var kv in sortedDict)
            {
                var sortedValuesList = kv.Value.OrderBy(v => v);
                result.Add(new List<int>(sortedValuesList));
            }
            return result;
        }
    }

    public class NodeOrder
    {
        public TreeNode Node { get; set; }
        public int Order { get; set; }

        public NodeOrder(TreeNode node, int order)
        {
            this.Node = node;
            this.Order = order;
        }
    }
}
