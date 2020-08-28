using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Graph
{
    // Used for Adjacency List and Adjacency Set
    public class Node
    {
        public int vertexId { get; set; }
        private List<int> adjacencyList = new List<int>();

        public Node(int vertexId)
        {
            this.vertexId = vertexId;
        }

        public void AddEdge(int vertexId)
        {
            this.adjacencyList.Add(vertexId);
        }

        public List<int> GetAdjacentVertices()
        {
            return this.adjacencyList.OrderBy(l => l).ToList();
        }
    }
}
