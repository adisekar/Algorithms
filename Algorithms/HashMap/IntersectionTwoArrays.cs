using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.HashMap
{
    public class IntersectionTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums1)
            {
                set.Add(num);
            }

            HashSet<int> result = new HashSet<int>();
            foreach (var n in nums2)
            {
                if (set.Contains(n))
                {
                    result.Add(n);
                }
            }
            return result.ToArray();
        }

        // Show all numbers which intersect, not just once
        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            // kv is number unique and frequency
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var num in nums1)
            {
                if (!map.ContainsKey(num))
                {
                    map.Add(num, 1);
                }
                else
                {
                    map[num]++;
                }
            }

            List<int> result = new List<int>();
            foreach (var n in nums2)
            {
                if (map.ContainsKey(n))
                {
                    if (map[n] > 1)
                    {
                        map[n]--;
                    }
                    else
                    {
                        map.Remove(n);
                    }
                    result.Add(n);
                }
            }
            return result.ToArray();
        }
    }
}
