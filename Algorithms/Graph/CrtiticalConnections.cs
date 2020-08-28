using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    class CrtiticalConnections
    {
        // Simple way to find indegree of each vertex, and 
        // Vertex with indegree of 1, is the connection
        // will not work for graph with cycles.
        public static IList<IList<int>> FindCriticalConnectionsWithoutCycles(int n, IList<IList<int>> connections)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var connection in connections)
            {
                foreach (var val in connection)
                {
                    if (map.ContainsKey(val))
                    {
                        map[val]++;
                    }
                    else
                    {
                        map.Add(val, 1);
                    }
                }
            }

            foreach (var kv in map)
            {
                if (kv.Value == 1)
                {
                    foreach (var connection in connections)
                    {
                        if (connection[0] == kv.Key || connection[1] == kv.Key)
                        {
                            result.Add(connection);
                        }
                    }
                }
            }
            return result;
        }

        public static IList<IList<int>> FindCriticalConnections(int n, IList<IList<int>> connections)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, HashSet<int>> adjacencySet = GetAdjacencyList(connections);

            foreach (var connection in connections)
            {
                int from = connection[0];
                int to = connection[1];

                // Remove the current connection from adjacency list
                // and try if we can still reach all nodes
                adjacencySet[from].Remove(to);
                adjacencySet[to].Remove(from);

                bool[] visited = new bool[n];
                // Start from 0 vertex
                DFS(adjacencySet, visited, 0);

                //Now check if all vertices are visited
                bool isConnected = true;
                foreach (var v in visited)
                {
                    if (v == false)
                    {
                        isConnected = false;
                    }
                }
                if (!isConnected)
                {
                    result.Add(connection);
                }
                /* add the removed edge back into the list for next iteration */
                adjacencySet[from].Add(to);
                adjacencySet[to].Add(from);
            }
            return result;
        }

        private static void DFS(Dictionary<int, HashSet<int>> adjacencyList, bool[] visited, int vertex)
        {
            visited[vertex] = true;

            foreach (var v in adjacencyList[vertex])
            {
                if (!visited[v])
                {
                    DFS(adjacencyList, visited, v);
                }
            }
        }

        private static Dictionary<int, HashSet<int>> GetAdjacencyList(IList<IList<int>> connections)
        {
            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
            foreach (var connection in connections)
            {
                int from = connection[0];
                int to = connection[1];

                // from to To
                if (map.ContainsKey(from))
                {
                    map[from].Add(to);
                }
                else
                {
                    map.Add(from, new HashSet<int> { to });
                }
                // To to From. Undirected
                if (map.ContainsKey(to))
                {
                    map[to].Add(from);
                }
                else
                {
                    map.Add(to, new HashSet<int> { from });
                }
            }
            return map;
        }
    }
}