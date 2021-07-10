using Algorithms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graph.WordLadder
{
    // Find ladder length

    /*
    * Input:
    beginWord = "hit",
    endWord = "cog",
    wordList = ["hot","dot","dog","lot","log","cog"]

    Output: 5

    Explanation: As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
    return its length 5.

          For each word, loop thru entire wordlist to see if they are one distance away, and can be converted.
          If wordlist is huge corpus dictionary, it is not good. Better approach to loop a to z and add it in every
          position of word and see if it matches any of the words in wordList.
        */
    public class WordLadder1
    {
        public static int LadderLength_BF(string beginWord, string endWord, IList<string> wordList)
        {
            Queue<string> queue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();

            // Check if end word is in word list
            if (!wordList.Contains(endWord))
            {
                return 0;
            }

            visited.Add(beginWord);

            queue.Enqueue(beginWord);
            int minLength = 0;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var curWord = queue.Dequeue();

                    if (curWord == endWord)
                    {
                        return minLength + 1;
                    }

                    foreach (var word in wordList)
                    {
                        if (!visited.Contains(word) && OneEdit.IsOneEditAway(curWord, word))
                        {
                            queue.Enqueue(word);
                            visited.Add(word);
                        }
                    }
                }
                minLength++;
            }
            return 0;
        }

        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            Queue<string> queue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            HashSet<string> wordListSet = new HashSet<string>(wordList);

            // Check if end word is in word list
            if (!wordList.Contains(endWord))
            {
                return 0;
            }

            visited.Add(beginWord);

            queue.Enqueue(beginWord);
            int minLength = 0;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var curWord = queue.Dequeue();

                    if (curWord == endWord)
                    {
                        return minLength + 1;
                    }

                    // Loop thru any word, as they are all equal length, and replace character a - z in every position
                    for (int j = 0; j < beginWord.Length; j++)
                    {
                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            if (curWord[j] != ch)
                            {
                                char[] curWordArr = curWord.ToCharArray();
                                curWordArr[j] = ch;

                                string newWord = new string(curWordArr);

                                if (!visited.Contains(newWord) && wordListSet.Contains(newWord))
                                {
                                    queue.Enqueue(newWord);
                                    visited.Add(newWord);
                                }
                            }
                        }
                    }
                }
                minLength++;
            }
            return 0;
        }
    }
}
