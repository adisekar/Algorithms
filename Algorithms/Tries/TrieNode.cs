using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tries
{
    public class TrieNode
    {
        public char val { get; set; }
        public int count { get; set; }
        public int isEndWord { get; set; }
        public TrieNode[] children { get; set; }

        private const int SIZE = 26;

        public TrieNode(char val)
        {
            this.val = val;
            this.children = new TrieNode[SIZE];
            // Not needed, as they are null by default
            //for (int i = 0; i < 26; i++)
            //{
            //    this.children[i] = null;
            //}
        }
    }
}
