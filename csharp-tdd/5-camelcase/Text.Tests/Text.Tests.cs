using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Tests <see cref="Str"/>.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Verifies camelCase word counts.</summary>
        [Test]
        public void CamelCase_ReturnsWordCount()
        {
            Assert.That(Str.CamelCase("saveChangesInTheEditor"), Is.EqualTo(5));
            Assert.That(Str.CamelCase(string.Empty), Is.EqualTo(0));
        }
    }
}
