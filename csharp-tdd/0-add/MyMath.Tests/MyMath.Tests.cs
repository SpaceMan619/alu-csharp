using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Tests <see cref="Operations"/>.</summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>Verifies addition for representative integer values.</summary>
        [TestCase(0, 0, 0)]
        [TestCase(2, 3, 5)]
        [TestCase(-2, 3, 1)]
        public void Add_ReturnsSum(int a, int b, int expected)
        {
            Assert.That(Operations.Add(a, b), Is.EqualTo(expected));
        }
    }
}
