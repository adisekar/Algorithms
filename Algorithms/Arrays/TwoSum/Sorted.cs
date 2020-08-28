using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoSum
{
    public class Sorted
    {
        // Better than hash table, as O(1) space
        // Hash table is O(n) space
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;

            while (i < j && i < numbers.Length && j > 0)
            {
                int currentSum = numbers[i] + numbers[j];
                if (currentSum == target)
                {
                    return new int[] { i + 1, j + 1 };
                }
                else if (currentSum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return new int[2];
        }
    }
}
