using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Backtracking
{
    public class PermutationsWithoutDups
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

            HashSet<int> set = new HashSet<int>();
            for (int i = startIdx; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    Swap(nums, startIdx, i); // find permutations
                    FindPermutations(nums, startIdx + 1, result); // fix first char and move to next
                    Swap(nums, i, startIdx); // backtrack

                    set.Add(nums[i]);
                }
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
