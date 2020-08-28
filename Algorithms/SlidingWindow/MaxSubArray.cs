using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class MaxSubArray
    {
        public static int Sum_BF(int[] nums)
        {
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                int maxEndingHere = nums[i];
                for (int j = i + 1; i < nums.Length - 1; i++)
                {
                    maxEndingHere = maxEndingHere + nums[j];
                    max = Math.Max(maxEndingHere, max);
                }
            }
            return max;
        }

        public static int Sum(int[] nums)
        {
            int maxEndingHere = nums[0];
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                maxEndingHere = Math.Max(maxEndingHere + num, num);
                max = Math.Max(maxEndingHere, max);
            }
            return max;
        }

        public static int[] GetArray(int[] nums)
        {
            int maxEndingHere = nums[0];
            int max = nums[0];
            int p = 0;
            int q = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                //maxEndingHere = Math.Max(maxEndingHere + num, num);
                if (maxEndingHere + num > num)
                {
                    maxEndingHere = maxEndingHere + num;
                }
                else
                {
                    maxEndingHere = num;
                    p = i;
                }

                //max = Math.Max(maxEndingHere, max);
                if (maxEndingHere > max)
                {
                    max = maxEndingHere;
                    q = i;
                }
            }

            List<int> subArr = new List<int>();
            for (int i = p; i <= q; i++)
            {
                int num = nums[i];
                subArr.Add(num);
            }
            return subArr.ToArray();
        }
    }
}
