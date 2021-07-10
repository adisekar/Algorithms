using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Greedy
{
    /* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

    public class FindTheCelebrity
    {
        public extern bool Knows(int a, int b);

        // Brute Force
        public int FindCelebrity_BF(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (IsCelebrity(i, n))
                {
                    return i;
                }
            }
            return -1;
        }

        // Best case.
        // Knows(i, j) => i not celebrity. j is possible celebrity, so we switch 
        // possible celebrity to j.
        public int FindCelebrity(int n)
        {
            int possibleCandidate = 0;
            for (int i = 0; i < n; i++)
            {
                if (Knows(possibleCandidate, i))
                {
                    possibleCandidate = i;
                }
            }
            if (IsCelebrity(possibleCandidate, n))
            {
                return possibleCandidate;
            }
            return -1;
        }

        public bool IsCelebrity(int candidate, int n)
        {
            for (int j = 0; j < n; j++)
            {
                if (candidate == j) { continue; }
                // If candidate Knows anyone or if anyone DOES not know candidate, then return false.
                if (Knows(candidate, j) || !Knows(j, candidate))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
