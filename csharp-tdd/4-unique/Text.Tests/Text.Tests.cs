using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string test_string = "bo";
            Assert.AreEqual(Str.UniqueChar(test_string), 0);
        }
        [Test]
        public void Test2()
        {
            string test_string = "helloholberton";
            Assert.AreEqual(Str.UniqueChar(test_string), 8);
        }
    }
}
