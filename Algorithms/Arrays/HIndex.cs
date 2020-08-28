using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Arrays
{
    public class HIndex
    {
        public static int HIndex1(int[] citations)
        {
            // sorting the citations in ascending order
            Array.Sort(citations);

            int h = 0;
            // finding h-index by linear search
            for (int i = 0; i < citations.Length; i++)
            {
                var citation = citations[i];
                if (citation >= citations.Length - i)
                {
                    h = Math.Max(h, citations.Length - i);
                }
            }
            return h;
        }

        // Alternate using Descending
        public static int HIndex1Desc(int[] citations)
        {
            // sorting the citations in descending order
            var desc = citations.OrderByDescending(c => c).ToArray();

            int h = 0;
            // finding h-index by linear search
            for (int i = 0; i < desc.Length; i++)
            {
                var citation = desc[i];
                if (citation >= i + 1)
                {
                    h = Math.Max(h, i + 1);
                }
            }
            return h;
        }

        // Already Sorted Citations, use Linear or Binary Search
        public static int HIndex2(int[] citations)
        {
            int h = 0;
            // finding h-index by linear search
            for (int i = 0; i < citations.Length; i++)
            {
                var citation = citations[i];
                if (citation >= citations.Length - i)
                {
                    h = Math.Max(h, citations.Length - i);
                }
            }
            return h;
        }

        // Most performant soln O(log n)
        public static int HIndex2BinarySearch(int[] citations)
        {
            int n = citations.Length;
            int left = 0;
            int right = n - 1;
            int pivot = 0;
            while (left <= right)
            {
                pivot = (left + right) / 2;
                if (citations[pivot] == n - pivot)
                {
                    return n - pivot;
                }
                else if (citations[pivot] < n - pivot)
                {
                    left = pivot + 1;
                }
                else
                {
                    right = pivot - 1;
                }
            }
            return n - left;
        }
    }
}
