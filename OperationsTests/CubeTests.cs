using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 10;
        private readonly int b = 5;
        // private readonly double c = 10.5;
        //private readonly double d = 20.5;1
        //private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 6.4, 7.8, 9, 10 }
        //private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void cubedTest()
        {
            Assert.AreEqual(1000, Cube.cubed(a));

        }

        [TestMethod()]
        public void cubedTest1()
        {
            Assert.AreEqual(125, Cube.cubed(b));

        }
    }
}
