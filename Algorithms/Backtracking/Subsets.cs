using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Backtracking
{
    public class Subsets
    {
        public IList<IList<int>> FindSubsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> subset = new List<int>();
            GenerateSubsets(nums, 0, subset, result);
            return result;
        }

        private void GenerateSubsets(int[] nums, int index, List<int> subset, IList<IList<int>> result)
        {
            result.Add(new List<int>(subset));
            if (index == nums.Length)
            {
                return;
            }

            for (int i = index; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                GenerateSubsets(nums, i + 1, subset, result);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
