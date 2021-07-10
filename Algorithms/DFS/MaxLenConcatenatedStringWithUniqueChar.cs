using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DFS
{
    public class MaxLenConcatenatedStringWithUniqueChar
    {
        public int MaxLength(IList<string> arr)
        {
            int[] res = new int[1];
            MaxLen(arr, 0, "", res);
            return res[0];
        }

        private void MaxLen(IList<string> arr, int idx, string curr, int[] res)
        {
            int uniqueCharLength = UniqueCharCount(curr);
            if (idx == arr.Count && uniqueCharLength > res[0])
            {
                res[0] = uniqueCharLength;
                return;
            }

            if (idx == arr.Count)
            {
                return;
            }

            if (uniqueCharLength == -1) { return; }

            MaxLen(arr, idx + 1, curr, res);
            MaxLen(arr, idx + 1, curr + arr[idx], res);
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
