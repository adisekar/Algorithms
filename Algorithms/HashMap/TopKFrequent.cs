using DS.Heap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.HashMap
{
    public class TopKFrequent
    {
        public static IList<string> Words(string[] words, int k)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (map.ContainsKey(word))
                {
                    map[word] = map[word] + 1;
                }
                else
                {
                    map.Add(word, 1);
                }
            }

            // Add to heap for better performance
            var sortedMap = map.OrderByDescending(d => d.Value).ThenBy(d => d.Key).Take(k);
            IList<string> result = new List<string>();
            foreach (var kv in sortedMap)
            {
                result.Add(kv.Key);
            }
            return result;
        }

        public static int[] Elements(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num] = map[num] + 1;
                }
                else
                {
                    map.Add(num, 1);
                }
            }
            // Add to heap for better performance
            var sortedMap = map.OrderByDescending(d => d.Value).ThenBy(d => d.Key).Take(k);
            List<int> result = new List<int>();
            foreach (var kv in sortedMap)
            {
                result.Add(kv.Key);
            }
            return result.ToArray();
        }

        /* Amazon
         * Given a list of reviews, a list of keywords and an integer k. Find the most popular k keywords in order of most to least frequently mentioned.

The comparison of strings is case-insensitive.
Multiple occurances of a keyword in a review should be considred as a single mention.
If keywords are mentioned an equal number of times in reviews, sort alphabetically.

Example 1:

Input:
k = 2
keywords = ["anacell", "cetracular", "betacellular"]
reviews = [
  "Anacell provides the best services in the city",
  "betacellular has awesome services",
  "Best services provided by anacell, everyone should use anacell",
]

Output:
["anacell", "betacellular"]

Explanation:
"anacell" is occuring in 2 different reviews and "betacellular" is only occuring in 1 review.
Example 2:

Input:
k = 2
keywords = ["anacell", "betacellular", "cetracular", "deltacellular", "eurocell"]
reviews = [
  "I love anacell Best services; Best services provided by anacell",
  "betacellular has great services",
  "deltacellular provides much better services than betacellular",
  "cetracular is worse than anacell",
  "Betacellular is better than deltacellular.",
]

Output:
["betacellular", "anacell"]

Explanation:
"betacellular" is occuring in 3 different reviews. "anacell" and "deltacellular" are occuring in 2 reviews, but "anacell" is lexicographically smaller.
         */
        public static string[] Keywords(string[] reviews, string[] words, int k)
        {
            HashSet<string> keywordsSet = new HashSet<string>();
            foreach (var word in words)
            {
                keywordsSet.Add(word.ToLower());
            }

            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var review in reviews)
            {
                string[] wordsInReview = review.Split(' ');
                HashSet<string> addedSet = new HashSet<string>();

                foreach (var wordInReview in wordsInReview)
                {
                    var wordInReviewLower = wordInReview.ToLower();
                    // Only add if it is from different review
                    if (keywordsSet.Contains(wordInReviewLower) && !addedSet.Contains(wordInReviewLower))
                    {
                        if (map.ContainsKey(wordInReviewLower))
                        {
                            map[wordInReviewLower] = map[wordInReviewLower] + 1;
                        }
                        else
                        {
                            map.Add(wordInReviewLower, 1);
                        }
                        addedSet.Add(wordInReviewLower);
                    }
                }
            }

            // Add to heap for better performance
            var sortedMap = map.OrderByDescending(d => d.Value).ThenBy(d => d.Key).Take(k);
            List<string> result = new List<string>();
            foreach (var kv in sortedMap)
            {
                result.Add(kv.Key);
            }
            return result.ToArray();
        }
    }
}
