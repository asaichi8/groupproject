using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingListApp.src.Login;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.UnitTests.src.login
{
    [TestClass]
    public class LoginUtilsTests
    {
        [TestMethod]
        public void TestValidChar()
        {
            char validChar = 'a'; // lowercase letter
            bool result = LoginUtils.IsUsernameCharValid(validChar);
            Assert.IsTrue(result);

            validChar = 'A'; // uppercase letter
            result = LoginUtils.IsUsernameCharValid(validChar);
            Assert.IsTrue(result);

            validChar = '0'; // digit
            result = LoginUtils.IsUsernameCharValid(validChar);
            Assert.IsTrue(result);

            validChar = '\b'; // backspace
            result = LoginUtils.IsUsernameCharValid(validChar);
            Assert.IsTrue(result);

            validChar = (char)0x10; // control character (e.g. Ctrl+P)
            result = LoginUtils.IsUsernameCharValid(validChar);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestInvalidChar()
        {
            char invalidChar = '$'; // not a-z, A-Z, 0-9, backspace, or control character
            bool result = LoginUtils.IsUsernameCharValid(invalidChar);
            Assert.IsFalse(result);

            invalidChar = '+';
            result = LoginUtils.IsUsernameCharValid(invalidChar);
            Assert.IsFalse(result);

            invalidChar = '_'; 
            result = LoginUtils.IsUsernameCharValid(invalidChar);
            Assert.IsFalse(result);

            invalidChar = ' ';
            result = LoginUtils.IsUsernameCharValid(invalidChar);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestValidPassword()
        {
            string validPassword = "Test123!321"; // contains at least one lowercase letter, one uppercase letter, one digit, and one special character
            bool result = LoginUtils.ValidatePassword(validPassword);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestInvalidPasswordLength()
        {
            string invalidPassword = "tE3@st"; // less than minimum length of 8
            bool result = LoginUtils.ValidatePassword(invalidPassword);
            Assert.IsFalse(result);

            invalidPassword = "TEST123!AH"; // no lowercase letter
            result = LoginUtils.ValidatePassword(invalidPassword);
            Assert.IsFalse(result);

            invalidPassword = "test123!df"; // no uppercase letter
            result = LoginUtils.ValidatePassword(invalidPassword);
            Assert.IsFalse(result);

            invalidPassword = "Test!@@aBg"; // no digit
            result = LoginUtils.ValidatePassword(invalidPassword);
            Assert.IsFalse(result);

            invalidPassword = "Test123ACd"; // no special character
            result = LoginUtils.ValidatePassword(invalidPassword);
            Assert.IsFalse(result);
        }
    }
}
