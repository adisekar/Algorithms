using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Tries;

namespace Algorithms.Test
{
    [TestClass]
    public class Tries
    {
        [TestMethod]
        public void Construction()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            trie.Insert("app");
            var result = trie.Search("app");   // returns true
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void LCP()
        {
            string[] words = { "flower", "flow", "flight" };
            //string[] words = { "a" };
            var result = LongestCommonPrefix.LCP(words);
            Assert.AreEqual("fl", result);
        }
    }
}
