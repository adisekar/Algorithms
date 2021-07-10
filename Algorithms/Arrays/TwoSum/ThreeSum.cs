using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ThreeSumPairs
    {
        // Brute Force Solution
        public IList<IList<int>> ThreeSum_BF(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            // To remove duplicates. Sort array, and check for contains
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var pairs = new List<int>() { nums[i], nums[j], nums[k] };
                            if (!CheckIfExists(result, pairs))
                            {
                                result.Add(pairs);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool CheckIfExists(IList<IList<int>> list, List<int> pair)
        {
            foreach (var el in list)
            {
                if (el[0] == pair[0] && el[1] == pair[1] && el[2] == pair[2])
                {
                    return true;
                }
            }
            return false;
        }

        // O(n^2) solution. O(nlogn) for sorting, but asymptotilcally is O(n^2)
        // 2 pointer. Fix one number and use 2 pointer start and end to compare
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {

                if (i == 0 || nums[i] > nums[i - 1])
                {
                    int start = i + 1;
                    int end = nums.Length - 1;

                    while (start < end)
                    {
                        if (nums[i] + nums[start] + nums[end] == 0)
                        {
                            result.Add(new List<int>() { nums[i], nums[start], nums[end] });
                        }

                        if (nums[i] + nums[start] + nums[end] < 0)
                        {
                            int curStart = start;
                            // Skip duplicates
                            while (nums[curStart] == nums[start] && start < end)
                            {
                                start++;
                            }
                        }
                        else
                        {          //nums[i] + nums[start] + nums[end] > 0
                            int curEnd = end;
                            // Skip duplicates
                            while (nums[curEnd] == nums[end] && start < end)
                            {
                                end--;
                            }
                        }
                    }
                }
            }
            return result;
        }

        // To Do - 3 rd approach using hashSet like 2 sum. Fix 2 numbers, and check set
    }
}
