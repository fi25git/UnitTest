using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Person;

namespace UnitTestPerson
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNewPersonIsLedig()
        {
            Person.Person neuling = new Person.Person();
            Assert.AreEqual(true, neuling.Ledig);
            Assert.AreEqual(false, neuling.Geschieden);
            Assert.AreEqual(false, neuling.Verheiratet);
            Assert.AreEqual(false, neuling.Verwitwet);
        }

        [TestMethod]
        public void TestPersonLedig2Verheiratet()
        {
            Person.Person neuling = new Person.Person();
            neuling.heiraten();
            Assert.AreEqual(false, neuling.Ledig);
            Assert.AreEqual(false, neuling.Geschieden);
            Assert.AreEqual(true, neuling.Verheiratet);
            Assert.AreEqual(false, neuling.Verwitwet);
        }
        [TestMethod]
        public void TestPersonLedig2Verheiratet2annuliert()
        {
            Person.Person neuling = new Person.Person();
            neuling.heiraten();
            neuling.annulieren();
            Assert.AreEqual(true, neuling.Ledig);
            Assert.AreEqual(false, neuling.Geschieden);
            Assert.AreEqual(false, neuling.Verheiratet);
            Assert.AreEqual(false, neuling.Verwitwet);
        }
        [TestMethod]
        public void TestPersonledig2Verheiratet2Geschieden()
        {
            Person.Person neuling = new Person.Person();
            neuling.heiraten();
            neuling.scheiden();
            Assert.AreEqual(false, neuling.Ledig);
            Assert.AreEqual(true, neuling.Geschieden);
            Assert.AreEqual(false, neuling.Verheiratet);
            Assert.AreEqual(false, neuling.Verwitwet);
        }
        [TestMethod]
        public void TestPersonledig2Verheiratet2Verwitvert()
        {
            Person.Person neuling = new Person.Person();
            neuling.heiraten();
            neuling.PartnerTod();
            Assert.AreEqual(false, neuling.Ledig);
            Assert.AreEqual(false, neuling.Geschieden);
            Assert.AreEqual(false, neuling.Verheiratet);
            Assert.AreEqual(true, neuling.Verwitwet);
        }
        [TestMethod]
        public void TestPersonledig2Verheiratet2Verwitvert2Heirat2anulliert()
        {
            Person.Person neuling = new Person.Person();
            neuling.heiraten();
            neuling.PartnerTod();
            neuling.heiraten();
            neuling.annulieren();
            Assert.AreEqual(false, neuling.Ledig);
            Assert.AreEqual(false, neuling.Geschieden);
            Assert.AreEqual(false, neuling.Verheiratet);
            Assert.AreEqual(true, neuling.Verwitwet);
        }
        [TestMethod]
        public void TestPersonledig2Verheiratet2geschieden2Heirat2anulliert()
        {
            Person.Person neuling = new Person.Person();
            neuling.heiraten();
            neuling.scheiden();
            neuling.heiraten();
            neuling.annulieren();
            Assert.AreEqual(false, neuling.Ledig);
            Assert.AreEqual(true, neuling.Geschieden);
            Assert.AreEqual(false, neuling.Verheiratet);
            Assert.AreEqual(false, neuling.Verwitwet);
        }

    }
}
