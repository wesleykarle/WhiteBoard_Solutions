using Microsoft.VisualStudio.TestTools.UnitTesting;
using OccurrenceCount;

namespace OccurrenceCount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, Program.CountOccurrence("Hello", 'l'));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, Program.CountOccurrence("Wesley", 'e'));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, Program.CountOccurrence("Mississippi", 's'));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, Program.CountOccurrence("CaliforniA", 'A'));
        }
    }
}
