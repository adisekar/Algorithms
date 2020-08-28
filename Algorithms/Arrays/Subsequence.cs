using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Subsequence
    {
		// array = [5, 1, 22, 25, 6, -1, 8, 10]
		// sequence = [1, 6, -1, 10]
		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			int arrIdx = 0;
			int seqIdx = 0;

			while (arrIdx < array.Count && seqIdx < sequence.Count)
			{
				if (array[arrIdx] == sequence[seqIdx])
				{
					seqIdx++;
				}
				arrIdx++;
			}
			return seqIdx == sequence.Count;
		}
	}
}
