using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoPointers
{
    public class MinAbsDiff
    {
        // First sort, so minimum diff is next to each other
        // 2 passes. first pass get smallest diff in array
        // 2nd pass. For all elements matching smallest, add to list
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            IList<IList<int>> result = new List<IList<int>>();
            int smallestDiff = Int32.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallestDiff = Math.Min(smallestDiff, Math.Abs(arr[i + 1] - arr[i]));
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i + 1] - arr[i]) == smallestDiff)
                {
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }
            return result;
        }
    }
}
