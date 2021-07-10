using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Backtracking
{
    public class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();

            List<int> A = new List<int>();
            for (int i = 0; i < n; i++)
            {
                A.Add(i + 1);
            }
            FindCombinations(A.ToArray(), 0, k, new List<int>(), result);
            return result;
        }

        private void FindCombinations(int[] A, int i, int k, List<int> curr, IList<IList<int>> result)
        {
            // Base case
            if (curr.Count == k)
            {
                result.Add(new List<int>(curr));
                return;
            }

            // Recursive
            for (int j = i; j < A.Length; j++)
            {
                curr.Add(A[j]);
                FindCombinations(A, j + 1, k, curr, result);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
