using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingListApp.src;
using System;

namespace ShoppingListApp.UnitTests
{
    [TestClass]
    public class ShopTests
    {
        [TestInitialize]
        public void Setup()
        {
            // clear the list of all shops before each test
            Shop.AllShops.Clear();
        }

        [TestMethod]
        public void TestCreateShopSuccess()
        {
            // Arrange
            string name = "Test Shop";

            // Act
            Shop shop = new Shop(name);

            // Assert
            Assert.AreEqual(name, shop.Name);
            Assert.IsFalse(shop.IsFiltered);
            Assert.AreEqual(1, Shop.AllShops.Count);
            Assert.AreEqual(shop, Shop.AllShops[0]);
        }

        [TestMethod]
        public void TestCreateShopDuplicate()
        {
            // Arrange
            string name = "Test Shop";

            // create a shop with the same name manually before the test
            Shop existingShop = new Shop(name);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Shop(name));
        }

        [TestMethod]
        public void TestIsFiltered()
        {
            // Arrange
            string name = "Test Shop";
            Shop shop = new Shop(name);

            // Act
            shop.IsFiltered = true;

            // Assert
            Assert.IsTrue(shop.IsFiltered);
        }

        [TestMethod]
        public void TestAllShops()
        {
            // Arrange
            string name1 = "Test Shop 1";
            string name2 = "Test Shop 2";

            // create two shops
            Shop shop1 = new Shop(name1);
            Shop shop2 = new Shop(name2);

            // Act & Assert
            Assert.AreEqual(2, Shop.AllShops.Count);
            Assert.AreEqual(shop1, Shop.AllShops[0]);
            Assert.AreEqual(shop2, Shop.AllShops[1]);
        }

        [TestMethod]
        public void TestDisableAllFilters()
        {
            // Arrange
            string name1 = "Test Shop 1";
            string name2 = "Test Shop 2";

            // create two shops and set their filters
            Shop shop1 = new Shop(name1);
            shop1.IsFiltered = true;
            Shop shop2 = new Shop(name2);
            shop2.IsFiltered = true;

            // Act
            Shop.DisableAllFilters();

            // Assert
            Assert.IsFalse(shop1.IsFiltered);
            Assert.IsFalse(shop2.IsFiltered);
        }
    }
}
