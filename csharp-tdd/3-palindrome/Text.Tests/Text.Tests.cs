using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class Tests
    {
        [Test]
        public void xempty()
        {
            Assert.AreEqual(true, Str.IsPalindrome(""));
        }

        [Test]
        public void xis()
        {
            Assert.AreEqual(true, Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void xnotis()
        {
            Assert.AreEqual(true, Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
    }
}
