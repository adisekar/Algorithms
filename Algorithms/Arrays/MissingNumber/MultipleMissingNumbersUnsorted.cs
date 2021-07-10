using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.MissingNumber
{
    public class MultipleMissingNumbersUnsorted
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            if (nums.Length == 0)
            {
                return result;
            }
            int min = 1; // lower bound is 1
            int max = nums[0];
            // Find Min and Max element in given array. They act as lower and upper bound
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            max = Math.Max(max, nums.Length);
            int[] newNums = new int[max + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                newNums[nums[i]]++;
            }

            // Loop thru newNums to get elements which have value 0 still
            for (int i = min; i < newNums.Length; i++)
            {
                if (newNums[i] == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
