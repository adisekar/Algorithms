using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class FindAllDuplicates
    {
        // O(n) time and O(n) space for hashset.
        // Can be done better using Encoding array
        public static IList<int> FindDuplicatesWithSpace(int[] nums)
        {
            IList<int> result = new List<int>();
            HashSet<int> set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!set.Contains(num))
                {
                    set.Add(num);
                }
                else
                {
                    result.Add(num);
                }
            }
            return result;
        }

        // O(1) space and O(n) time
        // Can do because 1 ≤ a[i] ≤ n (n = size of array),
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = Math.Abs(nums[i]);
                // If value of number in index of current num is negative, it must have been seen already
                if (nums[currentNum - 1] < 0)
                {
                    result.Add(currentNum);
                }
                else
                {
                    nums[currentNum - 1] = nums[currentNum - 1] * -1;
                }
            }
            return result;
        }
    }
}
