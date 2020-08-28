using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Algorithms.HashMap;

namespace Algorithms.Test
{
    [TestClass]
    public class HashMap
    {

        [TestMethod]
        public void MostCommonWordTest()
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = { "hit" };
            string result = MostCommonWord.MostCommonWordInString(paragraph, banned);
            Assert.AreEqual("ball", result);

            //string paragraph2 = "a, a, a, a, b,b,b,c, c";
            //string[] banned2 = { "a" };
            //string result2 = MostCommonWord.MostCommonWordInString(paragraph2, banned2);
            //Assert.AreEqual("b", result2);
        }

        [TestMethod]
        public void TopKFrequentWord()
        {
            string[] words = { "i", "love", "leetcode", "i", "love", "coding" };
            var result = TopKFrequent.Words(words, 2);
            // Expected : ["i","love"]

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }

        [TestMethod]
        public void TopKFrequentElements()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            var result = TopKFrequent.Elements(nums, 2);
            // Expected : [1,2]

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void CommonChars()
        {
            string[] words = { "bella", "label", "roller" };
            var result = CommonCharacters.CommonChars(words);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }

        [TestMethod]
        public void TopKFrequentWordsInReviews()
        {
            int k = 2;
            string[] keywords = { "anacell", "cetracular", "betacellular" };
            string[] reviews = {
  "Anacell provides the best services in the city",
  "betacellular has awesome services",
  "Best services provided by anacell, everyone should use anacell"
            };
            var result = TopKFrequent.Keywords(reviews, keywords, k);
            // Expected : ["anacell", "betacellular"]

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("------------------------------------------------");

            int k2 = 3;
            string[] keywords2 = { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" };
            string[] reviews2 = {
  "I love anacell Best services; Best services provided by anacell",
  "betacellular has great services",
  "deltacellular provides much better services than betacellular",
  "cetracular is worse than anacell",
  "Betacellular is better than deltacellular"
            };
            var result2 = TopKFrequent.Keywords(reviews2, keywords2, k2);
            // Expected : ["betacellular", "anacell"]

            foreach (var word2 in result2)
            {
                Console.WriteLine(word2);
            }
        }
    }
}
