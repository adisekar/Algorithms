using System;
using System.Collections.Generic;
using System.Text;
using DS.Graph;

namespace Algorithms.Graph
{
    // Traversal in graph same as tree, except there may be multiple paths and cycles
    public class DepthFirstSearch
    {
        public static void DFS(IGraph graph)
        {
            int[] visited = new int[graph.numVertices]; // Number of vertices

            // We need to loop over all vertices and call DFS Traversal method as they may be unconnected
            for (int i = 0; i < graph.numVertices; i++)
            {
                PreOrder(graph, 0, visited);
            }
        }

        private static void PreOrder(IGraph graph, int currentVertex, int[] visited)
        {
            // Base case, so we dont process nodes more than once
            if (visited[currentVertex] == 1)
            {
                return;
            }
            visited[currentVertex] = 1;

            // preOrder
            Console.WriteLine(currentVertex);

            List<int> list = graph.GetAdjacentVertices(currentVertex);
            foreach (int v in list)
            {
                PreOrder(graph, v, visited);
            }

            // post order
            //Console.WriteLine(currentVertex);
        }
    }
}
