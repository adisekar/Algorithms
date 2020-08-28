using DS.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    public class BreadthFirstSearch
    {
        public static void BFS(IGraph graph)
        {
            int[] visited = new int[graph.numVertices]; // Number of vertices

            // We need to loop over all vertices and call BFS Traversal method as they may be unconnected
            for (int i = 0; i < graph.numVertices; i++)
            {
                Traversal(graph, i, visited);
            }
        }

        // Using Queue, we need to maintain visited list, as graph may have cycles
        private static void Traversal(IGraph graph, int startVertex, int[] visited)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();

                // This vertex already has been processed
                if (visited[currentVertex] == 1)
                {
                    continue;
                }
                // process the Dequeued Node
                Console.WriteLine(currentVertex);
                visited[currentVertex] = 1;

                List<int> adjacentVertices = graph.GetAdjacentVertices(currentVertex);
                if (adjacentVertices.Count > 0)
                {
                    foreach (int vertex in adjacentVertices)
                    {
                        if (visited[vertex] != 1)
                        {
                            queue.Enqueue(vertex);
                        }
                    }
                }
            }
        }

    }
}
