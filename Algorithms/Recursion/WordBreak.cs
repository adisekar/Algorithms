using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class WordBreak
    {
        // Without memoization -Runtime O(2^(n -1)). 
        // string len 4, so 8 possibilities

        // With memoization, O(n^2)
        public static bool CanWordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>();

            foreach (var word in wordDict)
            {
                wordSet.Add(word);
            }
            // Memoization
            Dictionary<string, bool> map = new Dictionary<string, bool>();

            return DFS(s, wordSet, map);
        }
        private static bool DFS(string s, HashSet<string> wordSet, Dictionary<string, bool> map)
        {
            // Base case
            if (s.Length == 0)
            {
                return true;
            }
            if (map.ContainsKey(s)) { return map[s]; }

            // Recursive case
            for (int i = 1; i <= s.Length; i++)
            {
                var startSubstr = s.Substring(0, i);
                var remainSubstr = s.Substring(i, s.Length - i);

                if (wordSet.Contains(startSubstr) && DFS(remainSubstr, wordSet, map))
                {
                    map.Add(remainSubstr, true);
                    return true;
                }
            }
            map.Add(s, false);
            return false;
        }

        // Not working
        //public static bool CanWordBreakBFS(string s, IList<string> wordDict)
        //{
        //    HashSet<string> wordSet = new HashSet<string>();

        //    foreach (var word in wordDict)
        //    {
        //        wordSet.Add(word);
        //    }
        //    Queue<int> queue = new Queue<int>();
        //    bool[] visited = new bool[s.Length];
        //    queue.Enqueue(0);

        //    while (queue.Count > 0)
        //    {
        //        var currentCharIdx = queue.Dequeue();
        //        if (!visited[currentCharIdx])
        //        {
        //            for (int i = 1; i <= s.Length; i++)
        //            {
        //                if (wordSet.Contains(s.Substring(0, currentCharIdx)))
        //                {
        //                    queue.Enqueue(i);
        //                    if (i == s.Length)
        //                    {
        //                        return true;
        //                    }
        //                }
        //            }
        //            visited[currentCharIdx] = true;
        //        }
        //    }
        //    return false;
        //}

        public static IList<string> WordBreak2(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>();
            var result = new List<string>();
            if (!CanWordBreak(s, wordDict))
            {
                return result;
            }

            foreach (var word in wordDict)
            {
                wordSet.Add(word);
            }
            // Memoization
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

            DFS3(s, wordSet, map, new List<string>(), result);
            return result;
        }

        private static IList<string> DFS3(string s, HashSet<string> wordSet, Dictionary<string, IList<string>> map,
            IList<string> oneResult, IList<string> result)
        {
            if (map.ContainsKey(s)) { return map[s]; }
            // Base case
            if (s.Length == 0)
            {
                result.Add(string.Join(" ", oneResult));
            }

            for (int i = 1; i <= s.Length; i++)
            {
                var firstStr = s.Substring(0, i);
                var restStr = s.Substring(i);

                if (wordSet.Contains(firstStr))
                {
                    oneResult.Add(firstStr);
                    DFS3(restStr, wordSet, map, oneResult, result);
                    oneResult.RemoveAt(oneResult.Count - 1);
                }
            }

            //map.Add(s, result);
            return result;
        }

        // Not good soln, as we are looping over dictionary
        // and checking for starts with
        public static IList<string> WordBreak2Bad(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>();

            foreach (var word in wordDict)
            {
                wordSet.Add(word);
            }
            // Memoization
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

            var result = DFS2(s, wordSet, map);
            return result;
        }

        private static IList<string> DFS2(string s, HashSet<string> wordSet, Dictionary<string, IList<string>> map)
        {

            if (map.ContainsKey(s)) { return map[s]; }

            IList<string> result = new List<string>();
            // Base case
            if (s.Length == 0)
            {
                result.Add("");
            }

            foreach (var word in wordSet)
            {
                if (s.StartsWith(word))
                {
                    IList<String> subList = DFS2(s.Substring(word.Length, s.Length - word.Length), wordSet, map);
                    foreach (var sub in subList)
                    {
                        result.Add(word + (sub.Length == 0 ? "" : " ") + sub);
                    }
                }
            }

            map.Add(s, result);
            return result;
        }
    }
}
