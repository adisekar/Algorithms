using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class KDistance
    {
        public static IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            Dictionary<TreeNode, TreeNode> nodeParentMap = GetNodeParentMap(root);

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(target);
            IList<int> result = new List<int>();
            bool[] visited = new bool[10];
            int level = 0;
            while (queue.Count > 0)
            {
                level++;
                int size = queue.Count;
                if (level - 1 == K)
                {
                    while (queue.Count > 0)
                    {
                        TreeNode queueNode = queue.Dequeue();
                        if (queueNode != null && queueNode.value != -1 && !visited[queueNode.value])
                        {
                            result.Add(queueNode.value);
                        }
                    }
                    break;
                }
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    visited[current.value] = true;

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }

                    if (nodeParentMap.ContainsKey(current) && nodeParentMap[current] != null
                        && !visited[nodeParentMap[current].value])
                    {
                        queue.Enqueue(nodeParentMap[current]);
                    }
                }
            }
            return result;
        }


        public static Dictionary<TreeNode, TreeNode> GetNodeParentMap(TreeNode root)
        {
            Dictionary<TreeNode, TreeNode> nodeParentMap = new Dictionary<TreeNode, TreeNode>();
            Preorder(root, nodeParentMap, null);

            return nodeParentMap;

        }
        private static void Preorder(TreeNode root, Dictionary<TreeNode, TreeNode> nodeParentMap, TreeNode prev)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            if (root.value != -1 && !nodeParentMap.ContainsKey(root))
            {
                nodeParentMap.Add(root, prev != null ? prev : null);
            }

            prev = root;
            Preorder(root.left, nodeParentMap, prev);
            Preorder(root.right, nodeParentMap, prev);
        }

        // K distance of nodes, using graph
        public static IList<int> DistanceKUsingGraph(TreeNode root, TreeNode target, int K)
        {
            int[,] matrix = ConvertToGraph.AdjacencyMatrixGraph(root);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(target);
            IList<int> result = new List<int>();
            bool[] visited = new bool[10];
            int level = 0;
            while (queue.Count > 0)
            {
                level++;
                int size = queue.Count;
                if (level - 1 == K)
                {
                    while (queue.Count > 0)
                    {
                        TreeNode queueNode = queue.Dequeue();
                        if (queueNode != null && queueNode.value != -1 && !visited[queueNode.value])
                        {
                            result.Add(queueNode.value);
                        }
                    }
                    break;
                }
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    visited[current.value] = true;

                    List<int> adjacentVertices = GetAdjacentVertices(current.value, CountNodes.Count(root), matrix);

                    if (adjacentVertices.Count > 0)
                    {
                        foreach (var vertex in adjacentVertices)
                        {
                            if (!visited[vertex])
                            {
                                TreeNode currentNode = SearchTree.FindTargetNode(root, vertex);
                                queue.Enqueue(currentNode);
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static List<int> GetAdjacentVertices(int v, int numVertices, int[,] adjacencyMatrix)
        {
            List<int> verticesList = new List<int>();
            for (int i = 0; i < numVertices; i++)
            {
                if (adjacencyMatrix[v, i] == 1)
                {
                    verticesList.Add(i);
                }
            }
            return verticesList.OrderBy(l => l).ToList();
        }
    }
}
