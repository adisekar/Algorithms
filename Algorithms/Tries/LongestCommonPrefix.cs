using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tries
{
    public class LongestCommonPrefix
    {
        public static string LCP(string[] words)
        {
            if (words.Length == 0)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();

            Trie trie = new Trie();
            foreach (var word in words)
            {
                trie.Insert(word);
            }

            StringBuilder prefix = new StringBuilder();
            foreach (var c in words[0])
            {
                var prefixStr = prefix.Append(c).ToString();
                if (trie.StartsWith(prefixStr, words.Length))
                {
                    sb.Append(c);
                }
                else
                {
                    return sb.ToString();
                }
            }
            return sb.ToString();
        }
    }
}
