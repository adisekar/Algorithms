using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class RemoveDuplicates
    {
        public static int FromSortedArray(int[] nums)
        {
            int j = 0;
            if (nums.Length > 0)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] != nums[i + 1])
                    {
                        nums[j] = nums[i];
                        j++;
                    }
                }
                // Transfer last element, as we skip last element in above loop
                nums[j] = nums[nums.Length - 1];
            }
            return j + 1;
        }
    }
}
