using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    // Find Single number in arr
    // Input: nums = [4,1,2,1,2] Output: 4
    class SingleNumber
    {
        public static int FindSingleNumberUsingMemory(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (var n in nums)
            {
                if (set.Contains(n))
                {
                    set.Remove(n);
                }
                else
                {
                    set.Add(n);
                }
            }

            foreach (var i in set)
            {
                return i;
            }
            return -1;
        }

        // Best Soln. use XOR.
        // XOR 1 ^ 1 = 0. But 1 ^ 0 = 1
        // So all pair numbers will cancel out and only unique will remain

        public static int FindSingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
