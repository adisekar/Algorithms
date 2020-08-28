using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Graph
{
    public class AdjacencyList : IGraph
    {
        public int numVertices { get; set; } = 0;
        public List<Node> vertexList { get; set; }
        public GraphType type { get; set; } = GraphType.Undirected;

        public AdjacencyList(int numVertices, GraphType type)
        {
            this.numVertices = numVertices;
            this.type = type;

            this.vertexList = new List<Node>();

            for (int i = 0; i < numVertices; i++)
            {
                vertexList.Add(new Node(i));
            }
        }

        public void AddEdge(int v1, int v2)
        {
            if ((v1 < 0 || v1 > numVertices) || (v2 < 0 || v2 > numVertices))
            {
                throw new Exception("Number of Vertices outside the range");
            }
            Node v1Node = vertexList.Find(n => n.vertexId == v1);
            v1Node.AddEdge(v2);

            if (type == GraphType.Undirected)
            {
                Node v2Node = vertexList.Find(n => n.vertexId == v2);
                v2Node.AddEdge(v1);
            }
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
                if (GetAdjacentVertices(i).Contains(v))
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
                Node node = vertexList[i];
                Console.Write(node.vertexId);

                if (node.GetAdjacentVertices().Count > 0)
                {
                    for (int j = 0; j < node.GetAdjacentVertices().Count; j++)
                    {
                        Console.Write("-> " + node.GetAdjacentVertices()[j]);
                    }
                }
                Console.WriteLine();
            }
        }

        public List<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v > numVertices)
            {
                throw new Exception("Number of Vertices outside the range");
            }

            return vertexList[v].GetAdjacentVertices();
        }
    }
}
