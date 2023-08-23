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
            
            List<int> list = new List<int>() { -85, -2, -3 };
            Assert.AreEqual(Operations.Max(list), -2);
        }
        [Test]
        public void Test2()
        {
            
            List<int> list = new List<int>();
            Assert.AreEqual(Operations.Max(list), 0);
        }
    }
}
