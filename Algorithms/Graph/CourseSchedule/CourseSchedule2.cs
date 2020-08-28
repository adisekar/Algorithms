using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.CourseSchedule
{
    /*
     * Input: 4, [[1,0],[2,0],[3,1],[3,2]]
Output: [0,1,2,3] or [0,2,1,3]
Explanation: There are a total of 4 courses to take. To take course 3 you should have finished both     
             courses 1 and 2. Both courses 1 and 2 should be taken after you finished course 0. 
             So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3] .
             */
    public class CourseSchedule2
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            // Construct Graph
            Dictionary<int, HashSet<int>> adjacencySetMap = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                var prerequisite = prerequisites[i];
                for (int j = 0; j < prerequisite.Length; j++)
                {
                    var key = prerequisite[0];
                    if (adjacencySetMap.ContainsKey(key))
                    {
                        adjacencySetMap[key].Add(prerequisite[1]);
                    }
                    else
                    {
                        adjacencySetMap.Add(key, new HashSet<int>() { prerequisite[1] });
                    }
                }
            }

            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> indegreeMap = new Dictionary<int, int>();
            for (int i = 0; i < numCourses; i++)
            {
                int indegree = GetInDegree(i, adjacencySetMap, numCourses);
                indegreeMap.Add(i, indegree);
                if (indegree == 0)
                {
                    queue.Enqueue(i);
                }
            }

            List<int> sortedList = new List<int>();
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                stack.Push(vertex);
                var adjacentVerticesSet = adjacencySetMap.ContainsKey(vertex) ? adjacencySetMap[vertex] : new HashSet<int>();

                foreach (int adjacentVertex in adjacentVerticesSet)
                {
                    indegreeMap[adjacentVertex] = indegreeMap[adjacentVertex] - 1;
                    if (indegreeMap[adjacentVertex] == 0)
                    {
                        queue.Enqueue(adjacentVertex);
                    }
                }
            }

            while (stack.Count > 0)
            {
                sortedList.Add(stack.Pop());
            }

            if (sortedList.Count != numCourses)
            {
                return new int[0];
            }

            return sortedList.ToArray();
        }

        private int GetInDegree(int vertex, Dictionary<int, HashSet<int>> adjacencySetMap, int numVertices)
        {
            int indegree = 0;
            for (int i = 0; i < numVertices; i++)
            {
                if (adjacencySetMap.ContainsKey(i))
                {
                    if (adjacencySetMap[i].Contains(vertex))
                    {
                        indegree++;
                    }
                }
            }
            return indegree;
        }
    }
}
