using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Queue;

namespace Algorithms.Test
{
    [TestClass]
    public class Queues
    {
        [TestMethod]
        public void MovingAverageDataStream()
        {
            List<double> result = new List<double>();

            MovingAverage movingAverage = new MovingAverage(3);
            result.Add(movingAverage.Next(1)); // return 1.0 = 1 / 1
            result.Add(movingAverage.Next(10)); // return 5.5 = (1 + 10) / 2
            result.Add(movingAverage.Next(3)); // return 4.66667 = (1 + 10 + 3) / 3
            result.Add(movingAverage.Next(5)); // return 6.0 = (10 + 3 + 5) / 3

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
