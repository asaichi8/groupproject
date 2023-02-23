using Konscious.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public static class Hasher
    {
        /// <summary>
        /// Generates a random 32-byte salt for enhanced security.
        /// </summary>
        /// <returns>32-byte array containing the salt.</returns>
        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        /// <summary>
        /// Salts and hashes a password to ensure it isn't stored in plain text.
        /// </summary>
        /// <returns>32-byte array containing the salted and hashed password.</returns>
        private static byte[] HashAndSaltText(string s, byte[] salt)
        {
            byte[] hashedPassword = new Argon2id(Encoding.UTF8.GetBytes(s))
            {
                Salt = salt,
                DegreeOfParallelism = 8,
                MemorySize = 1024 * 64,
                Iterations = 4
            }.GetBytes(32);

            return hashedPassword;
        }

        /// <summary>
        /// A salt needs to be stored alongside the hashed text, and so this function combines
        /// the salt and hashed password into a single 64-byte array.
        /// </summary>
        /// <param name="s">The string to be hashed.</param>
        /// <returns>64-byte array containing the salt (32 bytes) + hashed text (32 bytes).</returns>
        public static byte[] Hash(string s)
        {
            byte[] salt = GenerateSalt();
            byte[] szHashedPass = HashAndSaltText(s, salt);

            byte[] combined = new byte[64];

            Buffer.BlockCopy(salt, 0, combined, 0, salt.Length); //copy salt to first 32 bytes of "combined"
            Buffer.BlockCopy(szHashedPass, 0, combined, salt.Length, szHashedPass.Length); // copy hashed+salted password to last 32 bytes of "combined"

            return combined;
        }

        /// <summary>
        /// Compare the hashed password to given text.
        /// </summary>
        /// <param name="text">The text the hashed byte array is to be checked against.</param>
        /// <param name="saltHash">The salted+hashed byte array the text is to be checked against.</param>
        /// <returns>TRUE if success, FALSE if failed.</returns>
        public static bool VerifyHash(string text, byte[] saltHash)
        {
            byte[] salt = new byte[32];
            byte[] pass = new byte[32];

            Buffer.BlockCopy(saltHash, 0, salt, 0, salt.Length);
            Buffer.BlockCopy(saltHash, salt.Length, pass, 0, pass.Length);

            return VerifyHash(text, salt, pass);
        }
        /// <summary>
        /// Compare the hashed password to given text.
        /// </summary>
        /// <param name="text">The text the hashed byte array is to be checked against.</param>
        /// <param name="salt">The salt (first 32 bytes of salt+hash combination) of the hash.</param>
        /// <param name="hash">The hash (last 32 bytes of salt+hash combination) that the text will be checked against.</param>
        /// <returns>TRUE if success, FALSE if failed.</returns>
        public static bool VerifyHash(string text, byte[] salt, byte[] hash)
        {
            return HashAndSaltText(text, salt).SequenceEqual(hash);
        }
    }
}
