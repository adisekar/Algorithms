using DS.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    // BFS always returns shortest path. Use BFS with path[] to get shortest path
    public class ShortestPath
    {
        // Start node S, end node E
        public static void FindPath(int start, int end, IGraph graph)
        {
            int[] prev = Solve(start, end, graph);

            List<int> path = ReconstructPath(prev, start, end);
            foreach (int n in path)
            {
                Console.WriteLine(n);
            }
        }

        private static List<int> ReconstructPath(int[] prev, int start, int end)
        {
            List<int> path = new List<int>();
            // We will start from end of prev array, and move to index of each prev value
            int i = end;
            while(i != -1)
            {
                path.Add(i);
                i = prev[i];
            }
            path.Reverse();

            if (path[0] == start)
            {
                return path;
            } // Else start and end nodes are not connected
            return new List<int>();
        }

        private static int[] Solve(int start, int end, IGraph graph)
        {
            int[] visited = new int[graph.numVertices]; // Number of vertices
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            int[] prev = new int[graph.numVertices];
            // Set default values to -1 of prev element array
            for (int i = 0; i < graph.numVertices; i++)
            {
                prev[i] = -1;
            }

            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();
                if (visited[currentVertex] == 1)
                {
                    continue;
                }

                // Process node
                visited[currentVertex] = 1;

                List<int> adjacentVertices = graph.GetAdjacentVertices(currentVertex);
                if (adjacentVertices.Count > 0)
                {
                    foreach (var vertex in adjacentVertices)
                    {
                        if (visited[vertex] != 1)
                        {
                            queue.Enqueue(vertex);
                            prev[vertex] = currentVertex;
                        }
                    }
                }
            }
            return prev;
        }
    }
}
