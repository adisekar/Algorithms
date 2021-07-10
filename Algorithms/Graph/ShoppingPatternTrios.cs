using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    public class ShoppingPatternTrios
    {
        private static int GetMinCount(int productNodes, List<int> productsFrom, List<int> productsTo)
        {
            Dictionary<int, HashSet<int>> adjacencySet = GetAdjacencySet(productsFrom, productsTo);
            return -1;
        }
        private static Dictionary<int, HashSet<int>> GetAdjacencySet(List<int> productsFrom, List<int> productTo)
        {
            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
            for(int i = 0; i< productsFrom.Count; i++)
            {
                var from = productsFrom[i];
                var to = productTo[i];
                // from to To
                if (map.ContainsKey(from))
                {
                    map[from].Add(to);
                }
                else
                {
                    map.Add(from, new HashSet<int>() { to });
                }
                // To to From
                // Hashset will only keep unique values
                if (map.ContainsKey(to))
                {
                    map[to].Add(from);
                }
                else
                {
                    map.Add(to, new HashSet<int>() { from });
                }
            }
            return map;
        }
    }
}
