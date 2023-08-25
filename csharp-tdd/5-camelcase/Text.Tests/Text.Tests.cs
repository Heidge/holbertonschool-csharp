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
            string test_string = "jordanShelbyAlexShikamalex";
            Assert.AreEqual(Str.CamelCase(test_string), 4);
        }
        [Test]
        public void Test2()
        {
            string test_string = "jordan";
            Assert.AreEqual(Str.CamelCase(test_string), 1);
        }
        [Test]
        public void Test3()
        {
            string test_string = "";
            Assert.AreEqual(Str.CamelCase(test_string), 0);
        }
        [Test]
        public void Test4()
        {
            string test_string = "jordanShelby";
            Assert.AreEqual(Str.CamelCase(test_string), 2);
        }


    }
}
