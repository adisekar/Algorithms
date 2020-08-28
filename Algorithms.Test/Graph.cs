using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.Graph;
using DS.Graph;
using Algorithms.Graph.CourseSchedule;

namespace Algorithms.Test
{
    [TestClass]
    public class Graph
    {
        [TestMethod]
        public void DFS()
        {
            AdjacencyMatrix graph = new AdjacencyMatrix(5, GraphType.Directed);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(4, 1);
            graph.AddEdge(4, 3);

            DepthFirstSearch.DFS(graph);
        }

        [TestMethod]
        public void BFS()
        {
            AdjacencyMatrix graph = new AdjacencyMatrix(5, GraphType.Directed);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(4, 1);
            graph.AddEdge(4, 3);

            BreadthFirstSearch.BFS(graph);
        }

        [TestMethod]
        public void FindShortestPath()
        {
            AdjacencyMatrix graph = new AdjacencyMatrix(4, GraphType.Directed);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 3);

            ShortestPath.FindPath(0, 3, graph);
        }

        [TestMethod]
        public void CourseSchedule1()
        {
            int[][] prerequisites = new int[][] { new int[] { 1, 0 } };
            int numCourses = 2;
            CourseSchedule1 cs = new CourseSchedule1();
            var result = cs.CanFinish(numCourses, prerequisites);
            Assert.AreEqual(result, true);
        }
    }
}
