using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(4, 1, 15, 20, 45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, 15, 20, 45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentСountMinus()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, -15, 20, 45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentСountZero()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, 0, 20, 45);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidthZero()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, 2, 0, 45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidthMinus()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, 2, -90, 45);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_NonExistentLenghtZero()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, 2, 5, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentLenghtMinus()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 8, 2, -90, -1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentAlltMinus()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(-2, -8, -2, -90, -1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentAlltZero()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(0, 0, 0, 0, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_1_1_15_25_34()
        {
            int expected = 14067;
            int actual = Calculation.GetQuantityForProduct(1, 1, 15, 25, 34);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_1_1_1_5_5()
        {
            int expected = 27;
            int actual = Calculation.GetQuantityForProduct(1, 1, 1, 5, 5);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void GetQuantityForProduct_0_2_99_99_5()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(0, 2, 99, 99, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_2_0_99_99_5()
        {
            int expected = -1;
            int actual = Calculation.GetQuantityForProduct(2, 0, 99, 99, 5);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_3_2_99_99_5()
        {
            int expected = 413607;
            int actual = Calculation.GetQuantityForProduct(3, 2, 99, 99, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
