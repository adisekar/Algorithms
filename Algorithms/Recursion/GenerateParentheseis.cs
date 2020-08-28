using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class GenerateParenthesisCombination
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            GenerateParenthesis(n, 0, 0, 0, result, new char[2 * n]);
            return result;
        }

        private void GenerateParenthesis(int n, int idx, int open, int closed, IList<string> output, char[] currStrArr)
        {
            // Base case
            if (idx == 2 * n)
            {
                output.Add(new string(currStrArr));
            }

            // Recursive case
            if (open < n)
            {
                currStrArr[idx] = '(';
                GenerateParenthesis(n, idx + 1, open + 1, closed, output, currStrArr);
            }

            if (closed < open)
            {
                currStrArr[idx] = ')';
                GenerateParenthesis(n, idx + 1, open, closed + 1, output, currStrArr);
            }
        }
    }
}
