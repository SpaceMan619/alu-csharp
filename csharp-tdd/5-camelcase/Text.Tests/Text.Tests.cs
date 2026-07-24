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
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void xtwo()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void xping()
        {
            Assert.AreEqual(5, Str.CamelCase("papaNoelEsUnZombie"));
        }
    }
}
