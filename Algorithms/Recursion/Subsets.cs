using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class Subsets
    {
        // I/P = [1,2,3]
        // O/P = [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
        // Time O(2^n * n) and Space = O(2^n). As result count of subsets
        // For each num, iterate through already generated subsets, and add that 
        // num to it
        public static IList<IList<int>> FindAllSubsets(int[] nums)
        {
            List<IList<int>> subsets = new List<IList<int>>();
            List<int> subset = new List<int>();
            subsets.Add(subset);

            foreach (int num in nums)
            {
                int subsetsLength = subsets.Count;
                for (int i = 0; i < subsetsLength; i++)
                {
                    subset = new List<int>();
                    // Add all elements in subset[i] to current subset list
                    subset.AddRange(subsets[i]);
                    subset.Add(num);
                    subsets.Add(subset);
                }
            }
            return subsets;
        }

        public static IList<IList<int>> FindAllSubsetsWithDup(int[] nums)
        {
            List<IList<int>> subsets = new List<IList<int>>();
            List<int> subset = new List<int>();
            subsets.Add(subset);
            Array.Sort(nums);

            int subsetsLength = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                // duplicate - skip already processed elements
                int startIdx = (j < nums.Length - 1 && nums[j] == nums[j + 1])
                ? 0 : subsetsLength;

                int num = nums[j];
                subsetsLength = subsets.Count;
                for (int i = startIdx; i < subsetsLength; i++)
                {
                    subset = new List<int>();
                    // Add all elements in subset[i] to current subset list
                    subset.AddRange(subsets[i]);
                    subset.Add(num);
                    subsets.Add(subset);
                }
            }
            return subsets;
        }

        public static IList<IList<int>> FindAllSubsetsBackTrack(int[] nums)
        {
            List<IList<int>> subsets = new List<IList<int>>();
            List<int> subset = new List<int>();
            FindAllSubsetsBackTrack(nums, subset, subsets, 0);
            return subsets;
        }

        private static void FindAllSubsetsBackTrack(int[] nums, List<int> subset, List<IList<int>> subsets, int startIdx)
        {
            subsets.Add(new List<int>(subset));
            for (int i = startIdx; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                FindAllSubsetsBackTrack(nums, subset, subsets, i + 1);
                subset.RemoveAt(subset.Count - 1);
            }
        }

        public static IList<IList<int>> FindAllSubsetsBackTrackWithDup(int[] nums)
        {
            List<IList<int>> subsets = new List<IList<int>>();
            List<int> subset = new List<int>();
            Array.Sort(nums);
            FindAllSubsetsBackTrackWithDup(nums, subset, subsets, 0);
            return subsets;
        }

        private static void FindAllSubsetsBackTrackWithDup(int[] nums, List<int> subset, List<IList<int>> subsets, int startIdx)
        {
            subsets.Add(new List<int>(subset));
            for (int i = startIdx; i < nums.Length; i++)
            {
                if (i > startIdx && nums[i] == nums[i - 1]) { continue; }
                subset.Add(nums[i]);
                FindAllSubsetsBackTrackWithDup(nums, subset, subsets, i + 1);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
