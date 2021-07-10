using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.Backtracking;

namespace Algorithms.Test
{
    [TestClass]
    public class Backtracking
    {

        [TestMethod]
        public void FindCombinationSum()
        {
            int[] A = { 2, 3, 5 };
            int target = 8;
            CombinationSum combinationSum = new CombinationSum();
            var result = combinationSum.FindCombinationSum(A, target);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void FindPermutations()
        {
            int[] A = { 1, 2, 3 };
            Permutations permutations = new Permutations();
            var result = permutations.Permute(A);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }


        [TestMethod]
        public void FindPermutationsWithoutDups()
        {
            int[] A = { 1, 1, 2 };
            PermutationsWithoutDups permutations = new PermutationsWithoutDups();
            var result = permutations.Permute(A);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void GenerateSubsets()
        {
            int[] A = { 1, 2, 3 };
            Subsets subsets = new Subsets();
            var result = subsets.FindSubsets(A);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void GenerateSubsetsWithoutDups()
        {
            int[] A = { 1, 1, 2 };
            SubsetsWithoutDups subsets = new SubsetsWithoutDups();
            var result = subsets.FindSubsets(A);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }


        [TestMethod]
        public void FindCombinations()
        {
            int n = 4;
            int r = 2;
            Combinations combinations = new Combinations();
            var result = combinations.Combine(n, r);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
