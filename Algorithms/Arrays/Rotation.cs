using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class Rotation
    {
        public static void Rotate(int[] nums, int k)
        {
            // Reversal Algorithm
            int n = nums.Length;
            // If k > nums.Length, can only rotate it k% nums.Len times
            k = k % nums.Length;
            int arr1Len = n - k;

            // Rotate first part of array
            for (int i = 0, j = arr1Len - 1; i < arr1Len / 2; i++, j--)
            {
                Swap(nums, i, j);
            }
            // Rotate 2nd part of array
            for (int i = arr1Len, j = n - 1; i < arr1Len + k / 2; i++, j--)
            {
                Swap(nums, i, j);
            }
            // Rotate whole array
            for (int i = 0, j = n - 1; i < n / 2; i++, j--)
            {
                Swap(nums, i, j);
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
