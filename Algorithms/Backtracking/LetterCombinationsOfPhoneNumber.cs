using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Backtracking
{
    public class LetterCombinationsOfPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (digits == null || digits.Length == 0) { return result; }
            string[] map = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            StringBuilder sb = new StringBuilder();
            LetterCombinationsRecursive(result, digits, sb, 0, map);
            return result;
        }

        private void LetterCombinationsRecursive(IList<string> result, string digits, StringBuilder sb, int index, string[] map)
        {
            // Base case
            if (index == digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            // Recursive case
            string letters = map[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                sb.Append(letters[i]); // Backtracking add
                LetterCombinationsRecursive(result, digits, sb, index + 1, map);
                sb.Length--; // backtracking remove
            }
        }
    }
}
