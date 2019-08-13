using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaprekarUnitTestProject
{
    [TestClass]
    public class KaprekarZahlenTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, Kaprekar.getNumber(1));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(9, Kaprekar.getNumber(2));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(45, Kaprekar.getNumber(3));
        }
    }
}
