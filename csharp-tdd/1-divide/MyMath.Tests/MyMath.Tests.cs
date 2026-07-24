using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Tests <see cref="Matrix"/>.</summary>
    [TestFixture]
    public class MatrixTests
    {
        /// <summary>Verifies element-wise integer division.</summary>
        [Test]
        public void Divide_ReturnsNewDividedMatrix()
        {
            int[,] result = Matrix.Divide(new[,] { { 10, 8 }, { 6, 4 } }, 2);
            Assert.That(result, Is.EqualTo(new[,] { { 5, 4 }, { 3, 2 } }));
        }

        /// <summary>Verifies null input returns null.</summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            Assert.That(Matrix.Divide(null, 2), Is.Null);
        }
    }
}
