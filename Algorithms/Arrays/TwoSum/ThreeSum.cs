using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ThreeSumPairs
    {
        // O(n^2) solution. O(nlogn) for sorting, but asymptotilcally is O(n^2)
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            var result = new List<IList<int>>();

            var n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i]) continue;
                // Skip if num > 0, as sum cannot be 0
                if (nums[i] > 0) { continue; }

                var left = i + 1;
                var right = n - 1;

                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
