using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms.Strings;

namespace Algorithms.Graph
{
    public class WordLadder2
    {
        /*
         * Input:
beginWord = "hit",
endWord = "cog",
wordList = ["hot","dot","dog","lot","log","cog"]

Output: 5

Explanation: As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
return its length 5.

            Time Complexity: O({M}^2 \times N)O(M 
2 ×N), where MM is the length of each word and NN is the total number of words in the input word list.
For each word in the word list, we iterate over its length to find all the intermediate words corresponding to it. Since the length of each word is MM and we have NN words, the total number of iterations the algorithm takes to create all_combo_dict is M \times NM×N. Additionally, forming each of the intermediate word takes O(M)O(M) time because of the substring operation used to create the new string. This adds up to a complexity of O({M}^2 \times N)O(M 
2×N).
Breadth first search in the worst case might go to each of the NN words. For each word, we need to examine MM possible intermediate words/combinations. Notice, we have used the substring operation to find each of the combination. Thus, MM combinations take O({M} ^ 2)O(M 
2) time. As a result, the time complexity of BFS traversal would also be O({M}^2 \times N)O(M 
2 ×N).
Combining the above steps, the overall time complexity of this approach is O({M}^2 \times N)O(M 
2 ×N).
Space Complexity: O({M}^2 \times N)O(M^2×N).
Each word in the word list would have MM intermediate combinations. To create the all_combo_dict dictionary we save an intermediate word as the key and its corresponding original words as the value. Note, for each of MM intermediate words we save the original word of length MM. This simply means, for every word we would need a space of {M}^2M 
2  to save all the transformations corresponding to it. Thus, all_combo_dict would need a total space of O({M}^2 \times N)O(M 
2 ×N).
Visited dictionary would need a space of O(M \times N)O(M×N) as each word is of length MM.
Queue for BFS in worst case would need a space for all O(N)O(N) words and this would also result in a space complexity of O(M \times N)O(M×N).
Combining the above steps, the overall space complexity is O({M}^2 \times N)O(M 
2 ×N) + O(M * N)O(M∗N) + O(M * N)O(M∗N) = O({M}^2 \times N)O(M2×N) space.

        */

        // For each word, loop thru entire wordlist to see if they are one distance away, and can be converted.
        // If wordlist is huge corpus dictionary, it is not good. Better approach to loop a to z and add it in every
        // position of word and see if it matches any of the words in wordList.
        public static int LadderLength(string beginWord, string endWord, List<string> wordList)
        {

            // Since all words are of same length.
            int L = beginWord.Length;
            Dictionary<string, List<string>> allCombosDict = new Dictionary<string, List<string>>();

            wordList.ForEach(word =>
            {
                for (int i = 0; i < L; i++)
                {
                    string newWord = word.Substring(0, i) + "*" + word.Substring(i + 1, L - (i + 1));
                    if (!allCombosDict.ContainsKey(newWord))
                    {
                        allCombosDict.Add(newWord, new List<string>() { word });
                    }
                    else
                    {
                        allCombosDict[newWord].Add(word);
                    }
                }
            });

            Queue<Tuple<string, int>> queue = new Queue<Tuple<string, int>>();
            queue.Enqueue(new Tuple<string, int>(beginWord, 1));

            // Visited to make sure we don't repeat processing same word.
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            visited.Add(beginWord, true);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                var currentWord = current.Item1;
                var currentLevel = current.Item2;

                for (int i = 0; i < L; i++)
                {
                    // Intermediate words for current word
                    string newWord = currentWord.Substring(0, i) + "*" + currentWord.Substring(i + 1, L - (i + 1));

                    if (allCombosDict.ContainsKey(newWord))
                    {
                        var adjacentWordsList = allCombosDict[newWord];
                        foreach (var adjacentWord in adjacentWordsList)
                        {
                            if (adjacentWord == endWord)
                            {
                                return currentLevel + 1;
                            }
                            // Otherwise, add it to the BFS Queue. Also mark it visited
                            if (!visited.ContainsKey(adjacentWord))
                            {
                                visited.Add(adjacentWord, true);
                                queue.Enqueue(new Tuple<string, int>(adjacentWord, currentLevel + 1));
                            }
                        }
                    }
                }
            }
            return 0;
        }

        public static IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            IList<IList<string>> result = new List<IList<string>>();
            int len = beginWord.Length;
            Dictionary<string, HashSet<string>> allCombosDict = GetAllCombosDict(wordList, len);

            //Queue For BFS
            var queue = new Queue<string>();

            //Dictionary to store shortest paths to a word
            var shortestPaths = new Dictionary<string, IList<IList<string>>>();

            queue.Enqueue(beginWord);
            // do not confuse () with {} - fix compiler error
            shortestPaths[beginWord] = new List<IList<string>>() { new List<string>() { beginWord } };

            var visited = new HashSet<string>();

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                //we can terminate loop once we reached the endWord as all paths leads here already visited in previous level 
                if (current.Equals(endWord))
                {
                    return shortestPaths[endWord];
                }

                if (visited.Contains(current))
                    continue;

                visited.Add(current);
                //Transform word to intermediate words and find matches
                // case study: var source = "good";  
                // go over all keys related to visit = "good" for example,
                // keys: "*ood","g*od","go*d","goo*"
                for (int i = 0; i < len; i++)
                {
                    string newWord = current.Substring(0, i) + "*" + current.Substring(i + 1, len - (i + 1));

                    if (allCombosDict.ContainsKey(newWord))
                    {
                        var adjacentWordsList = allCombosDict[newWord];
                        foreach (var adjacentWord in adjacentWordsList)
                        {
                            if (visited.Contains(adjacentWord))
                                continue;

                            foreach (var path in shortestPaths[current])
                            {
                                var newPath = new List<string>(path);
                                newPath.Add(adjacentWord); // path increments one, before it is saved in shortestPaths

                                if (!shortestPaths.ContainsKey(adjacentWord))
                                {
                                    shortestPaths[adjacentWord] = new List<IList<string>>() { newPath };
                                }
                                else if (shortestPaths[adjacentWord][0].Count >= newPath.Count) // // we are interested in shortest paths only
                                {
                                    shortestPaths[adjacentWord].Add(newPath);
                                }
                            }

                            queue.Enqueue(adjacentWord);
                        }
                    }
                }
            }
            return result;
        }

        private static Dictionary<string, HashSet<string>> GetAllCombosDict(IList<string> wordList, int len)
        {
            Dictionary<string, HashSet<string>> allCombosDict = new Dictionary<string, HashSet<string>>();
            foreach (var word in wordList)
            {
                for (int i = 0; i < len; i++)
                {
                    string newWord = word.Substring(0, i) + "*" + word.Substring(i + 1, len - (i + 1));

                    if (!allCombosDict.ContainsKey(newWord))
                    {
                        allCombosDict.Add(newWord, new HashSet<string>() { word });
                    }
                    else
                    {
                        allCombosDict[newWord].Add(word);
                    }
                }
            }
            return allCombosDict;
        }
    }

    public class Pair
    {
        public string word { get; set; }
        public List<string> list { get; set; }

        public Pair(string word, List<string> list)
        {
            this.word = word;
            this.list = list;
        }
    }
}
