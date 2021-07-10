using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.HashMap
{
    public class TimeMap
    {
        Dictionary<string, Dictionary<int, string>> map;
        /** Initialize your data structure here. */
        public TimeMap()
        {
            map = new Dictionary<string, Dictionary<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (map.ContainsKey(key))
            {
                var timeMap = map[key];
                if (timeMap.ContainsKey(timestamp))
                {
                    timeMap[timestamp] = value;
                }
                else
                {
                    timeMap.Add(timestamp, value);
                }
            }
            else
            {
                map.Add(key, new Dictionary<int, string>() { { timestamp, value } });
            }
        }

        public string Get(string key, int timestamp)
        {
            if (map.ContainsKey(key))
            {
                var timeMap = map[key];
                if (timeMap.ContainsKey(timestamp))
                {
                    return timeMap[timestamp];
                }
                else
                {
                    // Order the timestamps, in ascending order
                    var orderedTimeMap = timeMap.OrderBy(k => k.Key);
                    string prev = "";
                    foreach (var kv in orderedTimeMap)
                    {
                        if (kv.Key > timestamp)
                        {
                            break;
                        }
                        else
                        {
                            prev = kv.Value;
                        }
                    }
                    return prev;
                }
            }
            else
            {
                return "";
            }
        }
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */