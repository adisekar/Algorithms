using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.HashMap
{
    public class MostCommonWord
    {
        public static string MostCommonWordInString(string paragraph, string[] banned)
        {
            //string[] stringsToRemove = { ",", ".", "?", "!", ";" };
            HashSet<char> removeChars = new HashSet<char>() { ',', '.', '?', '!', ';' };
            string paragraphLower = paragraph.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (var c in paragraphLower)
            {
                if (!removeChars.Contains(c))
                {
                    sb.Append(c);
                }
            }
            var trimmedParagraph = sb.ToString();
            string[] words = trimmedParagraph.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else
                {
                    map.Add(word, 1);
                }
            }

            var sortedMap = map.OrderByDescending(m => m.Value).ToDictionary(t => t.Key, t => t.Value);
            HashSet<string> bannedWords = new HashSet<string>();
            foreach (var word in banned)
            {
                bannedWords.Add(word);
            }
            foreach (var kv in sortedMap)
            {
                if (bannedWords.Count > 0)
                {
                    if (!bannedWords.Contains(kv.Key))
                    {
                        return kv.Key;
                    }
                }
                else
                {
                    return kv.Key;
                }
            }
            return "";
        }
    }
}
