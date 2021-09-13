using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Algorithms.Geometry;

namespace Algorithms.Test
{
    [TestClass]
    public class Geometry
    {
        [TestMethod]
        public void IsRobotBoundInCircle()
        {
            string s = "GLGLGGLGL";
            var result = RobotBoundInCircle.IsRobotBounded(s);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsRobotReturnToOrigin()
        {
            /*
             * Input: moves = "UD"
Output: true
Explanation: The robot moves up once, and then down once. All moves have the same magnitude, so it ended up at the origin where it started. Therefore, we return true.
           */
            string moves = "UD";
            var result = RobotReturnToOrigin.JudgeCircle(moves);
            Assert.AreEqual(true, result);

            string moves2 = "LDRRLRUULR";
            var result2 = RobotReturnToOrigin.JudgeCircle(moves2);
            Assert.AreEqual(false, result2);
        }
    }
}
