using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Tests <see cref="Operations"/>.</summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>Verifies maximum values for populated and empty lists.</summary>
        [Test]
        public void Max_ReturnsGreatestValueOrZero()
        {
            Assert.That(Operations.Max(new List<int> { -4, -1, -9 }), Is.EqualTo(-1));
            Assert.That(Operations.Max(new List<int>()), Is.EqualTo(0));
        }
    }
}
