using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Strings
{
    public class Anagram
    {
        // Anagram is valid, if both string length is same
        // and if they contain same characters
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (map.ContainsKey(c))
                {
                    map[c] = map[c] + 1;
                }
                else
                {
                    map[c] = 1;
                }
            }

            foreach (var c in t)
            {
                if (map.ContainsKey(c))
                {
                    map[c] = map[c] - 1;
                }
                else
                {
                    return false;
                }
            }

            foreach (var kv in map)
            {
                if (kv.Value > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Sort words by character, and store to dictionary with sorted word
            // as key, and value as list of original words
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var word = strs[i];
                var sortedWord = new string(word.OrderBy(c => c).ToArray());
                if (map.ContainsKey(sortedWord))
                {
                    map[sortedWord].Add(word);
                }
                else
                {
                    map.Add(sortedWord, new List<string>() { word });
                }
            }

            var result = new List<IList<string>>();

            foreach (var kv in map)
            {
                result.Add(kv.Value);
            }
            return result;
        }

        public static IList<IList<string>> GroupAnagramsBF(string[] strs)
        {
            // Sort words by character
            List<string> sortedWords = new List<string>();
            foreach (string word in strs)
            {
                var newWord = new string(word.OrderBy(c => c).ToArray());
                sortedWords.Add(newWord);
            }

            // Sort words, so they are next to each other
            var sortedWordsArr = sortedWords.OrderBy(w => w).ToList();

            // Get Indices array
            int[] indices = new int[sortedWords.Count];

            int k = 0;
            int j = 0;
            for (int i = 1; i <= sortedWordsArr.Count; i++)
            {
                var sortedWord = sortedWordsArr[i - 1];
                while (j < strs.Length)
                {
                    string str = strs[j];
                    if (IsAnagram(str, sortedWord))
                    {
                        indices[k] = j;
                        j = 0;
                        k++;
                        break;
                    }
                    j++;
                }
                if (i < sortedWordsArr.Count && String.Equals(sortedWord, sortedWordsArr[i]))
                {
                    j = indices[k - 1];
                    j++;
                }
            }

            IList<IList<string>> result = new List<IList<string>>();
            List<string> list = new List<string>();

            for (int i = 1; i <= sortedWordsArr.Count; i++)
            {
                var order = indices[i - 1];
                var correctWord = strs[order];
                list.Add(correctWord);
                if (i < sortedWordsArr.Count && !String.Equals(sortedWordsArr[i - 1], sortedWordsArr[i]))
                {
                    result.Add(list);
                    list = new List<string>();
                }
            }
            result.Add(list);
            return result;
        }
    }
}
