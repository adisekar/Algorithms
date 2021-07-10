using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.ArrayADT;

namespace DS.Test
{
    [TestClass]
    public class Array
    {
        [TestMethod]
        public void Operations()
        {
            ArrayOperations array = new ArrayOperations();

            array.Creation();
            array.Push(50);


            array.Insert(4, 34);
            array.Display();

            Console.WriteLine("------------------------");
            array.Delete(4);
            array.Display();

            Console.WriteLine("Min = " + array.GetMin());
            Console.WriteLine("Sum = " + array.GetSum());
            Console.WriteLine("Average = " + array.GetAverage());
            Console.WriteLine("Sum Recusrive= " + array.GetSumRecursive(array.currentFilledItems));
        }
    }
}
