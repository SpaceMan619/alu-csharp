using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Tests <see cref="Str"/>.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Verifies the first non-repeating character index.</summary>
        [Test]
        public void UniqueChar_ReturnsFirstUniqueIndexOrMinusOne()
        {
            Assert.That(Str.UniqueChar("aabbcdde"), Is.EqualTo(4));
            Assert.That(Str.UniqueChar("aabb"), Is.EqualTo(-1));
        }
    }
}
