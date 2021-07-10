using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.MissingNumber
{
    public class MutipleMissingNumbersInSorted
    {
        public int MissingElement(int[] nums, int k)
        {
            int diff = nums[0] - 0;
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currDiff = nums[i] - i;
                if (currDiff != diff)
                {
                    while (diff < currDiff)
                    {
                        result.Add(diff + i);
                        diff++;
                    }
                }
            }

            if (k >= result.Count)
            {
                int lastElement = nums[nums.Length - 1];
                for (int i = result.Count; i < k; i++)
                {
                    lastElement = lastElement + 1;
                    result.Add(lastElement);
                }
            }
            var resultArr = result.ToArray();
            return resultArr[k - 1];
        }
    }
}
