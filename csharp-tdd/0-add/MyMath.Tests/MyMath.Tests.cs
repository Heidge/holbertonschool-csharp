using NUnit.Framework;

namespace MyMath.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            tests = new Tests();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
