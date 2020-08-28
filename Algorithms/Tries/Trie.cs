using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tries
{
    /*
     * Time complexity : O(m)O(m), where m is the key length.
In each iteration of the algorithm, we either examine or create a node in the trie till we reach the end of the key. This takes only mm operations.

Space complexity : O(m)O(m).
*/
    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode('/');
        }

        public int GetCharIndex(char c)
        {
            return c - 'a';
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode current = root;
            for (int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                var index = GetCharIndex(c);
                // IF char index null, insert new node
                if (current.children[index] == null)
                {
                    TrieNode newNode = new TrieNode(c);
                    current.children[index] = newNode;
                    newNode.count++;
                    // If last letter, then set endword
                    if (i == word.Length - 1)
                    {
                        newNode.isEndWord++;
                    }
                    current = current.children[index];
                }
                else // Update value
                {
                    current = current.children[index];
                    current.count++;
                    // If last letter, then set endword
                    if (i == word.Length - 1)
                    {
                        current.isEndWord++;
                    }
                }
            }
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode current = root;
            for (int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                var index = GetCharIndex(c);
                // IF char index null, insert new node
                if (current.children[index] == null)
                {
                    return false;
                }
                current = current.children[index];

                if (i == word.Length - 1)
                {
                    return current.isEndWord > 0 ? true : false;
                }
            }
            return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix, int minLen = 0)
        {
            TrieNode current = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                var c = prefix[i];
                var index = GetCharIndex(c);
                // IF char index null, insert new node
                if (current.children[index] == null)
                {
                    return false;
                }
                current = current.children[index];

                if (i == prefix.Length - 1)
                {
                    return current.count == minLen ? true : false;
                }
            }
            return false;
        }
    }
}
