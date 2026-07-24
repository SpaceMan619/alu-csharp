using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Tests <see cref="Str"/>.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Verifies case, spaces, and punctuation are ignored.</summary>
        [Test]
        public void IsPalindrome_IgnoresCaseAndPunctuation()
        {
            Assert.That(Str.IsPalindrome("A man, a plan, a canal: Panama."), Is.True);
            Assert.That(Str.IsPalindrome("Racecar"), Is.True);
            Assert.That(Str.IsPalindrome("not one"), Is.False);
            Assert.That(Str.IsPalindrome(string.Empty), Is.True);
        }
    }
}
