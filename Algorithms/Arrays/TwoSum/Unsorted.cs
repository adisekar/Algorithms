using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoSum
{
    public class Unsorted
    {
        // O(n) time and O(n) space, as we are storing n numbers
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seenSet = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (seenSet.ContainsKey(target - num))
                {
                    return new int[] { seenSet[target - num], i };
                }
                else
                {
                    if (!seenSet.ContainsKey(num))
                    {
                        seenSet.Add(num, i);
                    }
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
