using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.Greedy;

namespace Algorithms.Test
{
    [TestClass]
    public class GreedyProblems
    {
        [TestMethod]
        public void TaskSchedulerIntervals()
        {
            char[] tasks = { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B' };
            int n = 2;
            var result = TaskScheduler.LeastInterval(tasks, n);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void MinStepsPilesEqualHeight()
        {
            int[] piles = { 5, 2, 1 };
            var result = MinStepsPiles.MinSteps(piles);
            Assert.AreEqual(3, result);
        }
    }
}
