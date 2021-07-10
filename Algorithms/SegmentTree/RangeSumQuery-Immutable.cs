using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SegmentTree
{
    public class RangeSumQuery_Immutable
    {
        private int[] sumArr;
        public RangeSumQuery_Immutable(int[] nums)
        {
            sumArr = new int[nums.Length];

            int currSum = 0;
            // Create new array which is sum of all elements till that index
            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];
                sumArr[i] = currSum;
            }
        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
            {
                return sumArr[j];
            }

            // Formula is rightIndex - (leftIndex - 1)
            return sumArr[j] - sumArr[i - 1];
        }
    }
}
