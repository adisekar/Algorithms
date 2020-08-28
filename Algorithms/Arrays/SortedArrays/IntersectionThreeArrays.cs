using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Arrays.SortedArrays
{
    public class IntersectionThreeArrays
    {
        // Best soln O(n) time and O(1) space
        public static IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            IList<int> result = new List<int>();

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
                {
                    result.Add(arr1[i]);
                    i++;
                    j++;
                    k++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr2[j] < arr3[k])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }
            return result.ToArray();
        }

        // Other Approach to convert to Dictioanry and compare with master
        public static IList<int> ArraysIntersectionUnsorted(int[] arr1, int[] arr2, int[] arr3)
        {
            // kv is number unique and frequency
            IList<int> result = new List<int>();
            // kv is number unique and frequency
            Dictionary<int, int> masterMap = new Dictionary<int, int>();
            foreach (var num in arr1)
            {
                if (!masterMap.ContainsKey(num))
                {
                    masterMap.Add(num, 1);
                }
                else
                {
                    masterMap[num]++;
                }
            }

            Dictionary<int, int> map2 = new Dictionary<int, int>();
            foreach (var num in arr2)
            {
                if (!map2.ContainsKey(num))
                {
                    map2.Add(num, 1);
                }
                else
                {
                    map2[num]++;
                }
            }

            Dictionary<int, int> map3 = new Dictionary<int, int>();
            foreach (var num in arr3)
            {
                if (!map3.ContainsKey(num))
                {
                    map3.Add(num, 1);
                }
                else
                {
                    map3[num]++;
                }
            }

            GetIntersection(masterMap, map2);
            GetIntersection(masterMap, map3);

            foreach (var kv in masterMap)
            {
                for (int i = 0; i < kv.Value; i++)
                {
                    result.Add(kv.Key);
                }
            }
            return result.ToArray();
        }

        private static void GetIntersection(Dictionary<int, int> map, Dictionary<int, int> otherMap)
        {
            int[] keys = map.Keys.ToArray();

            foreach (var key in keys)
            {
                if (!otherMap.ContainsKey(key))
                {
                    map.Remove(key);
                }
                else
                {
                    map[key] = Math.Min(map[key], otherMap[key]);
                }
            }
        }
    }
}
