using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.SubArray
{
    /*
    Input: [0,1]
Output: 2
Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.

Example 2:
Input: [0,1,0]
Output: 2
Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
     */
    public class ContigiousArray
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1); // Base setup, for 0 = start num, the index is -1.
                            // When we see 1, add to sum, but for 0, we treat it as -1
                            // So when sum becomes key in map, it means it is equal number of 0 and 1 at that point

            int sum = 0;
            int maxLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 1 ? 1 : -1;

                if (!map.ContainsKey(sum))
                {
                    map.Add(sum, i);
                }
                else
                {
                    maxLength = Math.Max(maxLength, i - map[sum]);
                }
            }
            return maxLength;
        }
    }
}
