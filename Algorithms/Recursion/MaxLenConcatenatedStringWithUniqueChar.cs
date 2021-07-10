using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class MaxLenConcatenatedStringWithUniqueChar
    {
        static int res = 0;
        public int MaxLength(IList<string> arr)
        {
            MaxLen(arr, 0, "");
            return res;
        }

        private void MaxLen(IList<string> arr, int idx, string curr)
        {
            if (idx == arr.Count && UniqueCharCount(curr) > res)
            {
                res = UniqueCharCount(curr);
                return;
            }

            if (idx == arr.Count)
            {
                return;
            }

            for (int i = idx; i < arr.Count; i++)
            {
                MaxLen(arr, i + 1, curr + arr[idx]);
            }
        }

        private int UniqueCharCount(string s)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (var c in s)
            {
                if (set.Contains(c))
                {
                    return -1;
                }
                else
                {
                    set.Add(c);
                }
            }
            return s.Length;
        }
    }
}
