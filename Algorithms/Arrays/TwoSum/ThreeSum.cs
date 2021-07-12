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
            // To remove duplicates. Sort array, and check for contains
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }

                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++; // can move left or right
                        // Loop to remove next duplicates
                        while (nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return result;
        }

        // To Do - 3 rd approach using hashSet like 2 sum. Fix 2 numbers, and check set. Not possible for duplicates
    }
}
