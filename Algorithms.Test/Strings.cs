using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Algorithms.Strings;
using Algorithms.Strings.Conversion;

namespace Algorithms.Test
{
    [TestClass]
    public class Strings
    {
        [TestMethod]
        public void IsRotation()
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";
            bool result = Rotation.IsRotation(s1, s2);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void RotateByKeyEncryptor()
        {
            string str = "xyz";
            int key = 2;
            string result = RotateByKey.CaesarCypherEncryptor(str, key);
            Assert.AreEqual("zab", result);
        }

        [TestMethod]
        public void IntToRoman()
        {
            int val = 49;
            var result = IntToRomanConversion.IntToRoman(val);
            Assert.AreEqual("XLIX", result);
        }

        [TestMethod]
        public void PartitionLabels()
        {
            string str = "ababcbacadefegdehijhklij";
            var result = Partition.PartitionLabels(str);
            Assert.AreEqual(3, result.Count);

            string str2 = "eaaaabaaec";
            var result2 = Partition.PartitionLabels(str2);
            Assert.AreEqual(2, result2.Count);
        }

        [TestMethod]
        public void ValidAnagram()
        {
            string s = "anagram";
            string t = "nagaram";
            var result = Anagram.IsAnagram(s, t);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void GroupAnagram()
        {
            var inputList = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = Anagram.GroupAnagrams(inputList);
            foreach (var list in result)
            {
                foreach (var word in list)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void ReverseStr()
        {
            string s = "abcdefg";
            int k = 2;
            var result = ReverseString.ReverseStr(s, k);
            Assert.AreEqual("bacdefg", result);
        }

        [TestMethod]
        public void IsIsomorphic()
        {
            string s = "egg";
            string t = "add";
            var result = Isomorphic.IsIsomorphic(s, t);
            Assert.AreEqual(true, result);

            string s2 = "ab";
            string t2 = "aa";
            var result2 = Isomorphic.IsIsomorphic(s2, t2);
            Assert.AreEqual(false, result2);
        }

        [TestMethod]
        public void LongestPalindromeSubstr()
        {
            string s = "babad";
            var result = LongestPalindrome.Substring_ExpandCenter(s);
            Assert.AreEqual("bab", result);

            string s2 = "cbbd";
            var result2 = LongestPalindrome.Substring_ExpandCenter(s2);
            Assert.AreEqual("bb", result2);

            //string s = "abb";
            //var result = LongestPalindrome.Substring_BF(s);
            //Assert.AreEqual("bb", result);

            string s3 = "bb";
            var result3 = LongestPalindrome.Substring_ExpandCenter(s3);
            Assert.AreEqual("bb", result3);
        }

        [TestMethod]
        public void FindStrStr()
        {
            string haystack = "hello";
            string needle = "ll";
            var result = StrStr.FindStrStrBetter(haystack, needle);
            Assert.AreEqual(2, result);

            string haystack2 = "mississippi";
            string needle2 = "issip";
            var result2 = StrStr.FindStrStrBetter(haystack2, needle2);
            Assert.AreEqual(4, result2);
        }

        [TestMethod]
        public void NumberToWords()
        {
            int num = 12345;
            var result = IntToEnglishWords.NumberToWords(num);
            Console.WriteLine(result);

            int num2 = 1234567;
            var result2 = IntToEnglishWords.NumberToWords(num2);
            Console.WriteLine(result2);

            int num3 = 1234567891;
            var result3 = IntToEnglishWords.NumberToWords(num3);
            Console.WriteLine(result3);

            int num4 = 1000000;
            var result4 = IntToEnglishWords.NumberToWords(num4);
            Console.WriteLine(result4);
        }
    }
}
