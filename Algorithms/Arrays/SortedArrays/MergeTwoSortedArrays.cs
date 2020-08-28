using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.SortedArrays
{
    public class MergeTwoSortedArrays
    {
        // Not good soln, as we have to shift every element by 1
        public static void MergeByShifting(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            int j = 0;
            int k = m;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] <= nums2[j])
                {
                    i++;
                }
                else
                {
                    // store value 
                    int temp = nums2[j];
                    // Shift all elements one place
                    for (int r = nums1.Length - 2; r >= i; r--)
                    {
                        nums1[r + 1] = nums1[r];
                    }
                    nums1[i] = temp;
                    j++; k++;
                }
            }


            while (j < n)
            {
                nums1[k++] = nums2[j++];
            }
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = nums1.Length - 1;
            int i = m - 1;
            int j = n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[index] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[index] = nums2[j];
                    j--;
                }
                index--;
            }

            while (j >= 0 && index >= 0)
            {
                nums1[index] = nums2[j];
                index--;
                j--;
            }
        }
    }
}
