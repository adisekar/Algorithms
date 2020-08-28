using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class CountingSort
    {
        public static int[] SortColors(int[] nums)
        {
            // Dutch National Flag Problem

            // temp array to store the counts of 0,1 and 2	
            // Calculate number of unique elements, by going thru array to find all unique elements in hash set
            int[] counts = new int[3];


            foreach (var num in nums)
            {
                if (num == 0)
                {
                    counts[0]++;
                }
                if (num == 1)
                {
                    counts[1]++;
                }
                if (num == 2)
                {
                    counts[2]++;
                }
            }

            // calculate running sum
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Shift one index back
            for (int i = counts.Length - 1; i > 0; i--)
            {
                counts[i] = counts[i - 1];
            }
            counts[0] = 0;

            int[] newArr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                newArr[counts[num]] = num;
                counts[num]++;
            }
            return newArr;
        }
    }
}
