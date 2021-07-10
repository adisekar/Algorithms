using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Recursion
{
    public class PermutationsOlder
    {
        // Time complexity - Upper bound O(n!*n^2). Space O(n*n!)
        // Roughly O(n!*n). Space O(n!*n)
        public static List<List<int>> GetPermutations(List<int> array)
        {
            List<List<int>> result = new List<List<int>>();
            GetPermutationsHelper(array, new List<int>(), result);
            return result;
        }

        private static void GetPermutationsHelper(List<int> array, List<int> perm, List<List<int>> perms)
        {
            // IF array empty, then base case. Add perm to perms
            if (array.Count == 0 && perm.Count > 0)
            {
                perms.Add(perm);
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    var num = array[i];
                    // Remove element frm array
                    // Copy to new array and remove
                    var newArr = new List<int>(array);
                    newArr.RemoveAt(i);

                    var newPerm = new List<int>(perm);
                    newPerm.Add(num);

                    GetPermutationsHelper(newArr, newPerm, perms);
                }
            }
        }

        public static List<List<int>> GetPermutationsUnique(int[] array)
        {
            Array.Sort(array);
            List<List<int>> result = new List<List<int>>();
            GetPermutationsUniqueHelper(array.ToList(), new List<int>(), result);
            return result;
        }

        private static void GetPermutationsUniqueHelper(List<int> array, List<int> perm, List<List<int>> perms)
        {
            // IF array empty, then base case. Add perm to perms
            if (array.Count == 0 && perm.Count > 0)
            {
                perms.Add(perm);
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (i > 0 && array[i] == array[i - 1])
                    {
                        continue;
                    }
                    var num = array[i];
                    // Remove element frm array
                    // Copy to new array and remove
                    var newArr = new List<int>(array);
                    newArr.RemoveAt(i);

                    var newPerm = new List<int>(perm);
                    newPerm.Add(num);

                    GetPermutationsUniqueHelper(newArr, newPerm, perms);
                }
            }
        }

        // 2nd Soln better, as instead of removing element from array
        // and adding to new list, we just move pointers and swap in array in place
        //var result = Permutations.GetPermutations(array);
        public static List<List<int>> GetPermutationsBacktrack(List<int> array)
        {
            List<List<int>> result = new List<List<int>>();
            GetPermutationsBacktrack(array, new List<int>(), result);
            return result;
        }

        private static void GetPermutationsBacktrack(List<int> array, List<int> perm, List<List<int>> perms)
        {
            // IF index is equal to array size
            if (perm.Count == array.Count)
            {
                perms.Add(new List<int>(perm));
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (perm.Contains(array[i])) continue; // element already exists, skip
                    perm.Add(array[i]);
                    GetPermutationsBacktrack(array, perm, perms);
                    perm.RemoveAt(perm.Count - 1);
                }
            }
        }

        public static IList<IList<int>> PermuteUniqueBackTrack(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            PermuteUniqueBackTrack(nums, new List<int>(), result, new bool[nums.Length]);
            return result;
        }
        private static void PermuteUniqueBackTrack(int[] nums, List<int> perm, IList<IList<int>> perms, bool[] used)
        {
            if (perm.Count == nums.Length)
            {
                perms.Add(new List<int>(perm));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] || i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) { continue; }
                    used[i] = true;
                    perm.Add(nums[i]);
                    PermuteUniqueBackTrack(nums, perm, perms, used);
                    used[i] = false;
                    perm.RemoveAt(perm.Count - 1);
                }
            }
        }
    }
}
