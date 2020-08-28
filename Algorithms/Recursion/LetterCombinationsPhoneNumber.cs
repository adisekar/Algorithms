using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class LetterCombinationsPhoneNumber
    {
        // I/P = "23"
        // O/P = ["ad","ae","af","bd","be","bf","cd","ce","cf"]
        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (digits.Length == 0)
            {
                return result;
            }
            //Dictionary<char, string> map = CreateMapper();
            // Another approach use array instead
            string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno",
            "pqrs", "tuv", "wxyz"};

            LetterCombinationsRecursive(digits, map, "", 0, result);
            return result;
        }

        //private static void LetterCombinationsRecursive(string digits, Dictionary<char, string> map, string current, int index, IList<string> result)
        private static void LetterCombinationsRecursive(string digits, string[] map, string current, int index, IList<string> result)
        {
            // Base case
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            // Recursive case
            //string letters = map[digits[index]];
            // Convert char '2' from ascii to position 2, by doing - '0'
            // For letters a -z, we can do - 'a'
            string letters = map[digits[index] - '0'];

            for (int i = 0; i < letters.Length; i++)
            {
                char letter = letters[i];
                LetterCombinationsRecursive(digits, map, current + letter, index + 1, result);
            }
        }

        public static Dictionary<char, string> CreateMapper()
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            dictionary.Add('2', "abc");
            dictionary.Add('3', "def");
            dictionary.Add('4', "ghi");
            dictionary.Add('5', "jkl");
            dictionary.Add('6', "mno");
            dictionary.Add('7', "pqrs");
            dictionary.Add('8', "tuv");
            dictionary.Add('9', "wxyz");
            return dictionary;
        }
    }
}
