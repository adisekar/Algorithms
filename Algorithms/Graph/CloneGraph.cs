using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    public class CloneGraph
    {
        public Node BFS(Node node)
        {
            if (node == null)
            {
                return node;
            }

            // All original node in queue, used to track edges
            Queue<Node> queue = new Queue<Node>();
            // Mapping between original and cloned nodes
            Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
            queue.Enqueue(node);
            // Create new cloned node
            visited.Add(node, new Node(node.val, new List<Node>()));

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();

                foreach (var neighbor in curr.neighbors)
                {
                    // Clone the neighbor and put in the visited, if not present already
                    if (!visited.ContainsKey(neighbor))
                    {
                        visited.Add(neighbor, new Node(neighbor.val, new List<Node>()));
                        queue.Enqueue(neighbor);
                    }
                    // Add the clone of the neighbor to the neighbors of the clone node "n".
                    visited[curr].neighbors.Add(visited[neighbor]);
                }

            }
            return visited[node];
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;
        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }
        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }
        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
