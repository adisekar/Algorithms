using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Arrays
{
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> merged = new List<int[]>();
            // Sort by start time
            intervals = intervals.OrderBy(j => j[0]).ToArray();
            foreach (int[] interval in intervals)
            {
                // if the current interval does not overlap with the previous, simply append it.
                if (merged.Count == 0 || interval[0] > merged.Last()[1])
                {
                    merged.Add(interval);
                }
                // otherwise, there IS overlap, so we merge the current and previous intervals
                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }
            return merged.ToArray();
        }

        public static int[][] Merge2(int[][] intervals)
        {
            int n = intervals.Length;
            int[] starts = new int[n];
            int[] ends = new int[n];

            for (int i = 0; i < n; i++)
            {
                starts[i] = intervals[i][0];
                ends[i] = intervals[i][1];
            }

            Array.Sort(starts);
            Array.Sort(ends);

            // loop through
            List<int[]> res = new List<int[]>();
            // Two pointers
            int endIndex = 0, startIndex = 0;
            while (endIndex < n)
            {
                if (endIndex == n - 1 || starts[endIndex + 1] > ends[endIndex])
                {
                    res.Add(new int[] { starts[startIndex], ends[endIndex] });
                    startIndex = endIndex + 1;
                }
                endIndex++;
            }
            return res.ToArray();
        }
    }
}
