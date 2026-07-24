using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class Tests
    {
        [Test]
        public void xfour()
        {
            Assert.AreEqual(4, Str.UniqueChar("ababc"));
        }

        [Test]
        public void xempty()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void xone()
        {
            Assert.AreEqual(0, Str.UniqueChar("d"));
        }

        [Test]
        public void xnone()
        {
            Assert.AreEqual(-1, Str.UniqueChar("ddggttrrffttffddgg"));
        }

        [Test]
        public void xnull()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }
    }
}
