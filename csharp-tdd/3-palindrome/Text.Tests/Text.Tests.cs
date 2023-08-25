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
            string test_string = "Bob";
            Assert.AreEqual(Str.IsPalindrome(test_string), true);
        }

        [Test]
        public void Test2()
        {
            string test_string = "bob";
            Assert.AreEqual(Str.IsPalindrome(test_string), true);
        }

        [Test]
        public void Test3()
        {
            string test_string = "b,o,b";
            Assert.AreEqual(Str.IsPalindrome(test_string), true);
        }

        [Test]
        public void Test4()
        {
            string test_string = "b o b";
            Assert.AreEqual(Str.IsPalindrome(test_string), true);
        }

        [Test]
        public void Test5()
        {
            string test_string = "";
            Assert.AreEqual(Str.IsPalindrome(test_string), true);
        }

    }
}
