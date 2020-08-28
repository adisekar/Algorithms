using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class DutchNationalFlag
    {
        public static void SortColors(int[] nums)
        {
            int n = nums.Length;
            int low = 0;
            int high = n - 1;
            int mid = 0;

            while (mid <= high)
            {
                switch (nums[mid])
                {
                    case 0:
                        Swap(nums, low, mid);
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        Swap(nums, mid, high);
                        high--;
                        break;
                }
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
