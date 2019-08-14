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
        public void TestNewPersonIsGeschieden()
        {
            Person.Person geschiedene = new Person.Person();
            Assert.AreEqual(false, geschiedene.Ledig);
            Assert.AreEqual(true, geschiedene.Geschieden);
            Assert.AreEqual(false, geschiedene.Verheiratet);
            Assert.AreEqual(false, geschiedene.Verwitwet);

        }

        [TestMethod]
        public void TestNewPersonIsVerheireitet()
        {
            Person.Person verheiratete = new Person.Person();
            Assert.AreEqual(false, verheiratete.Ledig);
            Assert.AreEqual(false, verheiratete.Geschieden);
            Assert.AreEqual(true, verheiratete.Verheiratet);
            Assert.AreEqual(false, verheiratete.Verwitwet);
           
        }
        
        [TestMethod]
        public void TestNewPersonIsVerwitwet()
        {
            Person.Person verwitwet = new Person.Person();
            Assert.AreEqual(false, verwitwet.Ledig);
            Assert.AreEqual(false, verwitwet.Geschieden);
            Assert.AreEqual(false, verwitwet.Verheiratet);
            Assert.AreEqual(true, verwitwet.Verwitwet);

        }
    }
}
