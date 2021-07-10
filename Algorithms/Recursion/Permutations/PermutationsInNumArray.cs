using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Recursion.Permutations
{
    public class PermutationsInNumArray
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            PermuteHelper(nums, 0, nums.Length - 1, result);
            return result;
        }
        public void Swap(int[] nums, int left, int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }

        // Take left and right values
        // Swap left and right to get the permutation
        // Do Recursively to get sub combinations, after fixing first letter. So we do left + 1. Each time left keeps increasing
        // Swap back (backtrack) to get original permuatation
        public void PermuteHelper(int[] nums, int left, int right, IList<IList<int>> result)
        {
            // IF index is equal to array size
            if (left == right)
            {
                result.Add(nums.ToList());
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    Swap(nums, left, i);
                    PermuteHelper(nums, left + 1, right, result);
                    Swap(nums, left, i);
                }
            }
        }
    }
}
