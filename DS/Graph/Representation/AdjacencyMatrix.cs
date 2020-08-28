using System;
using System.Collections.Generic;
using System.Linq;

namespace DS.Graph
{
    public class AdjacencyMatrix : IGraph
    {
        public int numVertices { get; set; } = 0;
        public int[,] adjacencyMatrix { get; set; }
        public GraphType type { get; set; } = GraphType.Undirected;

        // Adjacency Matrix Implementation. Constructor initialize to 0
        public AdjacencyMatrix(int numVertices, GraphType type)
        {
            this.numVertices = numVertices;
            this.type = type;

            adjacencyMatrix = new int[numVertices, numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    adjacencyMatrix[i, j] = 0;
                }
            }
        }

        public void AddEdge(int v1, int v2)
        {
            // Check boundary conditions
            if ((v1 < 0 || v1 > numVertices) || (v2 < 0 || v2 > numVertices))
            {
                throw new Exception("Number of Vertices outside the range");
            }
            adjacencyMatrix[v1, v2] = 1;
            if (type == GraphType.Undirected)
            {
                adjacencyMatrix[v2, v1] = 1;
            }
        }

        public List<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v > numVertices)
            {
                throw new Exception("Number of Vertices outside the range");
            }

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

        public int GetInDegree(int v)
        {
            if (v < 0 || v > numVertices)
            {
                throw new Exception("Number of Vertices outside the range");
            }

            int indegree = 0;
            for (int i = 0; i < numVertices; i++)
            {
                if (adjacencyMatrix[i, v] == 1)
                {
                    indegree++;
                }
            }

            return indegree;
        }

        public void PrintGraph()
        {
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(adjacencyMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
