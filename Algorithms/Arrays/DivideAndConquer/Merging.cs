using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.DivideAndConquer
{
    public class Merging
    {
        // nums = [2,3,5, 1,4,7]
        // Elements 2,3,5 are sorted and 1,4,7 are sorted
        // 2 way Merge - as it merges 2 sorted arrays in 1 array
        public static void Merge(int[] nums, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;
            int[] result = new int[nums.Length];
            int k = low; // k is pointer of result arr
            // high = nums.Length and low = 0

            while (i <= mid && j <= high)
            {
                if (nums[i] < nums[j])
                {
                    result[k++] = nums[i++];
                }
                else
                {
                    result[k++] = nums[j++];
                }
            }

            while (i <= mid)
            {
                result[k++] = nums[i++];
            }

            while (j <= high)
            {
                result[k++] = nums[j++];
            }

            // Copy over items to original array
            for (int p = low; p <= high; p++)
            {
                nums[p] = result[p];
            }
        }
    }
}
