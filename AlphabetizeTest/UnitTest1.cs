using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabetize;

namespace Alphabetize
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("abc",Program.Alphabetize("cba"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("aeMmNy", Program.Alphabetize("MyName"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("aBbCot", Program.Alphabetize("BobCat"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("EMNORST", Program.Alphabetize("MONSTER"));
        }
    }
}
