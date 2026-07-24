using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests.ModelTests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesBreadWithRequestedLoaves()
        {
            Bread bread = new Bread(3);

            Assert.AreEqual(typeof(Bread), bread.GetType());
            Assert.AreEqual(3, bread.Loaves);
        }

        [TestMethod]
        public void Loaves_CanBeUpdatedThroughAutoProperty()
        {
            Bread bread = new Bread(3);

            bread.Loaves = 4;

            Assert.AreEqual(4, bread.Loaves);
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 5)]
        [DataRow(2, 10)]
        [DataRow(3, 10)]
        [DataRow(4, 15)]
        [DataRow(6, 20)]
        public void CalculateCost_AppliesBuyTwoGetOneFreeDeal(int loaves, float expectedCost)
        {
            Bread bread = new Bread(loaves);

            Assert.AreEqual(expectedCost, bread.CalculateCost());
        }
    }

    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesPastryWithRequestedQuantity()
        {
            Pastry pastry = new Pastry(3);

            Assert.AreEqual(typeof(Pastry), pastry.GetType());
            Assert.AreEqual(3, pastry.Pastries);
        }

        [TestMethod]
        public void Pastries_CanBeUpdatedThroughAutoProperty()
        {
            Pastry pastry = new Pastry(3);

            pastry.Pastries = 4;

            Assert.AreEqual(4, pastry.Pastries);
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 6)]
        [DataRow(8, 12)]
        public void CalculateCost_AppliesBuyThreeGetOneFreeDeal(int pastries, float expectedCost)
        {
            Pastry pastry = new Pastry(pastries);

            Assert.AreEqual(expectedCost, pastry.CalculateCost());
        }
    }
}
