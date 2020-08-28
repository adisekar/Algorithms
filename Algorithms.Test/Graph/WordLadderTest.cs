using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Algorithms.Graph;

namespace Algorithms.Test
{
    [TestClass]
    public class WordLadderTest
    {
        [TestMethod]
        public void WordLadder1()
        {
            List<string> wordList = new List<string>() { "hot", "dot", "lot", "log", "cog" };
            string beginWord = "hit";
            string endWord = "cog";
            var result = WordLadder.LadderLength(beginWord, endWord, wordList);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void WordLadder2()
        {
            List<string> wordList = new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" };
            string beginWord = "hit";
            string endWord = "cog";
            var result = WordLadder.FindLadders(beginWord, endWord, wordList);
            foreach (var ladder in result)
            {
                foreach (var word in ladder)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
