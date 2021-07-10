using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Backtracking
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            FindPermutations(nums, 0, result);
            return result;
        }

        public void FindPermutations(int[] nums, int startIdx, IList<IList<int>> result)
        {
            if (startIdx == nums.Length - 1)
            {
                result.Add(new List<int>(nums.ToList()));
                return;
            }

            for (int i = startIdx; i < nums.Length; i++)
            {
                Swap(nums, startIdx, i); // find permutations
                FindPermutations(nums, startIdx + 1, result); // fix first char and move to next
                Swap(nums, i, startIdx); // backtrack
            }
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
