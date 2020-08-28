using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.Stacks;

namespace DS.Test
{
    [TestClass]
    public class Stacks
    {
        [TestMethod]
        public void Construction()
        {
            Stack stack = new Stack();
            //stack.Pop();
            stack.Push(10);
            stack.Push(5);
            stack.Push(0);
            stack.Peek();
            stack.Pop();

            var result = stack.Print();
            foreach (var val in result)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
