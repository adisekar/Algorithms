using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Backtracking
{
    public class CombinationSum
    {
        public IList<IList<int>> FindCombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            RHelper(candidates, target, 0, new List<int>(), result);
            return result;
        }

        public void RHelper(int[] candidates, int target, int startIdx, List<int> list, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(list));
                return;
            }
            if (target < 0)
            {
                return;
            }

            for (int i = startIdx; i < candidates.Length; i++)
            {
                int num = candidates[i];
                int remainder = target - num;
                list.Add(num);
                RHelper(candidates, remainder, i, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
