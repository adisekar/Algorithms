using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Graph
{
    public interface IGraph
    {
        //GraphType type { get; }
        int numVertices { get; set; }
        void AddEdge(int v1, int v2);
        List<int> GetAdjacentVertices(int v);
        int GetInDegree(int v);
    }

    public enum GraphType
    {
        Directed,
        Undirected
    }
}
