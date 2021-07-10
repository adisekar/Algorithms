using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.BitManipulation;

namespace Algorithms.Test
{
    [TestClass]
    public class BitManipulationProblems
    {
        [TestMethod]
        public void ReverseIntegerTest()
        {
            int x = 123;
            var result = ReverseInteger.Reverse(x);
            Assert.AreEqual(321, result);

            int x2 = 1534236469;
            var result2 = ReverseInteger.Reverse(x2);
            Assert.AreEqual(0, result2);
        }

        [TestMethod]
        public void AddBinaryStrings()
        {
            string a = "11";
            string b = "1";
            var result = AddBinary.AddBinaryStrings(a, b);
            Assert.AreEqual("100", result);
        }

        [TestMethod]
        public void FindBinaryGap()
        {
            int n = 13;
            BinaryGap binaryGap = new BinaryGap();
            var result = binaryGap.FindBinaryGap(n);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountPrimeNumbers()
        {
            int val = 10;
            var result = Prime.CountPrimes(val);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AtoI()
        {
            string s = "42";
            var result = StringToInteger.MyAtoi(s);
            Assert.AreEqual(42, result);

            string s2 = "3.14159";
            var result2 = StringToInteger.MyAtoi(s2);
            Assert.AreEqual(3, result2);

            string s3 = "9223372036854775808";
            var result3 = StringToInteger.MyAtoi(s3);
            Assert.AreEqual(2147483647, result3);
        }

        [TestMethod]
        public void SwapIntegersWithoutTemp()
        {
            int a = 10;
            int b = 5;
            var result = SwapWithoutTemp.SwapUsingAddition(a, b);
            Assert.AreEqual(5, result.Item1);
            Assert.AreEqual(10, result.Item2);

            var result2 = SwapWithoutTemp.SwapUsingXOR(a, b);
            Assert.AreEqual(5, result2.Item1);
            Assert.AreEqual(10, result2.Item2);
        }
    }
}
