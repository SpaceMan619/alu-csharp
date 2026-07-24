using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class MatrixTests
    {
        [Test]
        public void positivetwo()
        {
            int[,] matrix = new int[,] {{ 30, 40 }, { 5, 11 }, { 15, 6 }, { 7, 8 }};
            int n = 2;
            int[,] result = Matrix.Divide(matrix, n);
            Assert.AreEqual(new int[,] {{ 15, 20 }, { 2, 5 }, { 7, 3 }, { 3, 4 }}, result);
        }

        [Test]
        public void zero()
        {
            int[,] matrix = new int[,] {{ 30, 40 }, { 5, 11 }, { 15, 6 }, { 7, 8 }};
            int[,] result = Matrix.Divide(matrix, 0);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void snull()
        {
            int[,] result = Matrix.Divide(null, 3);
            Assert.AreEqual(null, result);
        }
    }
}
