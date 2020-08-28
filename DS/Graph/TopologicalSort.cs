using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Graph
{
    public class TopologicalSort
    {
        public static List<int> Sort(IGraph graph)
        {
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> indegreeMap = new Dictionary<int, int>();
            for (int i = 0; i < graph.numVertices; i++)
            {
                int indegree = graph.GetInDegree(i);
                indegreeMap.Add(i, indegree);
                if (indegree == 0)
                {
                    queue.Enqueue(i);
                }
            }

            List<int> sortedList = new List<int>();
            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                sortedList.Add(vertex);

                List<int> adjacentVertices = graph.GetAdjacentVertices(vertex);

                foreach (int adjacentVertex in adjacentVertices)
                {
                    indegreeMap[adjacentVertex] = indegreeMap[adjacentVertex] - 1;
                    if (indegreeMap[adjacentVertex] == 0)
                    {
                        queue.Enqueue(adjacentVertex);
                    }
                }
            }

            if (sortedList.Count != graph.numVertices)
            {
                throw new Exception("Graph has a cycle");
            }
            return sortedList;
        }
    }
}
