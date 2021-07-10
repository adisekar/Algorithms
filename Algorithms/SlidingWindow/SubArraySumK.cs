using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class SubArraySumK
    {
        public static int SubarraySum(int[] arr, int k)
        {
            int currentSum = 0;
            int startIndex = 0;
            int result = 0;
            int i = 0;
            while (i <= arr.Length && startIndex < arr.Length)
            {
                if (currentSum == k)
                {
                    result++;
                    if (i < arr.Length)
                        currentSum += arr[i];
                    i++;
                }
                else if (currentSum > k)
                {
                    currentSum -= arr[startIndex];
                    startIndex++;
                }
                else
                {
                    if (i < arr.Length)
                        currentSum += arr[i];
                    i++;
                }
            }
            return result;
        }

        public int SubarraySumHashMap(int[] nums, int k)
        {
            int count = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                {
                    count++;
                }
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
