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
    }
}
