using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ContainsDuplicates
    {
        public static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            double[] numsD = new double[nums.Length];
            for (int i = 0; i < numsD.Length; i++)
            {
                numsD[i] = Convert.ToDouble(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && (Math.Abs(numsD[i] - numsD[j]) <= t) && (Math.Abs(i - j) <= k))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
