using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class Partition
    {
        public static IList<int> PartitionLabels(string s)
        {
            IList<int> result = new List<int>();

            Dictionary<char, int> lastOccurrenceMap = CreateLastOccurrenceMap(s);

            int i = 0;
            while (i < s.Length)
            {
                int end = lastOccurrenceMap[s[i]];
                int j = i;

                while (j != end)
                {
                    end = Math.Max(lastOccurrenceMap[s[j]], end);
                    j++;
                }

                result.Add(j - i + 1);
                i = j + 1;
            }
            return result;
        }

        private static Dictionary<char, int> CreateLastOccurrenceMap(string s)
        {
            Dictionary<char, int> lastOccurrenceMap = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (lastOccurrenceMap.ContainsKey(c))
                {
                    lastOccurrenceMap[c] = i;
                }
                else
                {
                    lastOccurrenceMap.Add(c, i);
                }
            }

            return lastOccurrenceMap;
        }

        // Another approach, almost same as above. Use either
        public IList<int> PartitionLabels2(string S)
        {
            int[] map = GetLastOccurrenceMap(S);
            IList<int> result = new List<int>();

            int i = 0;
            while (i < S.Length)
            {
                int index = (int)S[i] - 'a';
                int curPartition = map[index];
                // To Offset 0 based index
                curPartition += 1;

                int j = i + 1;
                while (j < curPartition)
                {
                    index = (int)S[j] - 'a';
                    if (map[index] < curPartition)
                    {
                        j++;
                    }
                    else
                    {
                        curPartition = map[index] + 1;
                    }
                }
                result.Add(j - i);

                i = j;
            }
            return result;
        }

        private int[] GetLastOccurrenceMap(string S)
        {
            int[] map = new int[26];

            for (int i = 0; i < S.Length; i++)
            {
                char c = S[i];
                int index = (int)c - 'a';
                map[index] = i;
            }
            return map;
        }
    }
}
