﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaprekarZahlen;

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
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(55, Kaprekar.getNumber(4));
        }
        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(99, Kaprekar.getNumber(5));
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(297, Kaprekar.getNumber(6));
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(703, Kaprekar.getNumber(7));
        }
        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(999, Kaprekar.getNumber(8));
        }
        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(2223, Kaprekar.getNumber(9));
        }
        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(2728, Kaprekar.getNumber(10));
        }
        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(4873, Kaprekar.getNumber(11));
        }
        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual(4950, Kaprekar.getNumber(12));
        }
        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual(5050, Kaprekar.getNumber(13));
        }
        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual(5292, Kaprekar.getNumber(14));
        }
        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual(7272, Kaprekar.getNumber(15));
        }
        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual(7777, Kaprekar.getNumber(16));
        }
        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual(9999, Kaprekar.getNumber(17));
        }
    }
}
