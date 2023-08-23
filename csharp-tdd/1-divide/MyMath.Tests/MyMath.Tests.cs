using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[,] a;
            int[,] b;
            a = new int[,] { { 2, 2 }, { 4, 4 }, { 6, 6 }, { 8, 8 } };
            b = new int[,] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };
            Assert.AreEqual(Matrix.Divide(a, 2), b);
        }

        [Test]
        public void Test2()
        {
            int[,] a;
            int[,] b;
            a = new int[,] { { 2, 2 }, { 4, 4 }, { 6, 6 }, { 8, 8 } };
            b = new int[,] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };
            Assert.AreEqual(Matrix.Divide(a, 0), b);
        }

        [Test]
        public void Test3()
        {
            int[,] a = null;
            int[,] b;
            b = new int[,] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };
            Assert.AreEqual(Matrix.Divide(a, 2), b);
        }
    }
}
