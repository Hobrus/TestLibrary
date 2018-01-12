using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLib;
using System.Collections.Generic;

namespace TestForTestLib
{
    [TestClass]
    public class TestForTest
    {
        [TestMethod]
        public void TestWithoutEx()
        {
            Triangle Triangle1 = new Triangle(1, 1, 1);
            Assert.AreEqual(0, Math.Round(Triangle1.GetS()));
            Triangle Triangle2 = new Triangle(4, 3, 5);
            Assert.AreEqual(6, Math.Round(Triangle2.GetS()));
            Triangle Triangle3 = new Triangle(6, 8, 10);
            Assert.AreEqual(24, Math.Round(Triangle3.GetS()));
        }
    }
}
