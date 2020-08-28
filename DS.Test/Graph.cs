using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using DS.Graph;

namespace DS.Test
{
    [TestClass]
    public class Graph
    {
        [TestMethod]
        public void AdjacencyMatrixDirectedTest()
        {
            AdjacencyMatrix matrix = new AdjacencyMatrix(5, GraphType.Directed);
            matrix.AddEdge(0, 1);
            matrix.AddEdge(0, 2);
            matrix.AddEdge(1, 3);
            matrix.AddEdge(2, 4);
            matrix.AddEdge(4, 1);
            matrix.AddEdge(4, 3);
            matrix.PrintGraph();

            List<int> adjacentVertices = matrix.GetAdjacentVertices(3);

            foreach (int i in adjacentVertices)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void AdjacencyMatrixUndirectedTest()
        {
            AdjacencyMatrix matrix = new AdjacencyMatrix(5, GraphType.Undirected);
            matrix.AddEdge(0, 1);
            matrix.AddEdge(0, 2);
            matrix.AddEdge(1, 3);
            matrix.AddEdge(2, 4);
            matrix.AddEdge(4, 1);
            matrix.AddEdge(4, 3);
            matrix.PrintGraph();

            List<int> adjacentVertices = matrix.GetAdjacentVertices(3);

            foreach (int i in adjacentVertices)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void AdjacencyListDirectedTest()
        {
            AdjacencyList list = new AdjacencyList(5, GraphType.Directed);
            list.AddEdge(0, 1);
            list.AddEdge(0, 2);
            list.AddEdge(1, 3);
            list.AddEdge(2, 4);
            list.AddEdge(4, 1);
            list.AddEdge(4, 3);
            list.PrintGraph();

            List<int> adjacentVertices = list.GetAdjacentVertices(3);

            foreach (int i in adjacentVertices)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void AdjacencyListUndirectedTest()
        {
            AdjacencyList list = new AdjacencyList(5, GraphType.Undirected);
            list.AddEdge(0, 1);
            list.AddEdge(0, 2);
            list.AddEdge(1, 3);
            list.AddEdge(2, 4);
            list.AddEdge(4, 1);
            list.AddEdge(4, 3);
            list.PrintGraph();

            List<int> adjacentVertices = list.GetAdjacentVertices(3);

            foreach (int i in adjacentVertices)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void AdjacencyMatrixGetIndegree()
        {
            AdjacencyMatrix matrix = new AdjacencyMatrix(5, GraphType.Directed);
            matrix.AddEdge(0, 1);
            matrix.AddEdge(0, 2);
            matrix.AddEdge(1, 3);
            matrix.AddEdge(2, 4);
            matrix.AddEdge(4, 1);
            matrix.AddEdge(4, 3);
            matrix.PrintGraph();

            for (int i = 0; i < matrix.numVertices; i++)
            {
                int inDegree = matrix.GetInDegree(i);
                Console.WriteLine("Indegree of " + i + " = " + inDegree);
            }
        }

        [TestMethod]
        public void AdjacencyListGetIndegree()
        {
            AdjacencyList list = new AdjacencyList(5, GraphType.Directed);
            list.AddEdge(0, 1);
            list.AddEdge(0, 2);
            list.AddEdge(1, 3);
            list.AddEdge(2, 4);
            list.AddEdge(4, 1);
            list.AddEdge(4, 3);
            list.PrintGraph();

            for (int i = 0; i < list.numVertices; i++)
            {
                int inDegree = list.GetInDegree(i);
                Console.WriteLine("Indegree of " + i + " = " + inDegree);
            }
        }

        [TestMethod]
        public void AdjacencyMatrixSort()
        {
            AdjacencyMatrix matrix = new AdjacencyMatrix(5, GraphType.Directed);
            matrix.AddEdge(0, 1);
            matrix.AddEdge(0, 2);
            matrix.AddEdge(1, 3);
            matrix.AddEdge(2, 4);
            matrix.AddEdge(4, 1);
            matrix.AddEdge(4, 3);
            matrix.PrintGraph();

            List<int> result = TopologicalSort.Sort(matrix);
            foreach (var vertex in result)
            {
                Console.Write(vertex + " ");
            }
        }

    }
}
