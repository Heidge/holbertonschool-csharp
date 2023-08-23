using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> list = new List<int>() { -1, -2, -3 };
            Assert.AreEqual(Operations.Max(list), -1);
        }
        [Test]
        public void Test2()
        {
            List<int> list = new List<int>() { -3, -2, -1 };
            Assert.AreEqual(Operations.Max(list), -1);
        }
        [Test]
        public void Test3()
        {
            List<int> list = new List<int>() { -2, -1, -3 };
            Assert.AreEqual(Operations.Max(list), -1);
        }
        [Test]
        public void Test4()
        {
            List<int> list = new List<int>();
            Assert.AreEqual(Operations.Max(list), 0);
        }
    }
}
