using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Searching;
using System;
using Algorithms.DFS;

namespace Algorithms.Test
{
    [TestClass]
    public class DFSProblems
    {
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
