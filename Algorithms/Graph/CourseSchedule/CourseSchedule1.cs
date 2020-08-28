using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.CourseSchedule
{
    /*
     * Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
             To take course 1 you should have finished course 0. So it is possible.
Example 2:

Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
Output: false
Explanation: There are a total of 2 courses to take. 
             To take course 1 you should have finished course 0, and to take course 0 you should
             also have finished course 1. So it is impossible.
             */

    // Can be done by Topological Sorting (CourseSchedule 2) but overkill for this
    public class CourseSchedule1
    {
        // 0 = Unvisited
        // 1 = Processed
        // 2 = Processing
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            // Construct Graph
            Dictionary<int, List<int>> adjacencySetMap = new Dictionary<int, List<int>>();

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
                        adjacencySetMap.Add(key, new List<int>() { prerequisite[1] });
                    }
                }
            }

            int[] visited = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                if (visited[i] == 0)
                {
                    if (IsCyclic(adjacencySetMap, visited, i))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsCyclic(Dictionary<int, List<int>> adjacencySetMap, int[] visited, int curr)
        {
            if (visited[curr] == 2)
            {
                return true;
            }

            visited[curr] = 2;
            if (adjacencySetMap.ContainsKey(curr))
            {
                for (int i = 0; i < adjacencySetMap[curr].Count; i++)
                {
                    var currVertexAdjacentList = adjacencySetMap[curr];
                    if (visited[currVertexAdjacentList[i]] != 1)
                    {
                        if (IsCyclic(adjacencySetMap, visited, currVertexAdjacentList[i]))
                        {
                            return true;
                        }
                    }
                }
            }
            visited[curr] = 1;
            return false;
        }
    }
}
