using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Greedy
{
    public class TaskScheduler
    {
        public static int LeastInterval(char[] tasks, int n)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (var task in tasks)
            {
                if (map.ContainsKey(task))
                {
                    map[task]++;
                }
                else
                {
                    map.Add(task, 1);
                }
            }

            var sortedMap = map.OrderByDescending(m => m.Value).ToDictionary(pair => pair.Key, pair => pair.Value); ;

            var list = sortedMap.Keys.ToList();

            int result = 0;
            while (map.Count > 0)
            {
                var countList = new List<char>();
                foreach (var item in list)
                {
                    countList.Add(item);
                    if (map[item] > 1)
                    {
                        map[item]--;
                    }
                    else
                    {
                        map.Remove(item);
                    }
                }
                if (map.Count > 1)
                    result += countList.Count * n;
            }
            return result;
        }
    }
}
