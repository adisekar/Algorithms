using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class SubArraySum
    {
        // [1,1,1] k = 2. O/P Count = 2
        public static int SubarraySum_BF(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    currentSum += nums[j];
                    if (currentSum == k)
                    {
                        count++;
                        //   break;
                    }
                }
            }
            return count;
        }
        public static int SubarraySumMap(int[] nums, int k)
        {
            int count = 0, sum = 0;
            // Key is sum, and value is occurence
            Dictionary<int, int> map = new Dictionary<int, int>
            {
                [0] = 1
                // base case, as sum 0 means 1 available subarray, so count is incremented
            };

            // We are doing prefix / left sum
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                // if prefix sum - k is already seen, then we can increment count
                // by value of that sum
                if (map.ContainsKey(sum - k))
                {
                    count += map[sum - k];
                }

                if (map.ContainsKey(sum))
                {
                    map[sum]++;
                }
                else
                {
                    map.Add(sum, 1);
                }
            }
            return count;
        }
    }
}
