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
            Assert.AreEqual(Str.UniqueChar(test_string), -1);
        }

        public void Test2()
        {
            string test_string = "bob";
            Assert.AreEqual(Str.UniqueChar(test_string), 2);
        }
    }
}
