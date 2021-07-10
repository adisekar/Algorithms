using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Arrays.DivideAndConquer;

namespace Algorithms.Sorting
{
    public class MergeSort
    {
        public static void IterativeMS(int[] nums, int n)
        {
            int p, low, high, mid;
            for (p = 2; p <= n; p = p * 2)
            {
                for (int i = 0; i + p - 1 < n; i = i + p)
                {
                    low = i;
                    high = i + p - 1;
                    mid = (low + high) / 2;
                    Merging.Merge(nums, low, mid, high);
                }
            }
            // For odd size list, there will be element left off
            if (p / 2 < n)
            {
                Merging.Merge(nums, 0, p / 2 - 1, n - 1);
            }
        }

        public static void RecursiveMS(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                RecursiveMS(nums, low, mid);
                RecursiveMS(nums, mid + 1, high);
                Merging.Merge(nums, low, mid, high);
            }
        }
    }
}
