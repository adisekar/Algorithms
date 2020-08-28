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
            List<List<string>> partitions = new List<List<string>>();

            Dictionary<char, int> lastOccurrenceMap = CreateLastOccurrenceMap(s);

            int i = 0;
            while (i < s.Length)
            {
                char c = s[i];
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

    }

   
}

