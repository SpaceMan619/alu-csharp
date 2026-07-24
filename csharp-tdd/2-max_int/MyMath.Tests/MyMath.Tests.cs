using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class OperationsTests
    {
        [Test]
        public void maxpositive()
        {
            List<int> digits = new List<int> { 0, 9, -2, 3, 44, 5, 6, 7, 8, 1 };
            Assert.AreEqual(44, Operations.Max(digits));
        }

        [Test]
        public void xempty()
        {
            Assert.AreEqual(0, Operations.Max(new List<int>()));
        }

        [Test]
        public void xnull()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }
    }
}
