using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class ReverseWordsInString
    {
        /*
         Input: s = "the sky is blue"
        Output: "blue is sky the"
        */
        public static string ReverseWords(string s)
        {
            string[] words = s.Trim().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int j = words.Length - 1;
            for (int i = 0; i < words.Length / 2; i++, j--)
            {
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
            return string.Join(" ", words);
        }

        public static void ReverseWordsBF(char[] s)
        {
            StringBuilder builder = new StringBuilder();
            List<string> words = new List<string>();
            foreach (var c in s)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    words.Add(builder.ToString());
                    builder = new StringBuilder();
                }
                else
                {
                    builder.Append(c);
                }
            }
            if (builder.Length > 0)
            {
                words.Add(builder.ToString());
            }
            // Reverse the string
            int j = words.Count - 1;
            for (int i = 0; i < words.Count / 2; i++, j--)
            {
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }

            List<char> characters = new List<char>();
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    characters.Add(c);
                }
                characters.Add(' ');
            }
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = characters[i];
            }
        }

        public void ReverseWords2(char[] s)
        {
            Reverse(s, 0, s.Length / 2);

            ReverseEachWord(s);
        }

        public void Reverse(char[] s, int left, int right)
        {
            int j = right - 1;
            for (int i = left; i < right; i++, j--)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
        public void ReverseEachWord(char[] s)
        {
            int start = 0;
            int end = 0;
            while (start < s.Length)
            {
                while (end < s.Length && s[end] != ' ')
                {
                    end++;
                }

                Reverse(s, start, end);
                end++;
                start = end;
            }
        }
    }
}
