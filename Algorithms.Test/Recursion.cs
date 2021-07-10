using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Recursion;
using System;

namespace Algorithms.Test
{
    [TestClass]
    public class Recursion
    {
        [TestMethod]
        public void BasicTest()
        {
            int x = 3;
            Basic.Fun1(x);
            Console.WriteLine("------");
            Basic.Fun2(x);
            Console.WriteLine("------");
            var result = Basic.Fun3(3);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void FindFactorial()
        {
            var result = Factorial.FindFactorial(4);
            Assert.AreEqual(24, result);

            var result2 = Factorial.FindFactorialIterative(4);
            Assert.AreEqual(24, result2);

            Factorial factorial = new Factorial();
            var result3 = factorial.RecursiveMemoizationDictionary(4);
            Assert.AreEqual(24, result3);

            var result4 = factorial.RecursiveMemoizationArray(4);
            Assert.AreEqual(24, result4);
        }

        [TestMethod]
        public void FindPermutations()
        {
            List<int> array = new List<int>() { 1, 2, 3 };
            //var result = Permutations.GetPermutations(array);
            var result = PermutationsOlder.GetPermutationsBacktrack(array);
            foreach (var perm in result)
            {
                foreach (var num in perm)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void FindPermutationsInString()
        {
            string str = "ABC";
            PermutationsInString.Driver(str);
        }

        [TestMethod]
        public void FindPermutationsUnique()
        {
            int[] array = new int[] { 1, 2, 2 };
            var result = PermutationsOlder.GetPermutationsUnique(array);
            //var result = Permutations.PermuteUniqueBackTrack(array);
            foreach (var perm in result)
            {
                foreach (var num in perm)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void FindSubsets()
        {
            int[] array = new int[] { 1, 2, 3 };
            //var result = Subsets.FindAllSubsets(array);
            var result = Subsets.FindAllSubsetsBackTrack(array);
            foreach (var set in result)
            {
                foreach (var num in set)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void FindSubsetsWithDup()
        {
            int[] array = new int[] { 1, 2, 2 };
            //var result = Subsets.FindAllSubsetsWithDup(array);
            var result = Subsets.FindAllSubsetsBackTrackWithDup(array);
            foreach (var set in result)
            {
                foreach (var num in set)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void CanWordBreak()
        {
            string s = "code";
            List<string> wordDict = new List<string>() { "c", "od", "e", "x" };
            bool result = WordBreak.CanWordBreak(s, wordDict);
            Assert.AreEqual(result, true);
        }

        // Not good as we need to loop over dictionary words
        // cannot scale
        [TestMethod]
        public void WordBreak2()
        {
            string s = "catsanddog";
            List<string> wordDict = new List<string>() { "cat", "cats", "and", "sand", "dog" };
            var result = WordBreak.WordBreak2(s, wordDict);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }

        [TestMethod]
        public void SumOfNumbers()
        {
            SumOfNaturalNumbers sumOfNatural = new SumOfNaturalNumbers();
            int n = 5;
            int result1 = sumOfNatural.SumRecursive(n);
            int result2 = sumOfNatural.SumIterative(n);
            int result3 = sumOfNatural.Sum(n);

            Assert.AreEqual(15, result1);
            Assert.AreEqual(15, result2);
            Assert.AreEqual(15, result3);
        }

        [TestMethod]
        public void TOH()
        {
            TowersOfHanoi.TOH(10, 1, 2, 3);
        }

        [TestMethod]
        public void MaxLenConcatenatedStrUnique()
        {
            string[] arr = { "cha", "r", "act", "ers" }; // 6
            string[] arr2 = { "un", "iq", "ue" }; // 4
            string[] arr3 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" }; // 16
            MaxLenConcatenatedStringWithUniqueChar maxLenConcatenatedStringWithUniqueChar = new MaxLenConcatenatedStringWithUniqueChar();
            var result = maxLenConcatenatedStringWithUniqueChar.MaxLength(arr3);
            Assert.AreEqual(16, result);
        }
    }
}
