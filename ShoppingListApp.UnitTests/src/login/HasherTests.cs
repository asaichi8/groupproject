using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingListApp.src.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.UnitTests.src.login
{
    [TestClass]
    public class HasherTests
    {
        [TestMethod]
        public void TestHashAndVerify()
        {
            // Arrange
            string password = "TestP@ssw0rd";

            // Act
            byte[] hash = Hasher.Hash(password);
            bool result = Hasher.VerifyHash(password, hash);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestVerifyInvalidPassword()
        {
            // Arrange
            string password = "TestP@ssw0rd";
            string invalidPassword = "Testp@ssw0rd";

            // Act
            byte[] hash = Hasher.Hash(password);
            bool result = Hasher.VerifyHash(invalidPassword, hash);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
