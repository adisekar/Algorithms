using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Algorithms.Graph.WordLadder;

namespace Algorithms.Test
{
    [TestClass]
    public class WordLadderTest
    {
        [TestMethod]
        public void WordLadderTest1()
        {
            List<string> wordList = new List<string>() { "hot", "dot", "lot", "log", "cog" };
            string beginWord = "hit";
            string endWord = "cog";
            var result = WordLadder1.LadderLength(beginWord, endWord, wordList);
            Assert.AreEqual(5, result);

            List<string> wordList2 = new List<string>() { "most", "mist", "miss", "lost", "fist", "fish" };
            string beginWord2 = "lost";
            string endWord2 = "miss";
            var result2 = WordLadder1.LadderLength_BF(beginWord2, endWord2, wordList2);
            Assert.AreEqual(4, result2);

            List<string> wordList3 = new List<string>() { "lest", "leet", "lose", "code", "lode", "robe", "lost" };
            string beginWord3 = "leet";
            string endWord3 = "code";
            var result3 = WordLadder1.LadderLength_BF(beginWord3, endWord3, wordList3);
            Assert.AreEqual(6, result3);
        }

        [TestMethod]
        public void WordLadder2()
        {
            //List<string> wordList = new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" };
            //string beginWord = "hit";
            //string endWord = "cog";
            //var result = WordLadder.FindLadders(beginWord, endWord, wordList);
            //foreach (var ladder in result)
            //{
            //    foreach (var word in ladder)
            //    {
            //        Console.Write(word + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
