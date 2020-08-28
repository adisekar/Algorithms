using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.SortedArrays
{
    public class MedianTwoSortedArrays
    {
        // O(n) time and space, if done without Sort
        public static double FindMedianSortedArrays_BF(int[] nums1, int[] nums2)
        {
            double result = 0;
            int[] nums = new int[nums1.Length + nums2.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                nums[i] = nums1[i];
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                nums[nums1.Length + i] = nums2[i];
            }

            Array.Sort(nums);

            int mid = 0;
            // even
            if (nums.Length % 2 == 0)
            {
                mid = (nums.Length / 2) - 1;
                int midValue = (nums[mid + 1] + nums[mid]);
                result = (double)midValue / 2;
            }
            else
            {
                mid = nums.Length / 2;
                result = nums[mid];
            }
            return result;
        }

        // O(n) time, but O(1) space
        // Need refinement for all leetcode cases
        public static double FindMedianSortedArrays_InPlace(int[] nums1, int[] nums2)
        {
            double result = 0;
            bool isEven = (nums1.Length + nums2.Length) % 2 == 0 ? true : false;
            int mid = ((nums1.Length + nums2.Length) / 2);
            mid = mid < 0 ? 0 : mid;
            int i = 0;
            int j = 0;
            int idx = 0;

            if (nums1.Length == 0)
            {
                result = isEven ? (double)(nums2[mid] + nums2[mid + 1]) / 2 : (double)nums2[mid];
                return result;
            }

            if (nums2.Length == 0)
            {
                result = isEven ? (double)(nums1[mid] + nums1[mid + 1]) / 2 : (double)nums1[mid];
                return result;
            }


            // Loop till to get to mid
            // To start for 0 based index
            mid = mid - 1;
            while (idx < nums1.Length + nums2.Length && idx < mid)
            {
                if (nums1[i] < nums2[i])
                {
                    i++;
                }
                else
                {
                    j++;
                }
                idx++;
            }

            bool nums1Arr = false;
            if (i < j)
            {
                mid = nums1.Length / 2;
                nums1Arr = true;
            }
            else
            {
                mid = nums2.Length / 2;
            }

            // even
            if (isEven)
            {
                int midValue = 0;
                if (nums1Arr)
                {
                    midValue = (nums1[i + 1] + nums2[j]);
                }
                else
                {
                    midValue = (nums1[i] + nums2[j]);
                }
                result = (double)midValue / 2;
            }
            else
            {
                result = nums1Arr ? nums1[mid] : nums2[mid];
            }
            return result;
        }
    }
}
